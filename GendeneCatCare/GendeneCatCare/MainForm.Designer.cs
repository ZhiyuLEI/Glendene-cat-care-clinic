namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnTreatmentVisit = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnVeterinarian = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnTreatmentVisit);
            this.grpMaintenance.Controls.Add(this.btnVisit);
            this.grpMaintenance.Controls.Add(this.btnTreatment);
            this.grpMaintenance.Controls.Add(this.btnCat);
            this.grpMaintenance.Controls.Add(this.btnVeterinarian);
            this.grpMaintenance.Controls.Add(this.btnOwner);
            this.grpMaintenance.Location = new System.Drawing.Point(35, 39);
            this.grpMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMaintenance.Size = new System.Drawing.Size(338, 554);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnTreatmentVisit
            // 
            this.btnTreatmentVisit.Location = new System.Drawing.Point(29, 422);
            this.btnTreatmentVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTreatmentVisit.Name = "btnTreatmentVisit";
            this.btnTreatmentVisit.Size = new System.Drawing.Size(248, 22);
            this.btnTreatmentVisit.TabIndex = 5;
            this.btnTreatmentVisit.Text = "Allocate Treatment to Visit";
            this.btnTreatmentVisit.UseVisualStyleBackColor = true;
            this.btnTreatmentVisit.Click += new System.EventHandler(this.btnTreatmentVisit_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.Location = new System.Drawing.Point(29, 345);
            this.btnVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(248, 22);
            this.btnVisit.TabIndex = 4;
            this.btnVisit.Text = "Visit Maintenance";
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.Location = new System.Drawing.Point(29, 256);
            this.btnTreatment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(248, 22);
            this.btnTreatment.TabIndex = 3;
            this.btnTreatment.Text = "Treatment Maintenance";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(29, 178);
            this.btnCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(248, 22);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Cat Maintenance";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnVeterinarian
            // 
            this.btnVeterinarian.Location = new System.Drawing.Point(29, 108);
            this.btnVeterinarian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVeterinarian.Name = "btnVeterinarian";
            this.btnVeterinarian.Size = new System.Drawing.Size(248, 22);
            this.btnVeterinarian.TabIndex = 1;
            this.btnVeterinarian.Text = "Veterinarian  Maintenance";
            this.btnVeterinarian.UseVisualStyleBackColor = true;
            this.btnVeterinarian.Click += new System.EventHandler(this.btnVeterinarian_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(29, 38);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(248, 22);
            this.btnOwner.TabIndex = 0;
            this.btnOwner.Text = "Owner Maintenance";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Location = new System.Drawing.Point(460, 39);
            this.grpReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReport.Size = new System.Drawing.Size(245, 542);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(55, 342);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 22);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(55, 96);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(159, 22);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 668);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnVeterinarian;
        private System.Windows.Forms.Button btnTreatmentVisit;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnExit;
    }
}

