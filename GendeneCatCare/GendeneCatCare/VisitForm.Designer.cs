namespace WindowsFormsApplication1
{
    partial class VisitForm
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
            this.lstVisits = new System.Windows.Forms.ListBox();
            this.lblVisitNo = new System.Windows.Forms.Label();
            this.lblVisitID = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblVeterinarianID = new System.Windows.Forms.Label();
            this.lblVisitDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtVeterinarianID = new System.Windows.Forms.TextBox();
            this.txtVisitDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVisit = new System.Windows.Forms.Button();
            this.btnUpdateVisit = new System.Windows.Forms.Button();
            this.btnDeleteVisit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblOwerName = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblVetName = new System.Windows.Forms.Label();
            this.txtVetName = new System.Windows.Forms.TextBox();
            this.btnModifyVisit = new System.Windows.Forms.Button();
            this.pnlAddVisit = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveVisit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboxAddCatID = new System.Windows.Forms.ComboBox();
            this.comboxAddVetID = new System.Windows.Forms.ComboBox();
            this.dtpAddVisitDate = new System.Windows.Forms.DateTimePicker();
            this.pnlModifyVisit = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboxModifyVetID = new System.Windows.Forms.ComboBox();
            this.dtpModifyVisitDate = new System.Windows.Forms.DateTimePicker();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.btnMarkVisitAsPaid = new System.Windows.Forms.Button();
            this.pnlAddVisit.SuspendLayout();
            this.pnlModifyVisit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVisits
            // 
            this.lstVisits.FormattingEnabled = true;
            this.lstVisits.ItemHeight = 15;
            this.lstVisits.Location = new System.Drawing.Point(52, 58);
            this.lstVisits.Name = "lstVisits";
            this.lstVisits.Size = new System.Drawing.Size(233, 424);
            this.lstVisits.TabIndex = 0;
            // 
            // lblVisitNo
            // 
            this.lblVisitNo.AutoSize = true;
            this.lblVisitNo.Location = new System.Drawing.Point(343, 58);
            this.lblVisitNo.Name = "lblVisitNo";
            this.lblVisitNo.Size = new System.Drawing.Size(79, 15);
            this.lblVisitNo.TabIndex = 1;
            this.lblVisitNo.Text = "Visit ID:";
            // 
            // lblVisitID
            // 
            this.lblVisitID.AutoSize = true;
            this.lblVisitID.Location = new System.Drawing.Point(447, 58);
            this.lblVisitID.Name = "lblVisitID";
            this.lblVisitID.Size = new System.Drawing.Size(39, 15);
            this.lblVisitID.TabIndex = 2;
            this.lblVisitID.Text = "null";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(340, 118);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(63, 15);
            this.lblCatID.TabIndex = 3;
            this.lblCatID.Text = "Cat ID:";
            // 
            // lblVeterinarianID
            // 
            this.lblVeterinarianID.AutoSize = true;
            this.lblVeterinarianID.Location = new System.Drawing.Point(340, 246);
            this.lblVeterinarianID.Name = "lblVeterinarianID";
            this.lblVeterinarianID.Size = new System.Drawing.Size(135, 15);
            this.lblVeterinarianID.TabIndex = 4;
            this.lblVeterinarianID.Text = "Veterinarian ID:";
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.AutoSize = true;
            this.lblVisitDate.Location = new System.Drawing.Point(340, 383);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(95, 15);
            this.lblVisitDate.TabIndex = 5;
            this.lblVisitDate.Text = "Visit Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(340, 448);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(423, 115);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(52, 25);
            this.txtCatID.TabIndex = 7;
            // 
            // txtVeterinarianID
            // 
            this.txtVeterinarianID.Location = new System.Drawing.Point(512, 243);
            this.txtVeterinarianID.Name = "txtVeterinarianID";
            this.txtVeterinarianID.Size = new System.Drawing.Size(52, 25);
            this.txtVeterinarianID.TabIndex = 8;
            // 
            // txtVisitDate
            // 
            this.txtVisitDate.Location = new System.Drawing.Point(466, 380);
            this.txtVisitDate.Name = "txtVisitDate";
            this.txtVisitDate.Size = new System.Drawing.Size(98, 25);
            this.txtVisitDate.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(466, 445);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(108, 25);
            this.txtStatus.TabIndex = 10;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(39, 544);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(106, 35);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(189, 544);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 35);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.Location = new System.Drawing.Point(373, 544);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(123, 35);
            this.btnAddVisit.TabIndex = 13;
            this.btnAddVisit.Text = "Add Visit";
            this.btnAddVisit.UseVisualStyleBackColor = true;
            this.btnAddVisit.Click += new System.EventHandler(this.btnAddVisit_Click);
            // 
            // btnUpdateVisit
            // 
            this.btnUpdateVisit.Location = new System.Drawing.Point(189, 322);
            this.btnUpdateVisit.Name = "btnUpdateVisit";
            this.btnUpdateVisit.Size = new System.Drawing.Size(119, 34);
            this.btnUpdateVisit.TabIndex = 14;
            this.btnUpdateVisit.Text = "Update Visit";
            this.btnUpdateVisit.UseVisualStyleBackColor = true;
            this.btnUpdateVisit.Click += new System.EventHandler(this.btnUpdateVisit_Click);
            // 
            // btnDeleteVisit
            // 
            this.btnDeleteVisit.Location = new System.Drawing.Point(688, 544);
            this.btnDeleteVisit.Name = "btnDeleteVisit";
            this.btnDeleteVisit.Size = new System.Drawing.Size(117, 35);
            this.btnDeleteVisit.TabIndex = 15;
            this.btnDeleteVisit.Text = "Delete Visit";
            this.btnDeleteVisit.UseVisualStyleBackColor = true;
            this.btnDeleteVisit.Click += new System.EventHandler(this.btnDeleteVisit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(688, 622);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 33);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(546, 118);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(79, 15);
            this.lblCatName.TabIndex = 17;
            this.lblCatName.Text = "Cat Name:";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(641, 115);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(133, 25);
            this.txtCatName.TabIndex = 18;
            // 
            // lblOwerName
            // 
            this.lblOwerName.AutoSize = true;
            this.lblOwerName.Location = new System.Drawing.Point(340, 180);
            this.lblOwerName.Name = "lblOwerName";
            this.lblOwerName.Size = new System.Drawing.Size(95, 15);
            this.lblOwerName.TabIndex = 19;
            this.lblOwerName.Text = "Owner Name:";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(464, 177);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(161, 25);
            this.txtOwnerName.TabIndex = 20;
            // 
            // lblVetName
            // 
            this.lblVetName.AutoSize = true;
            this.lblVetName.Location = new System.Drawing.Point(343, 310);
            this.lblVetName.Name = "lblVetName";
            this.lblVetName.Size = new System.Drawing.Size(151, 15);
            this.lblVetName.TabIndex = 21;
            this.lblVetName.Text = "Veterinarian Name:";
            // 
            // txtVetName
            // 
            this.txtVetName.Location = new System.Drawing.Point(512, 307);
            this.txtVetName.Name = "txtVetName";
            this.txtVetName.Size = new System.Drawing.Size(173, 25);
            this.txtVetName.TabIndex = 22;
            // 
            // btnModifyVisit
            // 
            this.btnModifyVisit.Location = new System.Drawing.Point(531, 544);
            this.btnModifyVisit.Name = "btnModifyVisit";
            this.btnModifyVisit.Size = new System.Drawing.Size(119, 35);
            this.btnModifyVisit.TabIndex = 23;
            this.btnModifyVisit.Text = "Modifty Visit";
            this.btnModifyVisit.UseVisualStyleBackColor = true;
            this.btnModifyVisit.Click += new System.EventHandler(this.btnModifyVisit_Click);
            // 
            // pnlAddVisit
            // 
            this.pnlAddVisit.Controls.Add(this.dtpAddVisitDate);
            this.pnlAddVisit.Controls.Add(this.comboxAddVetID);
            this.pnlAddVisit.Controls.Add(this.comboxAddCatID);
            this.pnlAddVisit.Controls.Add(this.label3);
            this.pnlAddVisit.Controls.Add(this.label2);
            this.pnlAddVisit.Controls.Add(this.label1);
            this.pnlAddVisit.Controls.Add(this.btnSaveVisit);
            this.pnlAddVisit.Controls.Add(this.btnAddCancel);
            this.pnlAddVisit.Location = new System.Drawing.Point(25, 28);
            this.pnlAddVisit.Name = "pnlAddVisit";
            this.pnlAddVisit.Size = new System.Drawing.Size(312, 510);
            this.pnlAddVisit.TabIndex = 24;
            this.pnlAddVisit.Visible = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(27, 420);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(89, 35);
            this.btnAddCancel.TabIndex = 12;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnSaveVisit
            // 
            this.btnSaveVisit.Location = new System.Drawing.Point(150, 420);
            this.btnSaveVisit.Name = "btnSaveVisit";
            this.btnSaveVisit.Size = new System.Drawing.Size(133, 35);
            this.btnSaveVisit.TabIndex = 13;
            this.btnSaveVisit.Text = "Save Visit";
            this.btnSaveVisit.UseVisualStyleBackColor = true;
            this.btnSaveVisit.Click += new System.EventHandler(this.btnSaveVisit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cat ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Veterinarian ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Visit Date:";
            // 
            // comboxAddCatID
            // 
            this.comboxAddCatID.FormattingEnabled = true;
            this.comboxAddCatID.Location = new System.Drawing.Point(164, 131);
            this.comboxAddCatID.Name = "comboxAddCatID";
            this.comboxAddCatID.Size = new System.Drawing.Size(77, 23);
            this.comboxAddCatID.TabIndex = 17;
            // 
            // comboxAddVetID
            // 
            this.comboxAddVetID.FormattingEnabled = true;
            this.comboxAddVetID.Location = new System.Drawing.Point(164, 218);
            this.comboxAddVetID.Name = "comboxAddVetID";
            this.comboxAddVetID.Size = new System.Drawing.Size(77, 23);
            this.comboxAddVetID.TabIndex = 18;
            // 
            // dtpAddVisitDate
            // 
            this.dtpAddVisitDate.Location = new System.Drawing.Point(164, 308);
            this.dtpAddVisitDate.Name = "dtpAddVisitDate";
            this.dtpAddVisitDate.Size = new System.Drawing.Size(133, 25);
            this.dtpAddVisitDate.TabIndex = 19;
            // 
            // pnlModifyVisit
            // 
            this.pnlModifyVisit.Controls.Add(this.btnModifyCancel);
            this.pnlModifyVisit.Controls.Add(this.dtpModifyVisitDate);
            this.pnlModifyVisit.Controls.Add(this.comboxModifyVetID);
            this.pnlModifyVisit.Controls.Add(this.label5);
            this.pnlModifyVisit.Controls.Add(this.label4);
            this.pnlModifyVisit.Controls.Add(this.btnUpdateVisit);
            this.pnlModifyVisit.Location = new System.Drawing.Point(423, 28);
            this.pnlModifyVisit.Name = "pnlModifyVisit";
            this.pnlModifyVisit.Size = new System.Drawing.Size(335, 455);
            this.pnlModifyVisit.TabIndex = 25;
            this.pnlModifyVisit.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Veterinarian ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Visit Date:";
            // 
            // comboxModifyVetID
            // 
            this.comboxModifyVetID.FormattingEnabled = true;
            this.comboxModifyVetID.Location = new System.Drawing.Point(196, 105);
            this.comboxModifyVetID.Name = "comboxModifyVetID";
            this.comboxModifyVetID.Size = new System.Drawing.Size(77, 23);
            this.comboxModifyVetID.TabIndex = 19;
            // 
            // dtpModifyVisitDate
            // 
            this.dtpModifyVisitDate.Location = new System.Drawing.Point(175, 190);
            this.dtpModifyVisitDate.Name = "dtpModifyVisitDate";
            this.dtpModifyVisitDate.Size = new System.Drawing.Size(133, 25);
            this.dtpModifyVisitDate.TabIndex = 20;
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(52, 321);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(89, 35);
            this.btnModifyCancel.TabIndex = 21;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // btnMarkVisitAsPaid
            // 
            this.btnMarkVisitAsPaid.Location = new System.Drawing.Point(373, 622);
            this.btnMarkVisitAsPaid.Name = "btnMarkVisitAsPaid";
            this.btnMarkVisitAsPaid.Size = new System.Drawing.Size(185, 34);
            this.btnMarkVisitAsPaid.TabIndex = 26;
            this.btnMarkVisitAsPaid.Text = "Mark Visit as Paid";
            this.btnMarkVisitAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkVisitAsPaid.Click += new System.EventHandler(this.btnMarkVisitAsPaid_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 694);
            this.Controls.Add(this.btnMarkVisitAsPaid);
            this.Controls.Add(this.pnlModifyVisit);
            this.Controls.Add(this.pnlAddVisit);
            this.Controls.Add(this.btnModifyVisit);
            this.Controls.Add(this.txtVetName);
            this.Controls.Add(this.lblVetName);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwerName);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVisit);
            this.Controls.Add(this.btnAddVisit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtVisitDate);
            this.Controls.Add(this.txtVeterinarianID);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblVisitDate);
            this.Controls.Add(this.lblVeterinarianID);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.lblVisitID);
            this.Controls.Add(this.lblVisitNo);
            this.Controls.Add(this.lstVisits);
            this.Name = "VisitForm";
            this.Text = "Visit Maintenance";
            this.pnlAddVisit.ResumeLayout(false);
            this.pnlAddVisit.PerformLayout();
            this.pnlModifyVisit.ResumeLayout(false);
            this.pnlModifyVisit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVisits;
        private System.Windows.Forms.Label lblVisitNo;
        private System.Windows.Forms.Label lblVisitID;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblVeterinarianID;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.TextBox txtVeterinarianID;
        private System.Windows.Forms.TextBox txtVisitDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVisit;
        private System.Windows.Forms.Button btnUpdateVisit;
        private System.Windows.Forms.Button btnDeleteVisit;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblOwerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblVetName;
        private System.Windows.Forms.TextBox txtVetName;
        private System.Windows.Forms.Button btnModifyVisit;
        private System.Windows.Forms.Panel pnlAddVisit;
        private System.Windows.Forms.Button btnSaveVisit;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAddVisitDate;
        private System.Windows.Forms.ComboBox comboxAddVetID;
        private System.Windows.Forms.ComboBox comboxAddCatID;
        private System.Windows.Forms.Panel pnlModifyVisit;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.DateTimePicker dtpModifyVisitDate;
        private System.Windows.Forms.ComboBox comboxModifyVetID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMarkVisitAsPaid;
    }
}