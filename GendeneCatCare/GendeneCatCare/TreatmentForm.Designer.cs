namespace WindowsFormsApplication1
{
    partial class TreatmentForm
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
            this.lstTreatments = new System.Windows.Forms.ListBox();
            this.lblTreatmentNo = new System.Windows.Forms.Label();
            this.lblTreatmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddTreatment = new System.Windows.Forms.Panel();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.pnlModifyTreatment = new System.Windows.Forms.Panel();
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.txtModifyCost = new System.Windows.Forms.TextBox();
            this.txtModifyDescription = new System.Windows.Forms.TextBox();
            this.lblModifyCost = new System.Windows.Forms.Label();
            this.lblModifyDescription = new System.Windows.Forms.Label();
            this.btnModifyTreatment = new System.Windows.Forms.Button();
            this.pnlAddTreatment.SuspendLayout();
            this.pnlModifyTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTreatments
            // 
            this.lstTreatments.FormattingEnabled = true;
            this.lstTreatments.ItemHeight = 15;
            this.lstTreatments.Location = new System.Drawing.Point(44, 63);
            this.lstTreatments.Name = "lstTreatments";
            this.lstTreatments.Size = new System.Drawing.Size(214, 334);
            this.lstTreatments.TabIndex = 0;
            // 
            // lblTreatmentNo
            // 
            this.lblTreatmentNo.Location = new System.Drawing.Point(306, 78);
            this.lblTreatmentNo.Name = "lblTreatmentNo";
            this.lblTreatmentNo.Size = new System.Drawing.Size(140, 23);
            this.lblTreatmentNo.TabIndex = 1;
            this.lblTreatmentNo.Text = "Treatment ID";
            // 
            // lblTreatmentID
            // 
            this.lblTreatmentID.Location = new System.Drawing.Point(452, 78);
            this.lblTreatmentID.Name = "lblTreatmentID";
            this.lblTreatmentID.Size = new System.Drawing.Size(140, 23);
            this.lblTreatmentID.TabIndex = 2;
            this.lblTreatmentID.Text = "treatment";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(306, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(140, 23);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(306, 213);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(140, 23);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(455, 142);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(167, 25);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(455, 213);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(69, 25);
            this.txtCost.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(44, 499);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(92, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(163, 499);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(266, 499);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(80, 23);
            this.btnAddTreatment.TabIndex = 9;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Location = new System.Drawing.Point(547, 499);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteTreatment.TabIndex = 11;
            this.btnDeleteTreatment.Text = "Delete Treatment";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(547, 566);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddTreatment
            // 
            this.pnlAddTreatment.Controls.Add(this.btnSaveTreatment);
            this.pnlAddTreatment.Controls.Add(this.btnCancel);
            this.pnlAddTreatment.Controls.Add(this.txtAddCost);
            this.pnlAddTreatment.Controls.Add(this.txtAddDescription);
            this.pnlAddTreatment.Controls.Add(this.lblAddCost);
            this.pnlAddTreatment.Controls.Add(this.lblAddDescription);
            this.pnlAddTreatment.Location = new System.Drawing.Point(285, 63);
            this.pnlAddTreatment.Name = "pnlAddTreatment";
            this.pnlAddTreatment.Size = new System.Drawing.Size(409, 224);
            this.pnlAddTreatment.TabIndex = 13;
            this.pnlAddTreatment.Visible = false;
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Location = new System.Drawing.Point(252, 134);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(130, 29);
            this.btnSaveTreatment.TabIndex = 5;
            this.btnSaveTreatment.Text = "Save Treatment";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(73, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(162, 73);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(100, 25);
            this.txtAddCost.TabIndex = 3;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(162, 26);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(209, 25);
            this.txtAddDescription.TabIndex = 2;
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(70, 76);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(47, 15);
            this.lblAddCost.TabIndex = 1;
            this.lblAddCost.Text = "Cost:";
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(40, 29);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(103, 15);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description:";
            // 
            // pnlModifyTreatment
            // 
            this.pnlModifyTreatment.Controls.Add(this.btnUpdateTreatment);
            this.pnlModifyTreatment.Controls.Add(this.btnModifyCancel);
            this.pnlModifyTreatment.Controls.Add(this.txtModifyCost);
            this.pnlModifyTreatment.Controls.Add(this.txtModifyDescription);
            this.pnlModifyTreatment.Controls.Add(this.lblModifyCost);
            this.pnlModifyTreatment.Controls.Add(this.lblModifyDescription);
            this.pnlModifyTreatment.Location = new System.Drawing.Point(282, 308);
            this.pnlModifyTreatment.Name = "pnlModifyTreatment";
            this.pnlModifyTreatment.Size = new System.Drawing.Size(415, 224);
            this.pnlModifyTreatment.TabIndex = 14;
            this.pnlModifyTreatment.Visible = false;
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(220, 134);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(151, 29);
            this.btnUpdateTreatment.TabIndex = 5;
            this.btnUpdateTreatment.Text = "Update Treatment";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(59, 134);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(108, 29);
            this.btnModifyCancel.TabIndex = 4;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // txtModifyCost
            // 
            this.txtModifyCost.Location = new System.Drawing.Point(162, 80);
            this.txtModifyCost.Name = "txtModifyCost";
            this.txtModifyCost.Size = new System.Drawing.Size(100, 25);
            this.txtModifyCost.TabIndex = 3;
            // 
            // txtModifyDescription
            // 
            this.txtModifyDescription.Location = new System.Drawing.Point(162, 23);
            this.txtModifyDescription.Name = "txtModifyDescription";
            this.txtModifyDescription.Size = new System.Drawing.Size(209, 25);
            this.txtModifyDescription.TabIndex = 2;
            // 
            // lblModifyCost
            // 
            this.lblModifyCost.AutoSize = true;
            this.lblModifyCost.Location = new System.Drawing.Point(75, 83);
            this.lblModifyCost.Name = "lblModifyCost";
            this.lblModifyCost.Size = new System.Drawing.Size(47, 15);
            this.lblModifyCost.TabIndex = 1;
            this.lblModifyCost.Text = "Cost:";
            // 
            // lblModifyDescription
            // 
            this.lblModifyDescription.AutoSize = true;
            this.lblModifyDescription.Location = new System.Drawing.Point(53, 26);
            this.lblModifyDescription.Name = "lblModifyDescription";
            this.lblModifyDescription.Size = new System.Drawing.Size(103, 15);
            this.lblModifyDescription.TabIndex = 0;
            this.lblModifyDescription.Text = "Description:";
            // 
            // btnModifyTreatment
            // 
            this.btnModifyTreatment.Location = new System.Drawing.Point(372, 499);
            this.btnModifyTreatment.Name = "btnModifyTreatment";
            this.btnModifyTreatment.Size = new System.Drawing.Size(152, 23);
            this.btnModifyTreatment.TabIndex = 15;
            this.btnModifyTreatment.Text = "Modify Treatment";
            this.btnModifyTreatment.UseVisualStyleBackColor = true;
            this.btnModifyTreatment.Click += new System.EventHandler(this.btnModifyTreatment_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 641);
            this.Controls.Add(this.btnModifyTreatment);
            this.Controls.Add(this.pnlModifyTreatment);
            this.Controls.Add(this.pnlAddTreatment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteTreatment);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTreatmentID);
            this.Controls.Add(this.lblTreatmentNo);
            this.Controls.Add(this.lstTreatments);
            this.Name = "TreatmentForm";
            this.Text = "Treatment Maintenance";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.pnlAddTreatment.ResumeLayout(false);
            this.pnlAddTreatment.PerformLayout();
            this.pnlModifyTreatment.ResumeLayout(false);
            this.pnlModifyTreatment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTreatments;
        private System.Windows.Forms.Label lblTreatmentNo;
        private System.Windows.Forms.Label lblTreatmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddTreatment;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Panel pnlModifyTreatment;
        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.TextBox txtModifyCost;
        private System.Windows.Forms.TextBox txtModifyDescription;
        private System.Windows.Forms.Label lblModifyCost;
        private System.Windows.Forms.Label lblModifyDescription;
        private System.Windows.Forms.Button btnModifyTreatment;
    }
}