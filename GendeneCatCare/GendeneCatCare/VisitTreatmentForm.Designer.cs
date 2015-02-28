namespace WindowsFormsApplication1
{
    partial class VisitTreatmentForm
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
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstVisits = new System.Windows.Forms.ListBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblVetName = new System.Windows.Forms.Label();
            this.txtVetName = new System.Windows.Forms.TextBox();
            this.btnModifyTreatment = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstTreatmentIDDescription = new System.Windows.Forms.ListBox();
            this.pnlAllocateTreatment = new System.Windows.Forms.Panel();
            this.txtAllocatateQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxAllocateTreatmentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.btnAllocateCancel = new System.Windows.Forms.Button();
            this.pnlModifyTreatment = new System.Windows.Forms.Panel();
            this.txtModifyQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.pnlAllocateTreatment.SuspendLayout();
            this.pnlModifyTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(70, 338);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(129, 59);
            this.btnAllocate.TabIndex = 3;
            this.btnAllocate.Text = "Allocate Treatment";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(508, 338);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 59);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Treatment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(399, 275);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(106, 28);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstVisits
            // 
            this.lstVisits.FormattingEnabled = true;
            this.lstVisits.ItemHeight = 15;
            this.lstVisits.Location = new System.Drawing.Point(42, 29);
            this.lstVisits.Name = "lstVisits";
            this.lstVisits.Size = new System.Drawing.Size(231, 274);
            this.lstVisits.TabIndex = 9;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(324, 33);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(79, 15);
            this.lblCatName.TabIndex = 10;
            this.lblCatName.Text = "Cat Name:";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(469, 33);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(146, 25);
            this.txtCatName.TabIndex = 11;
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(324, 89);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(95, 15);
            this.lblOwnerName.TabIndex = 12;
            this.lblOwnerName.Text = "Owner Name:";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(469, 86);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(146, 25);
            this.txtOwnerName.TabIndex = 13;
            // 
            // lblVetName
            // 
            this.lblVetName.AutoSize = true;
            this.lblVetName.Location = new System.Drawing.Point(308, 147);
            this.lblVetName.Name = "lblVetName";
            this.lblVetName.Size = new System.Drawing.Size(151, 15);
            this.lblVetName.TabIndex = 14;
            this.lblVetName.Text = "Veterinarian Name:";
            // 
            // txtVetName
            // 
            this.txtVetName.Location = new System.Drawing.Point(469, 144);
            this.txtVetName.Name = "txtVetName";
            this.txtVetName.Size = new System.Drawing.Size(146, 25);
            this.txtVetName.TabIndex = 15;
            // 
            // btnModifyTreatment
            // 
            this.btnModifyTreatment.Location = new System.Drawing.Point(289, 338);
            this.btnModifyTreatment.Name = "btnModifyTreatment";
            this.btnModifyTreatment.Size = new System.Drawing.Size(130, 59);
            this.btnModifyTreatment.TabIndex = 20;
            this.btnModifyTreatment.Text = "Modify Treatment";
            this.btnModifyTreatment.UseVisualStyleBackColor = true;
            this.btnModifyTreatment.Click += new System.EventHandler(this.btnModifyTreatment_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(317, 217);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 25);
            this.btnPrevious.TabIndex = 21;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(486, 217);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 25);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lstTreatmentIDDescription
            // 
            this.lstTreatmentIDDescription.FormattingEnabled = true;
            this.lstTreatmentIDDescription.ItemHeight = 15;
            this.lstTreatmentIDDescription.Location = new System.Drawing.Point(70, 421);
            this.lstTreatmentIDDescription.Name = "lstTreatmentIDDescription";
            this.lstTreatmentIDDescription.Size = new System.Drawing.Size(581, 229);
            this.lstTreatmentIDDescription.TabIndex = 23;
            // 
            // pnlAllocateTreatment
            // 
            this.pnlAllocateTreatment.Controls.Add(this.txtAllocatateQuantity);
            this.pnlAllocateTreatment.Controls.Add(this.label2);
            this.pnlAllocateTreatment.Controls.Add(this.comboxAllocateTreatmentID);
            this.pnlAllocateTreatment.Controls.Add(this.label1);
            this.pnlAllocateTreatment.Controls.Add(this.btnSaveTreatment);
            this.pnlAllocateTreatment.Controls.Add(this.btnAllocateCancel);
            this.pnlAllocateTreatment.Location = new System.Drawing.Point(30, 29);
            this.pnlAllocateTreatment.Name = "pnlAllocateTreatment";
            this.pnlAllocateTreatment.Size = new System.Drawing.Size(308, 346);
            this.pnlAllocateTreatment.TabIndex = 24;
            this.pnlAllocateTreatment.Visible = false;
            // 
            // txtAllocatateQuantity
            // 
            this.txtAllocatateQuantity.Location = new System.Drawing.Point(172, 152);
            this.txtAllocatateQuantity.Name = "txtAllocatateQuantity";
            this.txtAllocatateQuantity.Size = new System.Drawing.Size(86, 25);
            this.txtAllocatateQuantity.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity:";
            // 
            // comboxAllocateTreatmentID
            // 
            this.comboxAllocateTreatmentID.FormattingEnabled = true;
            this.comboxAllocateTreatmentID.Location = new System.Drawing.Point(172, 80);
            this.comboxAllocateTreatmentID.Name = "comboxAllocateTreatmentID";
            this.comboxAllocateTreatmentID.Size = new System.Drawing.Size(86, 23);
            this.comboxAllocateTreatmentID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Treatment ID:";
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Location = new System.Drawing.Point(151, 240);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(130, 34);
            this.btnSaveTreatment.TabIndex = 9;
            this.btnSaveTreatment.Text = "Save Treatment";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // btnAllocateCancel
            // 
            this.btnAllocateCancel.Location = new System.Drawing.Point(26, 240);
            this.btnAllocateCancel.Name = "btnAllocateCancel";
            this.btnAllocateCancel.Size = new System.Drawing.Size(90, 34);
            this.btnAllocateCancel.TabIndex = 8;
            this.btnAllocateCancel.Text = "Cancel";
            this.btnAllocateCancel.UseVisualStyleBackColor = true;
            this.btnAllocateCancel.Click += new System.EventHandler(this.btnAllocateCancel_Click);
            // 
            // pnlModifyTreatment
            // 
            this.pnlModifyTreatment.Controls.Add(this.txtModifyQuantity);
            this.pnlModifyTreatment.Controls.Add(this.label3);
            this.pnlModifyTreatment.Controls.Add(this.btnUpdateTreatment);
            this.pnlModifyTreatment.Controls.Add(this.btnModifyCancel);
            this.pnlModifyTreatment.Location = new System.Drawing.Point(359, 29);
            this.pnlModifyTreatment.Name = "pnlModifyTreatment";
            this.pnlModifyTreatment.Size = new System.Drawing.Size(329, 346);
            this.pnlModifyTreatment.TabIndex = 25;
            this.pnlModifyTreatment.Visible = false;
            // 
            // txtModifyQuantity
            // 
            this.txtModifyQuantity.Location = new System.Drawing.Point(163, 122);
            this.txtModifyQuantity.Name = "txtModifyQuantity";
            this.txtModifyQuantity.Size = new System.Drawing.Size(86, 25);
            this.txtModifyQuantity.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity:";
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(155, 240);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(147, 34);
            this.btnUpdateTreatment.TabIndex = 10;
            this.btnUpdateTreatment.Text = "Update Treatment";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(25, 240);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(90, 34);
            this.btnModifyCancel.TabIndex = 9;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // VisitTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 691);
            this.Controls.Add(this.pnlModifyTreatment);
            this.Controls.Add(this.pnlAllocateTreatment);
            this.Controls.Add(this.lstTreatmentIDDescription);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnModifyTreatment);
            this.Controls.Add(this.txtVetName);
            this.Controls.Add(this.lblVetName);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lstVisits);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAllocate);
            this.Name = "VisitTreatmentForm";
            this.Text = "Allocate Treatment to Visit";
            this.pnlAllocateTreatment.ResumeLayout(false);
            this.pnlAllocateTreatment.PerformLayout();
            this.pnlModifyTreatment.ResumeLayout(false);
            this.pnlModifyTreatment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstVisits;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblVetName;
        private System.Windows.Forms.TextBox txtVetName;
        private System.Windows.Forms.Button btnModifyTreatment;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstTreatmentIDDescription;
        private System.Windows.Forms.Panel pnlAllocateTreatment;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.Button btnAllocateCancel;
        private System.Windows.Forms.TextBox txtAllocatateQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxAllocateTreatmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlModifyTreatment;
        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.TextBox txtModifyQuantity;
        private System.Windows.Forms.Label label3;
    }
}