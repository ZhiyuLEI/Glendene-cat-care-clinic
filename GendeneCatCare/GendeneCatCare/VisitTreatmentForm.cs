// Purpose: set up the form of allocating treatment to visit
// Author: Zhiyu Lei
// Date: 13/08/2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class VisitTreatmentForm : Form
    {
        // add references to the DataModule and MainForm objects, add references for the CurrencyManager objects
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmTreatment;
        private CurrencyManager cmVisit;
        private CurrencyManager cmVisitTreatment;
        private CurrencyManager cmVVT;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;        

        // change the constructor  to accept the DataModule and MainForm references
        public VisitTreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "Treatment"];
            cmVisit = (CurrencyManager)this.BindingContext[DM.DSGlendene, "Visit"];
            cmVisitTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VisitTreatment"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmVVT = (CurrencyManager)this.BindingContext[DM.DSGlendene, "Visit.Visit_VisitTreatment"];
            
            BindControls();
            pnlAllocateTreatment.Left = 290;
            pnlAllocateTreatment.Top = 40;
            pnlModifyTreatment.Left = 290;
            pnlModifyTreatment.Top = 40;
        }

        // binds the data in the VISITTREATMENT table to textboxes and comboboxes
        public void BindControls()
        {
            
            lstVisits.DataSource = DM.DSGlendene;
            lstVisits.DisplayMember = "Visit.VisitID";
            lstVisits.ValueMember = "Visit.VisitID";

            this.txtCatName.DataBindings.Add("Text", DM.DSGlendene, "Visit.Visit_Cat_Name");
            txtCatName.Enabled = false;
            txtOwnerName.DataBindings.Add("Text", DM.DSGlendene, "Visit.Visit_Owner_LastNameFirstName");
            txtOwnerName.Enabled = false;
            txtVetName.DataBindings.Add("Text", DM.DSGlendene, "Visit.Visit_Veterinarian_LastNameFirstName");
            txtVetName.Enabled = false;

            lstTreatmentIDDescription.DataSource = DM.DSGlendene;
            lstTreatmentIDDescription.DisplayMember = "Visit.Visit_VisitTreatment.VT_Treatment_TreatmentIDDescription";            
            lstTreatmentIDDescription.ValueMember = "Visit.Visit_VisitTreatment.VT_Treatment_TreatmentID";
                        
            foreach (DataRow drTreatment in DM.dtTreatment.Rows)
            {
                this.comboxAllocateTreatmentID.Items.Add(drTreatment["TreatmentID"].ToString());
            }           

            this.txtModifyQuantity.DataBindings.Add("Text", DM.DSGlendene, "Visit.Visit_VisitTreatment.Quantity");
           
        }

        // create a button click method on the button named btnReturn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // create a button click method on the button named btnAllocate
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            
            DataRow allocateVisitRow = DM.dtVisit.Rows[cmVisit.Position];
            string visitStatus = allocateVisitRow["Status"].ToString();
            if (visitStatus.Equals("Paid") == true)
            {
                MessageBox.Show("Cannot allocate treatments to paid visits", "Error");
            }
            else
            {
                lstVisits.Visible = true;
                btnRemove.Enabled = false;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnModifyTreatment.Enabled = false;
                btnAllocate.Enabled = false;
                pnlAllocateTreatment.Show();
            }
            return;

        }

        // create a button click method on the button named btnRemove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DM.dtVisit.Rows[cmVisit.Position]["Status"].ToString() == "Pending")
            {
                string VisitID = DM.dtVisit.Rows[cmVisit.Position]["VisitID"].ToString();                
                string TreatmentID = lstTreatmentIDDescription.SelectedValue.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtVisitTreatment.Rows.Count; i++)
                {
                    string sID = DM.dtVisitTreatment.Rows[i]["VisitID"].ToString();
                    string aID = DM.dtVisitTreatment.Rows[i]["TreatmentID"].ToString();

                    if (VisitID == sID && TreatmentID == aID)
                    {
                        row = i;
                    }
                }

                DataRow dr = DM.DSGlendene.Tables["VisitTreatment"].Rows[row];
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                   MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dr.Delete();
                    DM.UpdateVisitTreatment();    //update database
                }
            }
            else
            {
                MessageBox.Show("You may only remove treatments from pending Visits.", "Error");
            }

        }

        // create a button click method on the button named btnPrevious
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cmVisit.Position > 0)
            {
                --cmVisit.Position;
            }
        }

        // create a button click method on the button named btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmVisit.Position < cmVisit.Count - 1)
            {
                ++cmVisit.Position;
            }
        }

        // create a button click method on the button named btnAllocateCancel
        private void btnAllocateCancel_Click(object sender, EventArgs e)
        {
            pnlAllocateTreatment.Hide();
            lstVisits.Enabled = true;
            lstVisits.Visible = true;
            btnRemove.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyTreatment.Enabled = true;
            btnAllocate.Enabled = true;
        }

        // create a button click method on the button named btnSaveTreatment
        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            
            try
            {
                if ((!isInteger(this.txtAllocatateQuantity.Text)) || Convert.ToInt32(txtAllocatateQuantity.Text) < 1)                 
                {
                    MessageBox.Show("You must type in a valid treatment quantity more than 1", "Error");
                }
                else
                {
                    DataRow newVisitTreatment = DM.dtVisitTreatment.NewRow();

                    
                    newVisitTreatment["TreatmentID"] = comboxAllocateTreatmentID.Text;
                    
                    newVisitTreatment["VisitID"] = cmVisit.Position + 1;
                    
                    newVisitTreatment["Quantity"] = Convert.ToInt32(txtAllocatateQuantity.Text);

                    DM.DSGlendene.Tables["VisitTreatment"].Rows.Add(newVisitTreatment);    //add a new row to dataset
                    DM.UpdateVisitTreatment();    //update database
                    DM.UpdateVisit();
                }

            }
            catch (ConstraintException)
            {
                MessageBox.Show("This treatment has already been allocated to this visit.", "Error");
            }
            catch (InvalidConstraintException)
            {
            }
            
        }

        // to validate whether user's input is a integer number or not
        private Boolean isInteger(String inputStr)
        {
            Boolean ans = false;
            try
            {
                Convert.ToInt32(inputStr);               
                ans = true;
                
            }
            catch (Exception e)
            {
            }
            return ans;
        }

        // create a button click method on the button named btnModifyCancel
        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            this.pnlModifyTreatment.Hide();
            lstVisits.Enabled = true;
            lstVisits.Enabled = true;
            btnRemove.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyTreatment.Enabled = true;
            btnAllocate.Enabled = true;
        }

        // create a button click method on the button named btnModifyTreatment
        private void btnModifyTreatment_Click(object sender, EventArgs e)
        {
            DataRow modifyVisitRow = DM.dtVisit.Rows[cmVisit.Position];
            string visitStatus = modifyVisitRow["Status"].ToString();
            if (visitStatus.Equals("Paid") == true)
            {
                MessageBox.Show("Cannot modify treatments on a paid visit", "Error");
            }
            else
            {
                lstVisits.Visible = true;
                btnRemove.Enabled = false;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnModifyTreatment.Enabled = false;
                btnAllocate.Enabled = false;
                this.pnlModifyTreatment.Show();
            }
            return;
        }

        // create a button click method on the button named btnUpdateTreatment
        private void btnUpdateTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!isInteger(this.txtModifyQuantity.Text)) || Convert.ToInt32(txtModifyQuantity.Text) < 1)                  
                {
                    MessageBox.Show("You must type in a valid treatment quantity more than 1", "Error");
                }
                else
                {
                    DataRow newVisitTreatment = DM.dtVisitTreatment.NewRow();

                    
                    newVisitTreatment["TreatmentID"] = Convert.ToInt32(lstTreatmentIDDescription.SelectedValue.ToString());
                    
                    newVisitTreatment["VisitID"] = cmVisit.Position + 1;
                    
                    newVisitTreatment["Quantity"] = Convert.ToInt32(txtModifyQuantity.Text);

                    DM.DSGlendene.Tables["VisitTreatment"].Rows.Add(newVisitTreatment);    //add a new row to dataset
                    DM.UpdateVisitTreatment();    //update database
                    DM.UpdateVisit();
                }

            }
            catch (ConstraintException)
            {                
            }
            catch (InvalidConstraintException)
            {
            }
        }
        




    }
}
