// Purpose: set up the data module
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
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class DataModule : Form
    {
        public DataTable dtCat;
        public DataTable dtOwner;
        public DataTable dtVeterinarian;
        public DataTable dtTreatment;
        public DataTable dtVisit;
        public DataTable dtVisitTreatment;
        public DataView catView;
        public DataView treatmentView;
        public DataView ownerView;
        public DataView veterinarianView;
        public DataView visitView;
        public DataView visitTreatmentView;

        // initialize the default constructor
        public DataModule()
        {
            InitializeComponent();
            DSGlendene.EnforceConstraints = false;
            daCat.Fill(DSGlendene);
            daTreatment.Fill(DSGlendene);
            daOwner.Fill(DSGlendene);
            daVisit.Fill(DSGlendene);
            daVeterinarian.Fill(DSGlendene);
            daVisitTreatment.Fill(DSGlendene);
            dtCat = DSGlendene.Tables["Cat"];
            dtTreatment = DSGlendene.Tables["Treatment"];
            dtOwner = DSGlendene.Tables["Owner"];
            dtVeterinarian = DSGlendene.Tables["Veterinarian"];
            dtVisit = DSGlendene.Tables["Visit"];
            dtVisitTreatment = DSGlendene.Tables["VisitTreatment"];
            
            //In the DataModule code add the following code to the constructor
            //place it just above the DSGlendene.EnforceConstraints = true; code
            catView = new DataView(dtCat);
            catView.Sort = "CatID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            treatmentView = new DataView(dtTreatment);
            treatmentView.Sort = "TreatmentID";
            veterinarianView = new DataView(dtVeterinarian);
            veterinarianView.Sort = "VeterinarianID";

            DSGlendene.EnforceConstraints = true;
        }

        //In the DataModule form, add an updating method to dtTreatment
        public void UpdateTreatment()
        {
            daTreatment.Update(dtTreatment);
        }

        // add an updating method to dtOwner
        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        }

        // add an updating method to dtVeterinarian
        public void UpdateVeterinarian()
        {
            daVeterinarian.Update(dtVeterinarian);
        }

        // add an updating method to dtVisitTreatment
        public void UpdateVisitTreatment()
        {
            daVisitTreatment.Update(dtVisitTreatment);
        }

        // add an updating method to dtCat
        public void UpdateCat()
        {
            daCat.Update(dtCat);
        }

        // add an updating method to dtVisit
        public void UpdateVisit()
        {
            daVisit.Update(dtVisit);
        }
        
        // Load the DataModule
        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        // to access the new value of the cat’s key field
        private void daCat_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the CatID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CatID"] = newID;
            }

        }

        // to access the new value of the veterinarian’s key field
        private void daVeterinarian_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the VeterinarianID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VeterinarianID"] = newID;
            }
        }

        // to access the new value of the treatment’s key field
        private void daTreatment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["TreatmentID"] = newID;
            }

        }

        // to access the new value of the owner’s key field
        private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the OwnerID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["OwnerID"] = newID;
            }
        }

        // to access the new value of the visit’s key field
        private void daVisit_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the VisitID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VisitID"] = newID;
            }
        }

        // to access the new value of the VisitTreatment’s key field
        private void daVisitTreatment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the VisitID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VisitID"] = newID;
                
            }
        }


    }
}
