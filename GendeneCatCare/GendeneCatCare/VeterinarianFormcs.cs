// Purpose: set up veterinarian maintenance form
// Author: Zhiyu Lei
// Date: 06/08/2014

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
    //In the VeterinarianForm code add references to the DataModule and MainForm objects, 
    //add a reference for a CurrencyManager object and change the constructor  to accept the 
    //DataModule and MainForm references
    public partial class VeterinarianForm : Form
    {
        private DataModule DM;                   //references to the DataModule object
        private MainForm frmMenu;                //references to the MainForm objects
        private CurrencyManager currencyManager; //reference to a CurrencyManager object

        //change the constructor  to accept the DataModule and MainForm references
        public VeterinarianForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVet.Left = 290;
            pnlAddVet.Top = 40;
            pnlModifyVet.Left = 290;
            pnlModifyVet.Top = 40;
        }

        //In the VeterinarianForm code write a method called BindControls that binds the data 
        //in the VETERINARIAN table to my label and text boxes
        public void BindControls()
        {
            lblVeterinarianID.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.VeterinarianID");
            txtLastName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.LastName");
            txtFirstName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.FirstName");
            txtRate.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.Rate");
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtRate.Enabled = false;
            lstVeterinarians.DataSource = DM.DSGlendene;
            lstVeterinarians.DisplayMember = "Veterinarian.LastName";
            lstVeterinarians.ValueMember = "Veterinarian.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VETERINARIAN"];

            txtModifyLastName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.LastName");
            txtModifyFirstName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.FirstName");
            this.txtModifyRate.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.Rate");
            
        }

        //In the VeterinarianForm create a button click method on the button named btnPrevious
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //In the VeterinarianForm create a button click method on the button named btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //In the VeterinarianForm create a button click method on the button named btnReturn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //In the VeterinarianForm create a button click method on the button named 
        //btnAddVeterinarian
        private void btnAddVeterinarian_Click(object sender, EventArgs e)
        {
            
            lstVeterinarians.Visible = false;
            btnDeleteVeterinarian.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnModifyVet.Enabled = false;
            btnAddVeterinarian.Enabled = false;
            pnlAddVet.Show();
            
        }

        //In the VeterinarianForm create a button click method on the button named
        //btnDeleteVeterinarian
        private void btnDeleteVeterinarian_Click(object sender, EventArgs e)
        {
            DataRow deleteVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
            DataRow[] VisitRow = DM.dtVisit.Select("VeterinarianID = " + lblVeterinarianID.Text);
            if (VisitRow.Length != 0)
            {
                MessageBox.Show("You may only delete Veterinarians who do not have visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVeterinarianRow.Delete();
                    DM.UpdateVeterinarian();
                }
            }
            return;
        }

        //In the VeterinarianForm create a button click method on the button named
        //btnUpdateVeterinarian
        private void btnUpdateVeterinarian_Click(object sender, EventArgs e)
        {
            DataRow updateVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
            if (!isLastName(this.txtModifyLastName.Text))
            {
                MessageBox.Show("You must type in a valid Last Name", "Error");
            }
            else if (!isFirstName(this.txtModifyFirstName.Text))
            {
                MessageBox.Show("You must type in a non-empty valid First Name", "Error");
            }
            else if (!isCurrency(this.txtModifyRate.Text) || Convert.ToDouble(txtModifyRate.Text) < 0.00)
            {
                MessageBox.Show("You must type in a  valid rate more than $0.00", "Error");
            }           
            else
            {
                try
                {
                    //Add the text areas
                    updateVeterinarianRow["LastName"] = txtModifyLastName.Text;
                    updateVeterinarianRow["FirstName"] = txtModifyFirstName.Text;
                    updateVeterinarianRow["Rate"] = Convert.ToDouble(txtModifyRate.Text);
                    //Update the database
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVeterinarian();
                    //Give the user a success message
                    MessageBox.Show("Veterinarian updated successfully", "Success");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid Veterinarian details", "Error");
                }
            }
            return;
        }

        // create a button click method on the button named btnAddCancel
        private void btnAddCancel_Click(object sender, EventArgs e)
        {           
            pnlAddVet.Hide();
            lstVeterinarians.Enabled = true;
            lstVeterinarians.Visible = true;
            btnDeleteVeterinarian.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyVet.Enabled = true;
            btnAddVeterinarian.Enabled = true;
        }

        // create a button click method on the button named btnAddSaveVet
        private void btnAddSaveVet_Click(object sender, EventArgs e)
        {
            this.lblVeterinarianID.Text = null;
            //Create a new row that the variables will be added into
            DataRow newVeterinarianRow = DM.dtVeterinarian.NewRow();
          
            if (!isLastName(this.txtAddLastName.Text))
            {
                MessageBox.Show("You must type in a valid Last Name", "Error");
            }
            else if (!isFirstName(this.txtAddFirstName.Text))
            {
                MessageBox.Show("You must type in a non-empty valid First Name", "Error");
            }
            else if (!isCurrency(this.txtAddRate.Text) || Convert.ToDouble(txtAddRate.Text) < 0.00)
            {
                MessageBox.Show("You must type in a  valid rate more than $0.00", "Error");
            }           
            else
            {
                newVeterinarianRow["LastName"] = txtAddLastName.Text;
                newVeterinarianRow["FirstName"] = txtAddFirstName.Text;
                newVeterinarianRow["Rate"] = Convert.ToDouble(txtAddRate.Text);
                //Add the new row to the Table
                DM.dtVeterinarian.Rows.Add(newVeterinarianRow);
                DM.UpdateVeterinarian();
                //Give the user a success message
                MessageBox.Show("Veterinarian added successfully", "Success");
            }
            return;
        }

        // to validate whether user's input is a valid last name or not
        private bool isLastName(string inputStr)
        {
            Regex r = new Regex(@"^([A-Z][a-zA-Z]{0,24})?$");
            return r.IsMatch(inputStr);
        }

        // to validate whether user's input is a valid first name or not
        private bool isFirstName(string inputStr)
        {
            Regex r = new Regex(@"^[A-Z][a-zA-Z]{0,24}$");
            return r.IsMatch(inputStr);
        }

        // to validate whether user's input is a valid currency or not
        private bool isCurrency(string inputStr)
        {
            Boolean ans = false;
            try
            {
                Convert.ToDouble(inputStr);
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
            pnlModifyVet.Hide();
            lstVeterinarians.Enabled = true;
            lstVeterinarians.Visible = true;
            btnDeleteVeterinarian.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyVet.Enabled = true;
            btnAddVeterinarian.Enabled = true;
        }

        // create a button click method on the button named btnModifyVet
        private void btnModifyVet_Click(object sender, EventArgs e)
        {            
            lstVeterinarians.Visible = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnDeleteVeterinarian.Enabled = false;
            btnAddVeterinarian.Enabled = false;
            btnModifyVet.Enabled = false;
            pnlModifyVet.Show();
        }

        


       





    }
}
