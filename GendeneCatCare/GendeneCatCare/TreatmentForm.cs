// Purpose: set up the treatment maintenance form
// Author: Zhiyu Lei
// Date: 08/08/2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class TreatmentForm : Form
    {
        // add references to the DataModule and MainForm objects, add a reference for a CurrencyManager object
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        // change the constructor  to accept the DataModule and MainForm references
        public TreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlAddTreatment.Left = 220;
            pnlAddTreatment.Top = 40;

            pnlModifyTreatment.Left = 270;
            pnlModifyTreatment.Top = 40;
        }

        // load the treatment form
        private void TreatmentForm_Load(object sender, EventArgs e)
        {
        }

        // binds the data in the Treatment table to label and text boxes
        public void BindControls()
        {
            lblTreatmentID.DataBindings.Add("Text", DM.DSGlendene, "Treatment.TreatmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Description");
            txtCost.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Cost");

            txtDescription.Enabled = false;
            txtCost.Enabled = false;

            txtModifyDescription.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Description");
            txtModifyCost.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Cost");

            lstTreatments.DataSource = DM.DSGlendene;
            lstTreatments.DisplayMember = "Treatment.Description";
            lstTreatments.ValueMember = "Treatment.Description";
            
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
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

        // create a button click method on the button named btnAddTreatment
        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            lstTreatments.Visible = false;      
            btnDeleteTreatment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            this.btnModifyTreatment.Enabled = false;
            btnAddTreatment.Enabled = false;
            pnlAddTreatment.Show();
            
        }

        // create a button click method on the button named btnDeleteTreatment
        private void btnDeleteTreatment_Click(object sender, EventArgs e)
        {
            DataRow deleteTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];
            DataRow[] VisitTreatmentRow = DM.dtVisitTreatment.Select("TreatmentID = " + lblTreatmentID.Text);
            if (VisitTreatmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteTreatmentRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Treatments that are not allocated to visits", "Error");
                return;
            }
            //Update
            DM.UpdateTreatment();
        }

        // create a button click method on the button named btnUpdateTreatment
        private void btnUpdateTreatment_Click(object sender, EventArgs e)
        {
            DataRow updateTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];

            if (!isDescription(txtModifyDescription.Text))
            {
                MessageBox.Show("You must type in a non-empty valid treatment description", "Error");
            }
            else if ((!isDouble(txtModifyCost.Text)) || Convert.ToDouble(txtModifyCost.Text) < 0.00)
            {
                MessageBox.Show("You must type in a  valid treatment cost more than $0.00", "Error");
            }
            else
            {
                updateTreatmentRow["Description"] = txtModifyDescription.Text;
                updateTreatmentRow["Cost"] = Convert.ToDouble(txtModifyCost.Text);
                currencyManager.EndCurrentEdit();
                DM.UpdateTreatment();
                MessageBox.Show("Treatment updated successfully", "Success");
            }
            return;
        }
            

        // create a button click method on the button named btnCancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddTreatment.Hide();
            lstTreatments.Enabled = true;
            lstTreatments.Visible = true;
            btnDeleteTreatment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            this.btnModifyTreatment.Enabled = true;
            btnAddTreatment.Enabled = true;
        }

        // create a button click method on the button named btnSave
        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            lblTreatmentID.Text = null;
            DataRow newTreatmentRow = DM.dtTreatment.NewRow();

            if (!isDescription(txtAddDescription.Text))
            {
                MessageBox.Show("You must type in a non-empty valid treatment description", "Error");
            }
            else if ((!isDouble(txtAddCost.Text) ) || Convert.ToDouble(txtAddCost.Text) < 0.00)
            {
                MessageBox.Show("You must type in a  valid treatment cost more than $0.00", "Error");
            }
            else
            {
                try
                {
                    newTreatmentRow["Description"] = txtAddDescription.Text;
                    newTreatmentRow["Cost"] = Convert.ToDouble(txtAddCost.Text);
                    DM.dtTreatment.Rows.Add(newTreatmentRow);
                    MessageBox.Show("Treatment added successfully", "Success");
                    DM.UpdateTreatment();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid treatment details", "Error");
                }
            }
            return;

        }

        // to validate whether user's input is a double number or not
        private Boolean isDouble(String inputStr)
        {
            Boolean ans = false;
            try
            {
                Convert.ToDouble(inputStr);
                ans = true;
            }
            catch(Exception e)
            {
            }
            return ans;
        }

        // to validate whether user's input is a valid description or not
        private Boolean isDescription(String inputStr)
        {
            Regex r = new Regex(@"^[A-Z][A-Za-z\s]{0,39}$");
            return r.IsMatch(inputStr);
        }

        // create a button click method on the button named btnModifyTreatment
        private void btnModifyTreatment_Click(object sender, EventArgs e)
        {
            lstTreatments.Visible = true;
            btnDeleteTreatment.Enabled = false;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            this.btnAddTreatment.Enabled = false;
            this.btnModifyTreatment.Enabled = false;
            this.pnlModifyTreatment.Show();
        }

        // create a button click method on the button named btnModifyCancel
        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            this.pnlModifyTreatment.Hide();
            lstTreatments.Enabled = true;
            lstTreatments.Visible = true;
            btnDeleteTreatment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            this.btnModifyTreatment.Enabled = true;
            btnAddTreatment.Enabled = true;
        }
       




    }

}