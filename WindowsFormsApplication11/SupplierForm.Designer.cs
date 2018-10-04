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
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(412, 143);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banking Details";
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(184, 101);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(199, 22);
            this.txtBranchCode.TabIndex = 57;
            this.txtBranchCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBranchCode_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Branch Code:";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(184, 69);
            this.txtAccNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(199, 22);
            this.txtAccNumber.TabIndex = 55;
            this.txtAccNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBankAccNo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Account Number:";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(184, 30);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(199, 22);
            this.txtBankName.TabIndex = 53;
            this.txtBankName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBankName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Bank Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Supplier Phone Number:";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(179, 102);
            this.txtSupplierEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(199, 22);
            this.txtSupplierEmail.TabIndex = 49;
            this.txtSupplierEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierEmail_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 106);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 17);
            this.label15.TabIndex = 48;
            this.label15.Text = "Supplier Email:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(179, 25);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(199, 22);
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
            this.panel2.Size = new System.Drawing.Size(813, 50);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 1);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Supplier Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSuburb);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtProvince);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtStreetName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Location = new System.Drawing.Point(445, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(349, 209);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(104, 102);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(205, 22);
            this.txtSuburb.TabIndex = 15;
            this.txtSuburb.Validating += new System.ComponentModel.CancelEventHandler(this.txtSuburb_Validating);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(104, 66);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(205, 22);
            this.txtCity.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Province:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(104, 30);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(205, 22);
            this.txtProvince.TabIndex = 12;
            this.txtProvince.Validating += new System.ComponentModel.CancelEventHandler(this.txtProvince_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Street name:";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(104, 134);
            this.txtStreetName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(205, 22);
            this.txtStreetName.TabIndex = 10;
            this.txtStreetName.Validating += new System.ComponentModel.CancelEventHandler(this.txtStreetName_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Suburb:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(107, 166);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(115, 22);
            this.txtCode.TabIndex = 4;
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.panel4);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 406);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(813, 48);
            this.panel14.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpdateSupplier);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(389, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 47);
            this.panel4.TabIndex = 10;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSupplier.Image")));
            this.btnUpdateSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(159, 9);
            this.btnUpdateSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUpdateSupplier.Size = new System.Drawing.Size(112, 34);
            this.btnUpdateSupplier.TabIndex = 10;
            this.btnUpdateSupplier.Text = "Update";
            this.btnUpdateSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Visible = false;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnSaveSupplier);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(668, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(145, 47);
            this.panel17.TabIndex = 8;
            this.panel17.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSupplier.Image")));
            this.btnSaveSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSupplier.Location = new System.Drawing.Point(17, 9);
            this.btnSaveSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSaveSupplier.Size = new System.Drawing.Size(93, 34);
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
            this.panel15.Location = new System.Drawing.Point(0, 47);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(813, 1);
            this.panel15.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 454);
            this.panel3.TabIndex = 19;
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
            this.groupBox3.Location = new System.Drawing.Point(16, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(412, 174);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier Details";
            // 
            // txtSupplierContactName
            // 
            this.txtSupplierContactName.AutoSize = true;
            this.txtSupplierContactName.Location = new System.Drawing.Point(13, 69);
            this.txtSupplierContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSupplierContactName.Name = "txtSupplierContactName";
            this.txtSupplierContactName.Size = new System.Drawing.Size(165, 17);
            this.txtSupplierContactName.TabIndex = 52;
            this.txtSupplierContactName.Text = "Supplier Contact Person:";
            // 
            // txtSupplierContactP
            // 
            this.txtSupplierContactP.Location = new System.Drawing.Point(179, 65);
            this.txtSupplierContactP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierContactP.Name = "txtSupplierContactP";
            this.txtSupplierContactP.Size = new System.Drawing.Size(199, 22);
            this.txtSupplierContactP.TabIndex = 53;
            this.txtSupplierContactP.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierContactPerson_Validating);
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(179, 134);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(199, 22);
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
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCode;
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
        private System.Windows.Forms.Label txtSupplierContactName;
        private System.Windows.Forms.TextBox txtSupplierContactP;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStreetName;
    }
}