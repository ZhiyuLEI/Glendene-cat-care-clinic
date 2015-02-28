// Purpose: set up owner maintenance form
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
    //In the OwnerForm code add references to the DataModule and MainForm objects, 
    //add a reference for a CurrencyManager object and change the constructor to accept 
    //the DataModule and MainForm references
    public partial class OwnerForm : Form
    {
        private DataModule DM;      //references to the DataModule 
        private MainForm frmMenu;   //references to the MainForm object
        private CurrencyManager currencyManager;  //reference to a CurrencyManager object

        //Change the constructor to accept 
        //the DataModule and MainForm references
        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlAddOwner.Left = 220;
            this.pnlAddOwner.Top = 40;

            pnlModifyOwner.Left = 220;
            pnlModifyOwner.Top = 40;
        }

        //In the OwnerForm code write a method called BindControls that binds the data 
        //in the OWNER table to your label and text boxes
        public void BindControls()
        {
            lblOwnerID.DataBindings.Add("Text", DM.DSGlendene, "Owner.OwnerID");
            txtLastName.DataBindings.Add("Text", DM.DSGlendene, "Owner.LastName");
            txtFirstName.DataBindings.Add("Text", DM.DSGlendene, "Owner.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.DSGlendene, "Owner.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.DSGlendene, "Owner.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.DSGlendene, "Owner.PhoneNumber");
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;
            lstOwners.DataSource = DM.DSGlendene;
            lstOwners.DisplayMember = "Owner.LastName";
            lstOwners.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "OWNER"];

            txtModifyLastName.DataBindings.Add("Text",DM.DSGlendene,"Owner.LastName");
            txtModifyFirstName.DataBindings.Add("Text", DM.DSGlendene, "Owner.FirstName");
            txtModifyStAddress.DataBindings.Add("Text", DM.DSGlendene, "Owner.StreetAddress");
            txtModifySuburb.DataBindings.Add("Text", DM.DSGlendene, "Owner.Suburb");
            txtModifyPhoneNum.DataBindings.Add("Text", DM.DSGlendene, "Owner.PhoneNumber");
        }

        //In the OwnerForm create a button click method on the button named btnPrevious
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //In the OwnerForm create a button click method on the button named btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }

        }

        //In the OwnerForm create a button click method on the button named btnReturn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // create a button click method on the button named btnAddOwner
        private void btnAddOwner_Click(object sender, EventArgs e)
        {            
            lstOwners.Visible = false;
            btnDeleteOwner.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnModifyOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            pnlAddOwner.Show();
        }

        //In the OwnerForm create a button click method on the button named btnDeleteOwner
        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] CatRow = DM.dtCat.Select("OwnerID = " + lblOwnerID.Text);
            if (CatRow.Length != 0)
            {
                MessageBox.Show("You may only delete owners who do not have cats", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    DM.UpdateOwner();
                }
            }
            return;
        }

        //In the OwnerForm create a button click method on the button named btnUpdateOwner
        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            DataRow newOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            if (!isName(this.txtModifyLastName.Text))
            {
                MessageBox.Show("You must type in a valid Last Name", "Error");
            }
            else if (!isName(this.txtModifyFirstName.Text))
            {
                MessageBox.Show("You must type in a valid First Name", "Error");
            }
            else if (!isStreetAddress(this.txtModifyStAddress.Text))
            {
                MessageBox.Show("You must type in a valid Street Address in the format 102 Hepburn Street", "Error");
            }
            else if (!isSuburb(this.txtModifySuburb.Text))
            {
                MessageBox.Show("You must type in a valid Suburb in the format Avondale or Mt Albert", "Error");
            }
            else if (!isPhone(this.txtModifyPhoneNum.Text))
            {
                MessageBox.Show("You must type in a valid phone number in the format (00) 000 0000", "Error");
            }
            else
            {
                try
                {
                    newOwnerRow["LastName"] = this.txtModifyLastName.Text;
                    newOwnerRow["FirstName"] = this.txtModifyFirstName.Text;
                    newOwnerRow["StreetAddress"] = this.txtModifyStAddress.Text;
                    newOwnerRow["Suburb"] = this.txtModifySuburb.Text;
                    newOwnerRow["PhoneNumber"] = this.txtModifyPhoneNum.Text;
                    currencyManager.EndCurrentEdit();
                    MessageBox.Show("Owner details updated successfully", "Success");
                    DM.UpdateOwner();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid owner details", "Error");
                }
            }
            return;
        }

        // create a button click method on the button named btnAddCancel
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddOwner.Hide();
            lstOwners.Enabled = true;
            lstOwners.Visible = true;
            btnDeleteOwner.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyOwner.Enabled= true;
            btnAddOwner.Enabled = true;
        }

        // create a button click method on the button named btnSaveOwner
        private void btnSaveOwner_Click(object sender, EventArgs e)
        {
            this.lblOwnerID.Text = null;
            DataRow newOwnerRow = DM.dtOwner.NewRow();

            if (!isName(this.txtAddLastName.Text))
            {
                MessageBox.Show("You must type in a valid Last Name", "Error");
            }
            else if (!isName(this.txtAddFirstName.Text))
            {
                MessageBox.Show("You must type in a valid First Name", "Error");
            }
            else if (!isStreetAddress(this.txtAddStreetAddress.Text))
            {
                MessageBox.Show("You must type in a valid Street Address in the format 102 Hepburn Street", "Error");
            }
            else if (!isSuburb(this.txtAddSuburb.Text))
            {
                MessageBox.Show("You must type in a valid Suburb in the format Avondale or Mt Albert", "Error");
            }            
            else if (!isPhone(this.txtAddPhoneNum.Text))
            {
                MessageBox.Show("You must type in a valid phone number in the format (00) 000 0000", "Error");
            }
            else
            {
                try
                {
                    newOwnerRow["LastName"] = this.txtAddLastName.Text;
                    newOwnerRow["FirstName"] = this.txtAddFirstName.Text;
                    newOwnerRow["StreetAddress"] = this.txtAddStreetAddress.Text;
                    newOwnerRow["Suburb"] = this.txtAddSuburb.Text;
                    newOwnerRow["PhoneNumber"] = this.txtAddPhoneNum.Text;
                    DM.dtOwner.Rows.Add(newOwnerRow);
                    MessageBox.Show("Owner details added successfully", "Success");
                    DM.UpdateOwner();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid owner details", "Error");
                }
            }
            return;
        }
        
        // to validate whether user's input is a valid phone number or not
        private bool isPhone(string strPhone)
        {
            Regex objPhonePattern = new Regex(@"^(\(\d{2}\)\s\d{3}\s\d{4})?$");
            return objPhonePattern.IsMatch(strPhone);
        }

        // to validate whether user's input is a valid name or not
        private bool isName(string inputStr)
        {
            Regex r = new Regex(@"^([A-Z][a-zA-Z]{0,24})?$");
            return r.IsMatch(inputStr);
        }

        // to validate whether user's input is a valid street address or not
        private bool isStreetAddress(string inputStr)
        {
            Regex r = new Regex(@"^(\d{1,4}\s[A-Z][a-z]{0,10}\s[A-Z][a-z]{0,13})?$");
            return r.IsMatch(inputStr);
        }

        // to validate whether user's input is a valid suburb or not
        private bool isSuburb(string inputStr)
        {
            Regex r = new Regex(@"^([A-Z][A-Za-z\s]{0,11})?$");
            return r.IsMatch(inputStr);
        }

        // create a button click method on the button named btnModifyCancel
        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            pnlModifyOwner.Hide();
            lstOwners.Enabled = true;
            lstOwners.Visible = true;
            btnDeleteOwner.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyOwner.Enabled = true;
            btnAddOwner.Enabled = true;
        }

        // create a button click method on the button named btnModifyOwner
        private void btnModifyOwner_Click(object sender, EventArgs e)
        {
            this.lstOwners.Visible = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnDeleteOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            btnModifyOwner.Enabled = false;
            pnlModifyOwner.Show();
        }


    }
}
