namespace WindowsFormsApplication1
{
    partial class VeterinarianForm
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
            this.lstVeterinarians = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblVeterinarianNo = new System.Windows.Forms.Label();
            this.lblVeterinarianID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVeterinarian = new System.Windows.Forms.Button();
            this.btnUpdateVeterinarian = new System.Windows.Forms.Button();
            this.btnDeleteVeterinarian = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnModifyVet = new System.Windows.Forms.Button();
            this.pnlAddVet = new System.Windows.Forms.Panel();
            this.pnlModifyVet = new System.Windows.Forms.Panel();
            this.txtModifyRate = new System.Windows.Forms.TextBox();
            this.txtModifyFirstName = new System.Windows.Forms.TextBox();
            this.txtModifyLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.txtAddRate = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSaveVet = new System.Windows.Forms.Button();
            this.pnlAddVet.SuspendLayout();
            this.pnlModifyVet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVeterinarians
            // 
            this.lstVeterinarians.FormattingEnabled = true;
            this.lstVeterinarians.ItemHeight = 15;
            this.lstVeterinarians.Location = new System.Drawing.Point(45, 41);
            this.lstVeterinarians.Margin = new System.Windows.Forms.Padding(4);
            this.lstVeterinarians.Name = "lstVeterinarians";
            this.lstVeterinarians.Size = new System.Drawing.Size(231, 304);
            this.lstVeterinarians.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(45, 369);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 29);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblVeterinarianNo
            // 
            this.lblVeterinarianNo.AutoSize = true;
            this.lblVeterinarianNo.Location = new System.Drawing.Point(391, 41);
            this.lblVeterinarianNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeterinarianNo.Name = "lblVeterinarianNo";
            this.lblVeterinarianNo.Size = new System.Drawing.Size(135, 15);
            this.lblVeterinarianNo.TabIndex = 2;
            this.lblVeterinarianNo.Text = "Veterinarian ID:";
            // 
            // lblVeterinarianID
            // 
            this.lblVeterinarianID.AutoSize = true;
            this.lblVeterinarianID.Location = new System.Drawing.Point(539, 41);
            this.lblVeterinarianID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeterinarianID.Name = "lblVeterinarianID";
            this.lblVeterinarianID.Size = new System.Drawing.Size(39, 15);
            this.lblVeterinarianID.TabIndex = 3;
            this.lblVeterinarianID.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(439, 106);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(431, 172);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(95, 15);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(479, 239);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(47, 15);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Rate:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(541, 102);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(167, 25);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(541, 169);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(167, 25);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(541, 235);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(91, 25);
            this.txtRate.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(177, 369);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 29);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVeterinarian
            // 
            this.btnAddVeterinarian.Location = new System.Drawing.Point(315, 369);
            this.btnAddVeterinarian.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVeterinarian.Name = "btnAddVeterinarian";
            this.btnAddVeterinarian.Size = new System.Drawing.Size(153, 29);
            this.btnAddVeterinarian.TabIndex = 11;
            this.btnAddVeterinarian.Text = "Add Veterinarian";
            this.btnAddVeterinarian.UseVisualStyleBackColor = true;
            this.btnAddVeterinarian.Click += new System.EventHandler(this.btnAddVeterinarian_Click);
            // 
            // btnUpdateVeterinarian
            // 
            this.btnUpdateVeterinarian.Location = new System.Drawing.Point(231, 235);
            this.btnUpdateVeterinarian.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateVeterinarian.Name = "btnUpdateVeterinarian";
            this.btnUpdateVeterinarian.Size = new System.Drawing.Size(173, 29);
            this.btnUpdateVeterinarian.TabIndex = 12;
            this.btnUpdateVeterinarian.Text = "Update Veterinarian";
            this.btnUpdateVeterinarian.UseVisualStyleBackColor = true;
            this.btnUpdateVeterinarian.Click += new System.EventHandler(this.btnUpdateVeterinarian_Click);
            // 
            // btnDeleteVeterinarian
            // 
            this.btnDeleteVeterinarian.Location = new System.Drawing.Point(695, 369);
            this.btnDeleteVeterinarian.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteVeterinarian.Name = "btnDeleteVeterinarian";
            this.btnDeleteVeterinarian.Size = new System.Drawing.Size(179, 29);
            this.btnDeleteVeterinarian.TabIndex = 13;
            this.btnDeleteVeterinarian.Text = "Delete Veterinarian";
            this.btnDeleteVeterinarian.UseVisualStyleBackColor = true;
            this.btnDeleteVeterinarian.Click += new System.EventHandler(this.btnDeleteVeterinarian_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(695, 445);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(179, 29);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnModifyVet
            // 
            this.btnModifyVet.Location = new System.Drawing.Point(497, 369);
            this.btnModifyVet.Name = "btnModifyVet";
            this.btnModifyVet.Size = new System.Drawing.Size(173, 29);
            this.btnModifyVet.TabIndex = 15;
            this.btnModifyVet.Text = "Modify Veterinarian";
            this.btnModifyVet.UseVisualStyleBackColor = true;
            this.btnModifyVet.Click += new System.EventHandler(this.btnModifyVet_Click);
            // 
            // pnlAddVet
            // 
            this.pnlAddVet.Controls.Add(this.txtAddRate);
            this.pnlAddVet.Controls.Add(this.txtAddFirstName);
            this.pnlAddVet.Controls.Add(this.txtAddLastName);
            this.pnlAddVet.Controls.Add(this.label3);
            this.pnlAddVet.Controls.Add(this.label2);
            this.pnlAddVet.Controls.Add(this.label1);
            this.pnlAddVet.Controls.Add(this.btnAddCancel);
            this.pnlAddVet.Controls.Add(this.btnAddSaveVet);
            this.pnlAddVet.Location = new System.Drawing.Point(9, 12);
            this.pnlAddVet.Name = "pnlAddVet";
            this.pnlAddVet.Size = new System.Drawing.Size(423, 296);
            this.pnlAddVet.TabIndex = 16;
            this.pnlAddVet.Visible = false;
            // 
            // pnlModifyVet
            // 
            this.pnlModifyVet.Controls.Add(this.txtModifyRate);
            this.pnlModifyVet.Controls.Add(this.txtModifyFirstName);
            this.pnlModifyVet.Controls.Add(this.txtModifyLastName);
            this.pnlModifyVet.Controls.Add(this.label6);
            this.pnlModifyVet.Controls.Add(this.label5);
            this.pnlModifyVet.Controls.Add(this.label4);
            this.pnlModifyVet.Controls.Add(this.btnModifyCancel);
            this.pnlModifyVet.Controls.Add(this.btnUpdateVeterinarian);
            this.pnlModifyVet.Location = new System.Drawing.Point(451, 12);
            this.pnlModifyVet.Name = "pnlModifyVet";
            this.pnlModifyVet.Size = new System.Drawing.Size(423, 296);
            this.pnlModifyVet.TabIndex = 17;
            this.pnlModifyVet.Visible = false;
            // 
            // txtModifyRate
            // 
            this.txtModifyRate.Location = new System.Drawing.Point(183, 183);
            this.txtModifyRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifyRate.Name = "txtModifyRate";
            this.txtModifyRate.Size = new System.Drawing.Size(91, 25);
            this.txtModifyRate.TabIndex = 19;
            // 
            // txtModifyFirstName
            // 
            this.txtModifyFirstName.Location = new System.Drawing.Point(183, 109);
            this.txtModifyFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifyFirstName.Name = "txtModifyFirstName";
            this.txtModifyFirstName.Size = new System.Drawing.Size(167, 25);
            this.txtModifyFirstName.TabIndex = 18;
            // 
            // txtModifyLastName
            // 
            this.txtModifyLastName.Location = new System.Drawing.Point(183, 31);
            this.txtModifyLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifyLastName.Name = "txtModifyLastName";
            this.txtModifyLastName.Size = new System.Drawing.Size(167, 25);
            this.txtModifyLastName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name:";
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(31, 235);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(134, 29);
            this.btnModifyCancel.TabIndex = 13;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // txtAddRate
            // 
            this.txtAddRate.Location = new System.Drawing.Point(183, 167);
            this.txtAddRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddRate.Name = "txtAddRate";
            this.txtAddRate.Size = new System.Drawing.Size(91, 25);
            this.txtAddRate.TabIndex = 10;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(183, 99);
            this.txtAddFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(167, 25);
            this.txtAddFirstName.TabIndex = 9;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(183, 41);
            this.txtAddLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(167, 25);
            this.txtAddLastName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name:";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(33, 229);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(134, 35);
            this.btnAddCancel.TabIndex = 1;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSaveVet
            // 
            this.btnAddSaveVet.Location = new System.Drawing.Point(220, 229);
            this.btnAddSaveVet.Name = "btnAddSaveVet";
            this.btnAddSaveVet.Size = new System.Drawing.Size(170, 35);
            this.btnAddSaveVet.TabIndex = 0;
            this.btnAddSaveVet.Text = "Save Veterinarian";
            this.btnAddSaveVet.UseVisualStyleBackColor = true;
            this.btnAddSaveVet.Click += new System.EventHandler(this.btnAddSaveVet_Click);
            // 
            // VeterinarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 508);
            this.Controls.Add(this.pnlModifyVet);
            this.Controls.Add(this.pnlAddVet);
            this.Controls.Add(this.btnModifyVet);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVeterinarian);
            this.Controls.Add(this.btnAddVeterinarian);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblVeterinarianID);
            this.Controls.Add(this.lblVeterinarianNo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstVeterinarians);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VeterinarianForm";
            this.Text = "Veterinarian Maintenance";
            this.pnlAddVet.ResumeLayout(false);
            this.pnlAddVet.PerformLayout();
            this.pnlModifyVet.ResumeLayout(false);
            this.pnlModifyVet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeterinarians;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblVeterinarianNo;
        private System.Windows.Forms.Label lblVeterinarianID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVeterinarian;
        private System.Windows.Forms.Button btnUpdateVeterinarian;
        private System.Windows.Forms.Button btnDeleteVeterinarian;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnModifyVet;
        private System.Windows.Forms.Panel pnlAddVet;
        private System.Windows.Forms.TextBox txtAddRate;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSaveVet;
        private System.Windows.Forms.Panel pnlModifyVet;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModifyRate;
        private System.Windows.Forms.TextBox txtModifyFirstName;
        private System.Windows.Forms.TextBox txtModifyLastName;
    }
}