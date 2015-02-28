// Purpose: set up the visit maintenance form
// Author: Zhiyu Lei
// Date: 20/08/2014

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
    public partial class VisitForm : Form
    {
        // add references to the DataModule and MainForm objects, add a reference for a CurrencyManager object 
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;       

        // change the constructor  to accept the DataModule and MainForm references
        public VisitForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVisit.Left = 290;
            pnlAddVisit.Top = 40;
            pnlModifyVisit.Left = 290;
            pnlModifyVisit.Top = 40;
        }

        // binds the data in the Visit table to your label and text boxes
        public void BindControls()
        {
            lblVisitID.DataBindings.Add("Text", DM.DSGlendene, "Visit.VisitID");
            txtCatID.DataBindings.Add("Text", DM.DSGlendene, "Visit.CatID");
            txtCatID.Enabled = false;
            txtVeterinarianID.DataBindings.Add("Text", DM.DSGlendene, "Visit.VeterinarianID");
            txtVeterinarianID.Enabled = false;
            txtVisitDate.DataBindings.Add("Text", DM.DSGlendene, "Visit.VisitDate");
            txtVisitDate.Enabled = false;
            txtStatus.DataBindings.Add("Text", DM.DSGlendene, "Visit.Status");
            txtStatus.Enabled = false;           

            lstVisits.DataSource = DM.DSGlendene;
            lstVisits.DisplayMember = "Visit.VisitID";
            lstVisits.ValueMember = "Visit.VisitID";

            txtCatName.DataBindings.Add("Text", DM.DSGlendene, "Visit.Visit_Cat_Name");
            txtCatName.Enabled = false;
            txtOwnerName.DataBindings.Add("Text", DM.DSGlendene, "Visit.Visit_Owner_LastNameFirstName");
            txtOwnerName.Enabled = false;
            txtVetName.DataBindings.Add("Text", DM.DSGlendene, "Visit.Visit_Veterinarian_LastNameFirstName");
            txtVetName.Enabled = false;

            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VISIT"];
                        
            foreach (DataRow drCat in DM.dtCat.Rows)
            {
                comboxAddCatID.Items.Add(drCat["CatID"]);
            }
            foreach (DataRow drVet in DM.dtVeterinarian.Rows)
            {
                comboxAddVetID.Items.Add(drVet["VeterinarianID"]);
            }
           
            comboxModifyVetID.DataBindings.Add("Text", DM.DSGlendene, "Visit.VeterinarianID");
            foreach (DataRow drVet in DM.dtVeterinarian.Rows)
            {
                comboxModifyVetID.Items.Add(drVet["VeterinarianID"]);
            }
            dtpModifyVisitDate.DataBindings.Add("Text", DM.DSGlendene, "Visit.VisitDate");

        }

        // create a button click method on the button named btnPrevious
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        // create a button click method on the button named btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        // create a button click method on the button named btnReturn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // create a button click method on the button named btnAddCat
        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            
            lstVisits.Visible = false;
            btnDeleteVisit.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnModifyVisit.Enabled = false;
            btnAddVisit.Enabled = false;
            pnlAddVisit.Show();
            
        }

        // create a button click method on the button named btnDeleteCat
        private void btnDeleteVisit_Click(object sender, EventArgs e)
        {
            DataRow deleteVisitRow = DM.dtVisit.Rows[currencyManager.Position];
            string visitStatus = deleteVisitRow["Status"].ToString();
            if (visitStatus.Equals("Pending") == true)
            {
                MessageBox.Show("You may only delete paid visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVisitRow.Delete();
                    DM.UpdateVisit();
                }
            }
            return;
        }

        // create a button click method on the button named btnUpdateCat
        private void btnUpdateVisit_Click(object sender, EventArgs e)
        {
            DataRow updateVisitRow = DM.dtVisit.Rows[currencyManager.Position];
            string visitStatus = updateVisitRow["Status"].ToString();
            if (visitStatus.Equals("Paid") == true)
            {
                MessageBox.Show("You may only update pending visits", "Error");
            }
            else
            {
                try
                {
                    updateVisitRow["VeterinarianID"] = this.comboxModifyVetID.Text;
                    updateVisitRow["VisitDate"] = this.dtpModifyVisitDate.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVisit();
                    //Give the user a success message
                    MessageBox.Show("Visit updated successfully", "Success");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid visit details", "Error");
                }
            }
            return;
        }

        // create a button click method on the button named btnAddCancel
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            
            pnlAddVisit.Hide();
            lstVisits.Enabled = true;
            lstVisits.Visible = true;
            btnDeleteVisit.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyVisit.Enabled = true;
            btnAddVisit.Enabled = true;

        }

        // create a button click method on the button named btnSaveOwner
        private void btnSaveVisit_Click(object sender, EventArgs e)
        {
            this.lblVisitID.Text = null;
            //Create a new row that the variables will be added into
            DataRow newVisitRow = DM.dtVisit.NewRow();

            try
            {
                newVisitRow["CatID"] = this.comboxAddCatID.Text;
                newVisitRow["VeterinarianID"] = this.comboxAddVetID.Text;
                newVisitRow["VisitDate"] = this.dtpAddVisitDate.Text;
                newVisitRow["Status"] = "Pending";
                //Add the new row to the Table
                DM.dtVisit.Rows.Add(newVisitRow);
                DM.UpdateVisit();
                //Give the user a success message
                MessageBox.Show("Visit added successfully", "Success");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid visit details", "Error");
            }
            return;

        }

        // create a button click method on the button named btnModifyCancel
        private void btnModifyCancel_Click(object sender, EventArgs e)
        {            
            pnlModifyVisit.Hide();
            lstVisits.Enabled = true;
            lstVisits.Visible = true;
            btnDeleteVisit.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyVisit.Enabled = true;
            btnAddVisit.Enabled = true;

        }

        // create a button click method on the button named btnModifyVisit
        private void btnModifyVisit_Click(object sender, EventArgs e)
        {
            
            lstVisits.Visible = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnDeleteVisit.Enabled = false;
            btnAddVisit.Enabled = false;
            btnModifyVisit.Enabled = false;

            DataRow updateVisitRow = DM.dtVisit.Rows[currencyManager.Position];
            string visitStatus = updateVisitRow["Status"].ToString();
            if(visitStatus.Equals("Paid") == true)
            {
                MessageBox.Show("Cannot update a paid visit", "Error");
                btnDeleteVisit.Enabled = true;
                btnAddVisit.Enabled = true;
                btnModifyVisit.Enabled = true;
            }
            else
            {
                pnlModifyVisit.Show();
            }
            return;
        }

        // create a button click method on the button named btnModifyVisitAsPaid
        private void btnMarkVisitAsPaid_Click(object sender, EventArgs e)
        {
            DataRow markAsPaidRow = DM.dtVisit.Rows[currencyManager.Position];
            string visitStatus = markAsPaidRow["Status"].ToString();
            if (visitStatus.Equals("Paid") == true)
            {
                MessageBox.Show("The visit is already marked as paid", "Error");
            }
            else
            {
                markAsPaidRow["Status"] = "Paid";
                currencyManager.EndCurrentEdit();
                DM.UpdateVisit();
                //Give the user a success message
                MessageBox.Show("Visit marked as paid successfully", "Success");
            }
            return;
        }


        




    }
}
