namespace WindowsFormsApplication1
{
    partial class OwnerForm
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
            this.lstOwners = new System.Windows.Forms.ListBox();
            this.lblOwnerNo = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnModifyOwner = new System.Windows.Forms.Button();
            this.pnlAddOwner = new System.Windows.Forms.Panel();
            this.txtAddPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.txtAddStreetAddress = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveOwner = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.pnlModifyOwner = new System.Windows.Forms.Panel();
            this.txtModifyPhoneNum = new System.Windows.Forms.TextBox();
            this.txtModifySuburb = new System.Windows.Forms.TextBox();
            this.txtModifyStAddress = new System.Windows.Forms.TextBox();
            this.txtModifyFirstName = new System.Windows.Forms.TextBox();
            this.txtModifyLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.pnlAddOwner.SuspendLayout();
            this.pnlModifyOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOwners
            // 
            this.lstOwners.FormattingEnabled = true;
            this.lstOwners.ItemHeight = 15;
            this.lstOwners.Location = new System.Drawing.Point(53, 45);
            this.lstOwners.Margin = new System.Windows.Forms.Padding(4);
            this.lstOwners.Name = "lstOwners";
            this.lstOwners.Size = new System.Drawing.Size(171, 334);
            this.lstOwners.TabIndex = 0;
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.Location = new System.Drawing.Point(341, 45);
            this.lblOwnerNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(113, 29);
            this.lblOwnerNo.TabIndex = 1;
            this.lblOwnerNo.Text = "Owner ID:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.Location = new System.Drawing.Point(444, 45);
            this.lblOwnerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(133, 29);
            this.lblOwnerID.TabIndex = 2;
            this.lblOwnerID.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(341, 101);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(133, 29);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(341, 155);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 24);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.Location = new System.Drawing.Point(304, 211);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(136, 15);
            this.lblStreetAddress.TabIndex = 5;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.Location = new System.Drawing.Point(367, 268);
            this.lblSuburb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(73, 15);
            this.lblSuburb.TabIndex = 6;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(327, 320);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(113, 24);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(447, 98);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 25);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(447, 151);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 25);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(448, 200);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(172, 25);
            this.txtStreetAddress.TabIndex = 10;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(447, 256);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(289, 25);
            this.txtSuburb.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(448, 316);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(172, 25);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(53, 422);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 29);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 422);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 29);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(307, 422);
            this.btnAddOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(121, 29);
            this.btnAddOwner.TabIndex = 15;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(232, 279);
            this.btnUpdateOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(120, 29);
            this.btnUpdateOwner.TabIndex = 16;
            this.btnUpdateOwner.Text = "Update Owner";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(621, 422);
            this.btnDeleteOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(116, 29);
            this.btnDeleteOwner.TabIndex = 17;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(621, 501);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(116, 29);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnModifyOwner
            // 
            this.btnModifyOwner.Location = new System.Drawing.Point(469, 422);
            this.btnModifyOwner.Name = "btnModifyOwner";
            this.btnModifyOwner.Size = new System.Drawing.Size(120, 29);
            this.btnModifyOwner.TabIndex = 19;
            this.btnModifyOwner.Text = "Modify Owner";
            this.btnModifyOwner.UseVisualStyleBackColor = true;
            this.btnModifyOwner.Click += new System.EventHandler(this.btnModifyOwner_Click);
            // 
            // pnlAddOwner
            // 
            this.pnlAddOwner.Controls.Add(this.txtAddPhoneNum);
            this.pnlAddOwner.Controls.Add(this.txtAddSuburb);
            this.pnlAddOwner.Controls.Add(this.txtAddStreetAddress);
            this.pnlAddOwner.Controls.Add(this.txtAddFirstName);
            this.pnlAddOwner.Controls.Add(this.txtAddLastName);
            this.pnlAddOwner.Controls.Add(this.label5);
            this.pnlAddOwner.Controls.Add(this.label4);
            this.pnlAddOwner.Controls.Add(this.label3);
            this.pnlAddOwner.Controls.Add(this.label2);
            this.pnlAddOwner.Controls.Add(this.label1);
            this.pnlAddOwner.Controls.Add(this.btnSaveOwner);
            this.pnlAddOwner.Controls.Add(this.btnAddCancel);
            this.pnlAddOwner.Location = new System.Drawing.Point(296, 77);
            this.pnlAddOwner.Name = "pnlAddOwner";
            this.pnlAddOwner.Size = new System.Drawing.Size(458, 345);
            this.pnlAddOwner.TabIndex = 20;
            this.pnlAddOwner.Visible = false;
            // 
            // txtAddPhoneNum
            // 
            this.txtAddPhoneNum.Location = new System.Drawing.Point(184, 225);
            this.txtAddPhoneNum.Name = "txtAddPhoneNum";
            this.txtAddPhoneNum.Size = new System.Drawing.Size(158, 25);
            this.txtAddPhoneNum.TabIndex = 11;
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(184, 174);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(158, 25);
            this.txtAddSuburb.TabIndex = 10;
            // 
            // txtAddStreetAddress
            // 
            this.txtAddStreetAddress.Location = new System.Drawing.Point(184, 121);
            this.txtAddStreetAddress.Name = "txtAddStreetAddress";
            this.txtAddStreetAddress.Size = new System.Drawing.Size(158, 25);
            this.txtAddStreetAddress.TabIndex = 9;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(183, 67);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(158, 25);
            this.txtAddFirstName.TabIndex = 8;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(183, 15);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(158, 25);
            this.txtAddLastName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Suburb:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // btnSaveOwner
            // 
            this.btnSaveOwner.Location = new System.Drawing.Point(263, 285);
            this.btnSaveOwner.Name = "btnSaveOwner";
            this.btnSaveOwner.Size = new System.Drawing.Size(159, 28);
            this.btnSaveOwner.TabIndex = 1;
            this.btnSaveOwner.Text = "Save Owner";
            this.btnSaveOwner.UseVisualStyleBackColor = true;
            this.btnSaveOwner.Click += new System.EventHandler(this.btnSaveOwner_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(47, 284);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(124, 29);
            this.btnAddCancel.TabIndex = 0;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // pnlModifyOwner
            // 
            this.pnlModifyOwner.Controls.Add(this.txtModifyPhoneNum);
            this.pnlModifyOwner.Controls.Add(this.txtModifySuburb);
            this.pnlModifyOwner.Controls.Add(this.txtModifyStAddress);
            this.pnlModifyOwner.Controls.Add(this.txtModifyFirstName);
            this.pnlModifyOwner.Controls.Add(this.txtModifyLastName);
            this.pnlModifyOwner.Controls.Add(this.label10);
            this.pnlModifyOwner.Controls.Add(this.label9);
            this.pnlModifyOwner.Controls.Add(this.label8);
            this.pnlModifyOwner.Controls.Add(this.label7);
            this.pnlModifyOwner.Controls.Add(this.label6);
            this.pnlModifyOwner.Controls.Add(this.btnModifyCancel);
            this.pnlModifyOwner.Controls.Add(this.btnUpdateOwner);
            this.pnlModifyOwner.Location = new System.Drawing.Point(360, 12);
            this.pnlModifyOwner.Name = "pnlModifyOwner";
            this.pnlModifyOwner.Size = new System.Drawing.Size(404, 333);
            this.pnlModifyOwner.TabIndex = 21;
            this.pnlModifyOwner.Visible = false;
            // 
            // txtModifyPhoneNum
            // 
            this.txtModifyPhoneNum.Location = new System.Drawing.Point(170, 221);
            this.txtModifyPhoneNum.Name = "txtModifyPhoneNum";
            this.txtModifyPhoneNum.Size = new System.Drawing.Size(189, 25);
            this.txtModifyPhoneNum.TabIndex = 27;
            // 
            // txtModifySuburb
            // 
            this.txtModifySuburb.Location = new System.Drawing.Point(170, 171);
            this.txtModifySuburb.Name = "txtModifySuburb";
            this.txtModifySuburb.Size = new System.Drawing.Size(189, 25);
            this.txtModifySuburb.TabIndex = 26;
            // 
            // txtModifyStAddress
            // 
            this.txtModifyStAddress.Location = new System.Drawing.Point(170, 124);
            this.txtModifyStAddress.Name = "txtModifyStAddress";
            this.txtModifyStAddress.Size = new System.Drawing.Size(189, 25);
            this.txtModifyStAddress.TabIndex = 25;
            // 
            // txtModifyFirstName
            // 
            this.txtModifyFirstName.Location = new System.Drawing.Point(170, 76);
            this.txtModifyFirstName.Name = "txtModifyFirstName";
            this.txtModifyFirstName.Size = new System.Drawing.Size(189, 25);
            this.txtModifyFirstName.TabIndex = 24;
            // 
            // txtModifyLastName
            // 
            this.txtModifyLastName.Location = new System.Drawing.Point(170, 25);
            this.txtModifyLastName.Name = "txtModifyLastName";
            this.txtModifyLastName.Size = new System.Drawing.Size(189, 25);
            this.txtModifyLastName.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Suburb:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Street Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Last Name:";
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(77, 279);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(120, 29);
            this.btnModifyCancel.TabIndex = 17;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 566);
            this.Controls.Add(this.pnlModifyOwner);
            this.Controls.Add(this.pnlAddOwner);
            this.Controls.Add(this.btnModifyOwner);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblOwnerNo);
            this.Controls.Add(this.lstOwners);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OwnerForm";
            this.Text = "Owner Maintenance";
            this.pnlAddOwner.ResumeLayout(false);
            this.pnlAddOwner.PerformLayout();
            this.pnlModifyOwner.ResumeLayout(false);
            this.pnlModifyOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOwners;
        private System.Windows.Forms.Label lblOwnerNo;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnModifyOwner;
        private System.Windows.Forms.Panel pnlAddOwner;
        private System.Windows.Forms.Button btnSaveOwner;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TextBox txtAddPhoneNum;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.TextBox txtAddStreetAddress;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlModifyOwner;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.TextBox txtModifyFirstName;
        private System.Windows.Forms.TextBox txtModifyLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModifyPhoneNum;
        private System.Windows.Forms.TextBox txtModifySuburb;
        private System.Windows.Forms.TextBox txtModifyStAddress;
    }
}