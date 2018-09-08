namespace WindowsFormsApplication11
{
    partial class SupplierForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxSuburb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSupplierContactName = new System.Windows.Forms.Label();
            this.txtSupplierContactP = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSupplierType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBranchCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBankName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 116);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banking Details";
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(138, 82);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(150, 20);
            this.txtBranchCode.TabIndex = 57;
            this.txtBranchCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBranchCode_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Branch Code:";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(138, 56);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(150, 20);
            this.txtAccNumber.TabIndex = 55;
            this.txtAccNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBankAccNo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Account Number:";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(138, 24);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(150, 20);
            this.txtBankName.TabIndex = 53;
            this.txtBankName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBankName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Bank Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Supplier Phone Number:";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(134, 83);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(150, 20);
            this.txtSupplierEmail.TabIndex = 49;
            this.txtSupplierEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierEmail_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Supplier Email:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(134, 20);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(150, 20);
            this.txtSupplierName.TabIndex = 46;
            this.txtSupplierName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierName_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 41);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 1);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 33);
            this.label14.TabIndex = 1;
            this.label14.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Supplier Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxCity);
            this.groupBox2.Controls.Add(this.cbxSuburb);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.txtProvince);
            this.groupBox2.Controls.Add(this.txtStreetName);
            this.groupBox2.Location = new System.Drawing.Point(417, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 182);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(79, 84);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(155, 21);
            this.cbxCity.TabIndex = 11;
            // 
            // cbxSuburb
            // 
            this.cbxSuburb.FormattingEnabled = true;
            this.cbxSuburb.Location = new System.Drawing.Point(79, 57);
            this.cbxSuburb.Name = "cbxSuburb";
            this.cbxSuburb.Size = new System.Drawing.Size(155, 21);
            this.cbxSuburb.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Suburb:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Province:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Street name:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(79, 144);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(87, 20);
            this.txtCode.TabIndex = 4;
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(79, 115);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(155, 20);
            this.txtProvince.TabIndex = 3;
            this.txtProvince.Validating += new System.ComponentModel.CancelEventHandler(this.txtProvince_Validating);
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(79, 24);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(155, 20);
            this.txtStreetName.TabIndex = 0;
            this.txtStreetName.Validating += new System.ComponentModel.CancelEventHandler(this.txtStreetName_Validating);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.panel4);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 337);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(735, 39);
            this.panel14.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpdateSupplier);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(417, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 38);
            this.panel4.TabIndex = 10;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSupplier.Image")));
            this.btnUpdateSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(119, 7);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnUpdateSupplier.Size = new System.Drawing.Size(84, 28);
            this.btnUpdateSupplier.TabIndex = 10;
            this.btnUpdateSupplier.Text = "Update";
            this.btnUpdateSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnSaveSupplier);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(626, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(109, 38);
            this.panel17.TabIndex = 8;
            this.panel17.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSupplier.Image")));
            this.btnSaveSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSupplier.Location = new System.Drawing.Point(13, 7);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSaveSupplier.Size = new System.Drawing.Size(70, 28);
            this.btnSaveSupplier.TabIndex = 9;
            this.btnSaveSupplier.Text = "Save";
            this.btnSaveSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSupplier.UseVisualStyleBackColor = true;
            this.btnSaveSupplier.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 38);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(735, 1);
            this.panel15.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 376);
            this.panel3.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxSupplierType);
            this.groupBox4.Location = new System.Drawing.Point(417, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 56);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supplier Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSupplierContactName);
            this.groupBox3.Controls.Add(this.txtSupplierContactP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSupplierName);
            this.groupBox3.Controls.Add(this.txtSupplierPhone);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSupplierEmail);
            this.groupBox3.Location = new System.Drawing.Point(12, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 141);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier Details";
            // 
            // txtSupplierContactName
            // 
            this.txtSupplierContactName.AutoSize = true;
            this.txtSupplierContactName.Location = new System.Drawing.Point(10, 56);
            this.txtSupplierContactName.Name = "txtSupplierContactName";
            this.txtSupplierContactName.Size = new System.Drawing.Size(124, 13);
            this.txtSupplierContactName.TabIndex = 52;
            this.txtSupplierContactName.Text = "Supplier Contact Person:";
            // 
            // txtSupplierContactP
            // 
            this.txtSupplierContactP.Location = new System.Drawing.Point(134, 53);
            this.txtSupplierContactP.Name = "txtSupplierContactP";
            this.txtSupplierContactP.Size = new System.Drawing.Size(150, 20);
            this.txtSupplierContactP.TabIndex = 53;
            this.txtSupplierContactP.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierContactPerson_Validating);
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(134, 109);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(150, 20);
            this.txtSupplierPhone.TabIndex = 51;
            this.txtSupplierPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierPhoneNumber_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // employeeTypeBindingSource2
            // 
            this.employeeTypeBindingSource2.DataMember = "EmployeeType";
            // 
            // genderBindingSource1
            // 
            this.genderBindingSource1.DataMember = "Gender";
            // 
            // cbxSupplierType
            // 
            this.cbxSupplierType.FormattingEnabled = true;
            this.cbxSupplierType.Location = new System.Drawing.Point(6, 19);
            this.cbxSupplierType.Name = "cbxSupplierType";
            this.cbxSupplierType.Size = new System.Drawing.Size(213, 21);
            this.cbxSupplierType.TabIndex = 12;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel3);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource2;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource1;
        private System.Windows.Forms.BindingSource genderBindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtSupplierContactName;
        private System.Windows.Forms.TextBox txtSupplierContactP;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxSuburb;
        private System.Windows.Forms.ComboBox cbxSupplierType;
    }
}