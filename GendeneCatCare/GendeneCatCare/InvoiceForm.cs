// Purpose: set up invoice form
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
    public partial class InvoiceForm : Form
    {
        // add references to the DataModule and MainForm objects
        private DataModule DM;
        private MainForm frmMenu;

        private int amountOfVisitsPrinted, pagesAmountExpected;
        private DataRow[] visitsForPrint;

        // change the constructor to accept the DataModule and MainForm references
        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        // create a button click method on the button named btnReturn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // create a button click method on the button named btnPrintReport
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            amountOfVisitsPrinted = 0;
            string strFilter = "Status = 'Pending'";
            string strSort = "VisitID";

            visitsForPrint = DM.DSGlendene.Tables["VISIT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = visitsForPrint.Length;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // print the required fields from the database
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drVisit = visitsForPrint[amountOfVisitsPrinted];

            CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            
            double visitTotal = 0;

            cmCat = (CurrencyManager)this.BindingContext[DM.DSGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGlendene, "OWNER"];
            cmTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
            cmVeterinarian = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VETERINARIAN"];

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;           

            // get the cat record matching the cat ID from the visit record
            int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
            cmCat.Position = DM.catView.Find(aCatID);
            DataRow drCat = DM.dtCat.Rows[cmCat.Position];

            // get the owner record matching the owner ID from cat record
            int anOwnerID = Convert.ToInt32(drCat["OwnerID"].ToString());
            cmOwner.Position = DM.ownerView.Find(anOwnerID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

            // get the veterinarian record matching the veterinarian ID from the visit record
            int aVeterinarianID = Convert.ToInt32(drVisit["VeterinarianID"].ToString());
            cmVeterinarian.Position = DM.veterinarianView.Find(aVeterinarianID);
            DataRow drVeterinarian = DM.dtVeterinarian.Rows[cmVeterinarian.Position];

            visitTotal += Convert.ToDouble(drVeterinarian["Rate"]);

            // drTreatments-->DataRow Array in TABLE dtVisitTreatment with Visit Record, Not in TABLE dtTreatment
            DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["VISIT_VISITTREATMENT"]);

            if (drTreatments.Length > 0)
            {
                
                g.DrawString("Owner ID:" + drOwner["OwnerID"], headingFont, brush, leftMargin + headingLeftMargin,
                        topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Owener: " + drOwner["LastName"] + ", " + drOwner["FirstName"], headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                        (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Street: " + Convert.ToString(drOwner["StreetAddress"]), headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                        (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Suburb: " + Convert.ToString(drOwner["Suburb"]), headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                        (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Cat Name: " + drCat["Name"], headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                        (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Visit ID: " + drVisit["VisitID"] + "       " + "Visit Date: " + drVisit["VisitDate"], headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                        (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                g.DrawString("Veterinarian: " + drVeterinarian["LastName"] + ", " + drVeterinarian["FirstName"] + "        " + "Rate: " + drVeterinarian["Rate"], headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                  (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;

                foreach (DataRow drVisitTreatment in drTreatments)
                {
                    
                    int aTreatmnetID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                    cmTreatment.Position = DM.treatmentView.Find(aTreatmnetID);
                    DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];       // drTreatment-->DataRow in TABLE dtTreatment

                    double treatmentCost;

                    treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) * Convert.ToDouble(drTreatment["Cost"]);
                    visitTotal += treatmentCost;
                    g.DrawString("Treatment Description:" + drTreatment["Description"] + " " +
                                              "Quantity:" + drVisitTreatment["Quantity"] + " " +
                                              "Treatment Cost: NZ $" + string.Format("{0:#,##0.00}", treatmentCost), headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                            (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                    linesSoFarHeading++;

                }

               
                linesSoFarHeading++;
               
                g.DrawString("Gross Due: NZ $" + string.Format("{0:#,##0.00}", visitTotal), headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                            (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
            }
            
            visitTotal = 0;
            amountOfVisitsPrinted++; // for each VisitID with pending status  in dtVisit      
            
            if (amountOfVisitsPrinted < pagesAmountExpected-1)
            {
                e.HasMorePages = true;
                return;
            }
            else
            {
                e.HasMorePages = false;
                amountOfVisitsPrinted = 0;
                return;
            }

        }

        // preview printed report in the print  preview control
        private void btnPreview_Click(object sender, EventArgs e)
        {
            amountOfVisitsPrinted = 0;
            string strFilter = "Status = 'Pending'";
            string strSort = "VisitID";

            visitsForPrint = DM.DSGlendene.Tables["VISIT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = visitsForPrint.Length;
            printPreviewControl1.Document = printDocument1;
            printPreviewControl1.Zoom = 1.2;
            printPreviewControl1.Show();
        }

        // preview printed report to the previous page
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.StartPage > 0)
                printPreviewControl1.StartPage--;
        }

        // preview printed report to the next page
        private void btnNext_Click(object sender, EventArgs e)
        {
            printPreviewControl1.StartPage++;
        }



    }
}
