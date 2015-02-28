namespace WindowsFormsApplication1
{
    partial class CatForm
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
            this.lstCats = new System.Windows.Forms.ListBox();
            this.lblCatNo = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblNeutered = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtNeutered = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.btnModifyCat = new System.Windows.Forms.Button();
            this.pnlAddCat = new System.Windows.Forms.Panel();
            this.comboxAddOwnerID = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboxAddGender = new System.Windows.Forms.ComboBox();
            this.txtAddBreed = new System.Windows.Forms.TextBox();
            this.txtAddCatName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.pnlModifyCat = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboxModifyGender = new System.Windows.Forms.ComboBox();
            this.txtModifyBreed = new System.Windows.Forms.TextBox();
            this.txtModifyCatName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.pnlAddCat.SuspendLayout();
            this.pnlModifyCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCats
            // 
            this.lstCats.FormattingEnabled = true;
            this.lstCats.ItemHeight = 15;
            this.lstCats.Location = new System.Drawing.Point(51, 52);
            this.lstCats.Name = "lstCats";
            this.lstCats.Size = new System.Drawing.Size(267, 514);
            this.lstCats.TabIndex = 0;
            // 
            // lblCatNo
            // 
            this.lblCatNo.AutoSize = true;
            this.lblCatNo.Location = new System.Drawing.Point(413, 68);
            this.lblCatNo.Name = "lblCatNo";
            this.lblCatNo.Size = new System.Drawing.Size(63, 15);
            this.lblCatNo.TabIndex = 1;
            this.lblCatNo.Text = "Cat ID:";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(546, 68);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(39, 15);
            this.lblCatID.TabIndex = 2;
            this.lblCatID.Text = "null";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(413, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Cat Name:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(413, 205);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(55, 15);
            this.lblBreed.TabIndex = 4;
            this.lblBreed.Text = "Breed:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(413, 270);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 15);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(413, 341);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(119, 15);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblNeutered
            // 
            this.lblNeutered.AutoSize = true;
            this.lblNeutered.Location = new System.Drawing.Point(413, 414);
            this.lblNeutered.Name = "lblNeutered";
            this.lblNeutered.Size = new System.Drawing.Size(79, 15);
            this.lblNeutered.TabIndex = 7;
            this.lblNeutered.Text = "Neutered:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(413, 485);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(79, 15);
            this.lblOwnerID.TabIndex = 8;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(549, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 25);
            this.txtName.TabIndex = 9;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(549, 202);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(84, 25);
            this.txtBreed.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(549, 270);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(84, 25);
            this.txtGender.TabIndex = 11;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(549, 341);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(107, 25);
            this.txtDateOfBirth.TabIndex = 12;
            // 
            // txtNeutered
            // 
            this.txtNeutered.Location = new System.Drawing.Point(549, 411);
            this.txtNeutered.Name = "txtNeutered";
            this.txtNeutered.Size = new System.Drawing.Size(69, 25);
            this.txtNeutered.TabIndex = 13;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(549, 475);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(69, 25);
            this.txtOwnerID.TabIndex = 14;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(51, 597);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 45);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(203, 597);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 45);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(343, 597);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(94, 45);
            this.btnAddCat.TabIndex = 17;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(188, 427);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(110, 36);
            this.btnUpdateCat.TabIndex = 18;
            this.btnUpdateCat.Text = "Update Cat";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(638, 597);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(103, 45);
            this.btnDeleteCat.TabIndex = 19;
            this.btnDeleteCat.Text = "Delete Cat";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(638, 663);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(103, 45);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(413, 551);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(95, 15);
            this.lblOwnerName.TabIndex = 21;
            this.lblOwnerName.Text = "Owner Name:";
            // 
            // btnModifyCat
            // 
            this.btnModifyCat.Location = new System.Drawing.Point(487, 597);
            this.btnModifyCat.Name = "btnModifyCat";
            this.btnModifyCat.Size = new System.Drawing.Size(110, 45);
            this.btnModifyCat.TabIndex = 23;
            this.btnModifyCat.Text = "Modify Cat";
            this.btnModifyCat.UseVisualStyleBackColor = true;
            this.btnModifyCat.Click += new System.EventHandler(this.btnModifyCat_Click);
            // 
            // pnlAddCat
            // 
            this.pnlAddCat.Controls.Add(this.comboxAddOwnerID);
            this.pnlAddCat.Controls.Add(this.checkBox1);
            this.pnlAddCat.Controls.Add(this.dateTimePicker1);
            this.pnlAddCat.Controls.Add(this.comboxAddGender);
            this.pnlAddCat.Controls.Add(this.txtAddBreed);
            this.pnlAddCat.Controls.Add(this.txtAddCatName);
            this.pnlAddCat.Controls.Add(this.label6);
            this.pnlAddCat.Controls.Add(this.label5);
            this.pnlAddCat.Controls.Add(this.label4);
            this.pnlAddCat.Controls.Add(this.label3);
            this.pnlAddCat.Controls.Add(this.label2);
            this.pnlAddCat.Controls.Add(this.label1);
            this.pnlAddCat.Controls.Add(this.btnAddCancel);
            this.pnlAddCat.Controls.Add(this.btnSaveCat);
            this.pnlAddCat.Location = new System.Drawing.Point(51, 68);
            this.pnlAddCat.Name = "pnlAddCat";
            this.pnlAddCat.Size = new System.Drawing.Size(316, 499);
            this.pnlAddCat.TabIndex = 24;
            this.pnlAddCat.Visible = false;
            // 
            // comboxAddOwnerID
            // 
            this.comboxAddOwnerID.FormattingEnabled = true;
            this.comboxAddOwnerID.Location = new System.Drawing.Point(145, 373);
            this.comboxAddOwnerID.Name = "comboxAddOwnerID";
            this.comboxAddOwnerID.Size = new System.Drawing.Size(121, 23);
            this.comboxAddOwnerID.TabIndex = 32;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 19);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Checked if neutered";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 25);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // comboxAddGender
            // 
            this.comboxAddGender.FormattingEnabled = true;
            this.comboxAddGender.Location = new System.Drawing.Point(136, 178);
            this.comboxAddGender.Name = "comboxAddGender";
            this.comboxAddGender.Size = new System.Drawing.Size(121, 23);
            this.comboxAddGender.TabIndex = 29;
            // 
            // txtAddBreed
            // 
            this.txtAddBreed.Location = new System.Drawing.Point(136, 107);
            this.txtAddBreed.Name = "txtAddBreed";
            this.txtAddBreed.Size = new System.Drawing.Size(84, 25);
            this.txtAddBreed.TabIndex = 28;
            // 
            // txtAddCatName
            // 
            this.txtAddCatName.Location = new System.Drawing.Point(136, 45);
            this.txtAddCatName.Name = "txtAddCatName";
            this.txtAddCatName.Size = new System.Drawing.Size(138, 25);
            this.txtAddCatName.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Owner ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Neutered:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Breed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cat Name:";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(21, 427);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(110, 36);
            this.btnAddCancel.TabIndex = 20;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(178, 427);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(110, 36);
            this.btnSaveCat.TabIndex = 19;
            this.btnSaveCat.Text = "Save Cat";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(549, 541);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(154, 25);
            this.txtOwnerName.TabIndex = 22;
            // 
            // pnlModifyCat
            // 
            this.pnlModifyCat.Controls.Add(this.checkBox2);
            this.pnlModifyCat.Controls.Add(this.dateTimePicker2);
            this.pnlModifyCat.Controls.Add(this.comboxModifyGender);
            this.pnlModifyCat.Controls.Add(this.txtModifyBreed);
            this.pnlModifyCat.Controls.Add(this.txtModifyCatName);
            this.pnlModifyCat.Controls.Add(this.label11);
            this.pnlModifyCat.Controls.Add(this.label10);
            this.pnlModifyCat.Controls.Add(this.label9);
            this.pnlModifyCat.Controls.Add(this.label8);
            this.pnlModifyCat.Controls.Add(this.label7);
            this.pnlModifyCat.Controls.Add(this.btnModifyCancel);
            this.pnlModifyCat.Controls.Add(this.btnUpdateCat);
            this.pnlModifyCat.Location = new System.Drawing.Point(405, 68);
            this.pnlModifyCat.Name = "pnlModifyCat";
            this.pnlModifyCat.Size = new System.Drawing.Size(318, 499);
            this.pnlModifyCat.TabIndex = 25;
            this.pnlModifyCat.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(127, 353);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(181, 19);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "Checked if neutered";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(165, 273);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 25);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // comboxModifyGender
            // 
            this.comboxModifyGender.FormattingEnabled = true;
            this.comboxModifyGender.Location = new System.Drawing.Point(144, 202);
            this.comboxModifyGender.Name = "comboxModifyGender";
            this.comboxModifyGender.Size = new System.Drawing.Size(121, 23);
            this.comboxModifyGender.TabIndex = 30;
            // 
            // txtModifyBreed
            // 
            this.txtModifyBreed.Location = new System.Drawing.Point(144, 119);
            this.txtModifyBreed.Name = "txtModifyBreed";
            this.txtModifyBreed.Size = new System.Drawing.Size(84, 25);
            this.txtModifyBreed.TabIndex = 29;
            // 
            // txtModifyCatName
            // 
            this.txtModifyCatName.Location = new System.Drawing.Point(144, 42);
            this.txtModifyCatName.Name = "txtModifyCatName";
            this.txtModifyCatName.Size = new System.Drawing.Size(138, 25);
            this.txtModifyCatName.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Neutered:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Breed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cat Name:";
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(42, 427);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(110, 36);
            this.btnModifyCancel.TabIndex = 21;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // CatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 761);
            this.Controls.Add(this.pnlModifyCat);
            this.Controls.Add(this.pnlAddCat);
            this.Controls.Add(this.btnModifyCat);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtNeutered);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblNeutered);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.lblCatNo);
            this.Controls.Add(this.lstCats);
            this.Name = "CatForm";
            this.Text = "Cat Maintenance";
            this.pnlAddCat.ResumeLayout(false);
            this.pnlAddCat.PerformLayout();
            this.pnlModifyCat.ResumeLayout(false);
            this.pnlModifyCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCats;
        private System.Windows.Forms.Label lblCatNo;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblNeutered;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtNeutered;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Button btnModifyCat;
        private System.Windows.Forms.Panel pnlAddCat;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.ComboBox comboxAddGender;
        private System.Windows.Forms.TextBox txtAddBreed;
        private System.Windows.Forms.TextBox txtAddCatName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboxAddOwnerID;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Panel pnlModifyCat;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboxModifyGender;
        private System.Windows.Forms.TextBox txtModifyBreed;
        private System.Windows.Forms.TextBox txtModifyCatName;
    }
}