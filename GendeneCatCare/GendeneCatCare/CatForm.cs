// Purpose: set up the cat maintenance form
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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class CatForm : Form
    {
        // add references to the DataModule and MainForm objects, add a reference for a 
        // CurrencyManager object and change the constructor  to accept the DataModule and MainForm references 
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        // Form Declaration
        public CatForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddCat.Left = 350;
            pnlAddCat.Top = 40;
            pnlModifyCat.Left = 350;
            pnlModifyCat.Top = 40;
        }

        //  binds the data in the CAT table to your label and text boxes
        public void BindControls()
        {
            lblCatID.DataBindings.Add("Text", DM.DSGlendene, "Cat.CatID");
            txtName.DataBindings.Add("Text", DM.DSGlendene, "Cat.Name");
            txtBreed.DataBindings.Add("Text", DM.DSGlendene, "Cat.Breed");
            txtGender.DataBindings.Add("Text", DM.DSGlendene, "Cat.Gender");
            txtDateOfBirth.DataBindings.Add("Text", DM.DSGlendene, "Cat.DateOfBirth");
            txtNeutered.DataBindings.Add("Text", DM.DSGlendene, "Cat.Neutered");
            txtOwnerID.DataBindings.Add("Text", DM.DSGlendene, "Cat.OwnerID");
            txtOwnerName.DataBindings.Add("Text", DM.DSGlendene, "Cat.Cat_Owner_LastNameFirstName");
            txtName.Enabled = false;
            txtBreed.Enabled = false;
            txtGender.Enabled = false;
            txtDateOfBirth.Enabled = false;
            txtNeutered.Enabled = false;
            txtOwnerID.Enabled = false;
            txtOwnerName.Enabled = false;

            lstCats.DataSource = DM.DSGlendene;
            lstCats.DisplayMember = "Cat.Name";
            lstCats.ValueMember = "Cat.Name";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "CAT"];

            comboxAddGender.Items.Add("Male");
            comboxAddGender.Items.Add("Female");          
            foreach (DataRow drOwner in DM.dtOwner.Rows)
            {
                comboxAddOwnerID.Items.Add(drOwner["OwnerID"]);
            }

            txtModifyCatName.DataBindings.Add("Text", DM.DSGlendene, "Cat.Name");
            txtModifyBreed.DataBindings.Add("Text", DM.DSGlendene, "Cat.Breed");
            comboxModifyGender.DataBindings.Add("Text", DM.DSGlendene, "Cat.Gender");
            comboxModifyGender.Items.Add("Male");
            comboxModifyGender.Items.Add("Female");
            dateTimePicker2.DataBindings.Add("Text", DM.DSGlendene, "Cat.DateOfBirth");
            checkBox2.DataBindings.Add("Checked", DM.DSGlendene, "Cat.Neutered");
            
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
        private void btnAddCat_Click(object sender, EventArgs e)
        {            
            lstCats.Visible = false;
            btnDeleteCat.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnModifyCat.Enabled = false;
            btnAddCat.Enabled = false;
            pnlAddCat.Show();
        }

        // create a button click method on the button named btnDelete
        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            DataRow deleteCatRow = DM.dtCat.Rows[currencyManager.Position];
            DataRow[] CatRow = DM.dtVisit.Select("CatID = " + lblCatID.Text);
            if (CatRow.Length != 0)
            {
                MessageBox.Show("You may only delete cats who are not assigned visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteCatRow.Delete();
                    DM.UpdateCat();
                }
            }
            return;

        }

        // create a button click method on the button named btnUpdate
        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            DataRow updateCatRow = DM.dtCat.Rows[currencyManager.Position];

            if (!isCatName(this.txtModifyCatName.Text))
            {
                MessageBox.Show("You must type in a non-empty valid Cat Name", "Error");
            }
            else if (!isBreed(this.txtModifyBreed.Text))
            {
                MessageBox.Show("You must type in a valid Breed", "Error");
            }
            else
            {
                try
                {
                    updateCatRow["Name"] = txtModifyCatName.Text;
                    updateCatRow["Breed"] = txtModifyBreed.Text;
                    updateCatRow["Gender"] = comboxModifyGender.Text;
                    updateCatRow["DateOfBirth"] = this.dateTimePicker2.Text;
                    updateCatRow["Neutered"] = this.checkBox2.Checked;
                    
                    currencyManager.EndCurrentEdit();
                    DM.UpdateCat();
                    //Give the user a success message
                    MessageBox.Show("Cat updated successfully", "Success");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid cat details", "Error");
                }
            }
            return;

        }
        
        // create a button click method on the button named btnAddCancel
        private void btnAddCancel_Click(object sender, EventArgs e)
        {            
            pnlAddCat.Hide();
            lstCats.Enabled = true;
            lstCats.Visible = true;
            btnDeleteCat.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyCat.Enabled = true;
            btnAddCat.Enabled = true;
        }

        // create a button click method on the button named btnSaveOwner
        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            this.lblCatID.Text = null;
            //Create a new row that the variables will be added into
            DataRow newCatRow = DM.dtCat.NewRow();

            if (!isCatName(this.txtAddCatName.Text))
            {
                MessageBox.Show("You must type in a non-empty valid Cat Name", "Error");
            }
            else if (!isBreed(this.txtAddBreed.Text))
            {
                MessageBox.Show("You must type in a valid Breed", "Error");
            }
            else
            {
                try
                {
                    newCatRow["Name"] = txtAddCatName.Text;
                    newCatRow["Breed"] = txtAddBreed.Text;
                    newCatRow["Gender"] = comboxAddGender.Text;
                    newCatRow["DateOfBirth"] = this.dateTimePicker1.Text;
                    newCatRow["Neutered"] = this.checkBox1.Checked;
                    newCatRow["OwnerID"] = this.comboxAddOwnerID.Text;
                    //Add the new row to the Table
                    DM.dtCat.Rows.Add(newCatRow);
                    DM.UpdateCat();
                    //Give the user a success message
                    MessageBox.Show("Cat added successfully", "Success");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid cat details", "Error");
                }
            }
            return;
        }

        // to validate whether user's input is a valid cat name or not
        private bool isCatName(string inputStr)
        {
            Regex r = new Regex(@"^[A-Z][A-Za-z\s]{0,19}$");
            return r.IsMatch(inputStr);
        }

        // to validate whether user's input is a valid breed or not
        private bool isBreed(string inputStr)
        {
            Regex r = new Regex(@"^([A-Z][A-Za-z\s]{0,19})?$");
            return r.IsMatch(inputStr);
        }

        // create a button click method on the button named btnModifyCat
        private void btnModifyCat_Click(object sender, EventArgs e)
        {            
            lstCats.Visible = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnDeleteCat.Enabled = false;
            btnAddCat.Enabled = false;
            btnModifyCat.Enabled = false;
            pnlModifyCat.Show();
        }

        // create a button click method on the button named btnModifyCancel
        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            
            pnlModifyCat.Hide();
            lstCats.Enabled = true;
            lstCats.Visible = true;
            btnDeleteCat.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyCat.Enabled = true;
            btnAddCat.Enabled = true;
        }

        







    }
}
