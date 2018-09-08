namespace WindowsFormsApplication11
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.txtProvimce = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSurburb = new System.Windows.Forms.TextBox();
            this.txtStreeName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerNames = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(436, 67);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 1);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 31);
            this.label14.TabIndex = 1;
            this.label14.Text = "Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rbtFemale);
            this.groupBox1.Controls.Add(this.rbtMale);
            this.groupBox1.Controls.Add(this.txtCustomerSurname);
            this.groupBox1.Controls.Add(this.txtCustomerNames);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 475);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Detail(s)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHouseNo);
            this.groupBox3.Controls.Add(this.txtProvimce);
            this.groupBox3.Controls.Add(this.txtCity);
            this.groupBox3.Controls.Add(this.txtSurburb);
            this.groupBox3.Controls.Add(this.txtStreeName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 137);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address Details";
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(345, 27);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(67, 20);
            this.txtHouseNo.TabIndex = 9;
            // 
            // txtProvimce
            // 
            this.txtProvimce.Location = new System.Drawing.Point(91, 103);
            this.txtProvimce.Name = "txtProvimce";
            this.txtProvimce.Size = new System.Drawing.Size(199, 20);
            this.txtProvimce.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(91, 77);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(199, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtSurburb
            // 
            this.txtSurburb.Location = new System.Drawing.Point(91, 53);
            this.txtSurburb.Name = "txtSurburb";
            this.txtSurburb.Size = new System.Drawing.Size(199, 20);
            this.txtSurburb.TabIndex = 6;
            // 
            // txtStreeName
            // 
            this.txtStreeName.Location = new System.Drawing.Point(100, 27);
            this.txtStreeName.Name = "txtStreeName";
            this.txtStreeName.Size = new System.Drawing.Size(149, 20);
            this.txtStreeName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Suburb :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "City :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Province :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "House Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Street Name :";
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(70, 153);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtFemale.TabIndex = 7;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(70, 130);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(48, 17);
            this.rbtMale.TabIndex = 6;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(69, 92);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerSurname.TabIndex = 5;
            // 
            // txtCustomerNames
            // 
            this.txtCustomerNames.Location = new System.Drawing.Point(69, 51);
            this.txtCustomerNames.Name = "txtCustomerNames";
            this.txtCustomerNames.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerNames.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtContactNo);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Detail(s)";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(124, 36);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(141, 20);
            this.txtContactNo.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email Addres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name(s) :";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.btnUpdateEmployee);
            this.panel14.Controls.Add(this.button7);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 534);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(436, 61);
            this.panel14.TabIndex = 19;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmployee.Image")));
            this.btnUpdateEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(258, 20);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnUpdateEmployee.Size = new System.Drawing.Size(84, 28);
            this.btnUpdateEmployee.TabIndex = 59;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(348, 20);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button7.Size = new System.Drawing.Size(70, 28);
            this.button7.TabIndex = 9;
            this.button7.Text = "Save";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 60);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(436, 1);
            this.panel15.TabIndex = 0;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 595);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "frmAddCustomer";
            this.Text = "Customer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.TextBox txtProvimce;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSurburb;
        private System.Windows.Forms.TextBox txtStreeName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerNames;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnUpdateEmployee;
    }
}