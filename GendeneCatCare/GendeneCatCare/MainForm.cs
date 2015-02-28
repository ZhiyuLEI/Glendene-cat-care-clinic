// Purpose: set up the main form
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

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private DataModule DM;                   		// the reference to the form that holds the data components
        private CatForm frmCat;            		// the reference to the cat form
        private OwnerForm frmOwner;	 		// the reference to the owner form
        private TreatmentForm frmTreatment;      		// the reference to the treatment form
        private VeterinarianForm frmVet;         		// the reference to the veterinarian form
        private VisitForm frmVisit;       		// the reference to the visit form
        private VisitTreatmentForm frmVisitTreatment;  	// the reference to the visit treatment form
        private InvoiceForm frmInvoice;		  	// the reference to the invoice form

        // Initialize the default constructor
        public MainForm()
        {
            InitializeComponent();
        }

        // create a Load event method and write the code to create a DataModule object
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        // create a button click method on the button named btnTreatment that creates a TreatmentForm object (if none exists) 
        // passing it references to the DataModule and the MainForm 
        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if (frmTreatment == null)
            {
                frmTreatment = new TreatmentForm(DM, this);
            }
            frmTreatment.ShowDialog();
        }

        //  create a button click method on the button named btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //In the MainForm, create a button click method on the button named btnOwner that 
        //creates an OwnerForm object (if none exists) passing it references to the DataModule and the MainForm
        private void btnOwner_Click(object sender, EventArgs e)
        {
            if (frmOwner == null)
            {
                frmOwner = new OwnerForm(DM, this);
            }
            frmOwner.ShowDialog();
        }

        
        //In the MainForm, create a button click method on the button named btnVeterinarian
        //that creates an VeterinarianForm object (if none exists) passing it references to 
        //the DataModule and the MainForm
        private void btnVeterinarian_Click(object sender, EventArgs e)
        {
            if (frmVet == null)
            {
                frmVet = new VeterinarianForm(DM, this);
            }
            frmVet.ShowDialog();

        }

        //In the MainForm, create a button click method on the button named btnInvoices that creates an InvoiceForm object 
        // (if none exists) passing it references to the DataModule and the MainForm
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();

        }

        // create a button click method on the button named btnVisitTreatment that creates an VisitTreatmentForm
        // object (if none exists) passing it references to the DataModule and the MainForm
        private void btnTreatmentVisit_Click(object sender, EventArgs e)
        {
            if (frmVisitTreatment == null)
            {
                frmVisitTreatment = new VisitTreatmentForm(DM, this);
            }
            frmVisitTreatment.ShowDialog();
        }

        // create a button click method on the button named btnCat that creates an CatForm object (if none exists) 
        // passing it references to the DataModule and the MainForm
        private void btnCat_Click(object sender, EventArgs e)
        {
            if (frmCat == null)
            {
                frmCat = new CatForm(DM, this);
            }
            frmCat.ShowDialog();
        }

        // create a button click method on the button named btnVisit that creates an VisitForm object (if none exists) 
        // passing it references to the DataModule and the MainForm
        private void btnVisit_Click(object sender, EventArgs e)
        {
            if (frmVisit == null)
            {
                frmVisit = new VisitForm(DM, this);
            }
            frmVisit.ShowDialog();
        }



        
    }
}
