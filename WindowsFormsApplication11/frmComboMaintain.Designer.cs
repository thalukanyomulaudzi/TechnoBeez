namespace WindowsFormsApplication11
{
    partial class frmComboMaintain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComboMaintain));
            this.txtcomboPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcomboName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSelecteditems = new System.Windows.Forms.TextBox();
            this.btnFindCombo = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateCombo = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcomboPrice
            // 
            this.txtcomboPrice.Location = new System.Drawing.Point(111, 393);
            this.txtcomboPrice.Name = "txtcomboPrice";
            this.txtcomboPrice.Size = new System.Drawing.Size(118, 21);
            this.txtcomboPrice.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = " Price:         R";
            // 
            // txtcomboName
            // 
            this.txtcomboName.Location = new System.Drawing.Point(111, 353);
            this.txtcomboName.Name = "txtcomboName";
            this.txtcomboName.Size = new System.Drawing.Size(208, 21);
            this.txtcomboName.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Combo Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Item(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Available Product(s):";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(0, 82);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(284, 225);
            this.dgvProducts.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.groupBox3.Controls.Add(this.addEmployee);
            this.groupBox3.Controls.Add(this.btnUpdateCombo);
            this.groupBox3.Controls.Add(this.txtcomboPrice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtcomboName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSelecteditems);
            this.groupBox3.Controls.Add(this.dgvProducts);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(0, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 472);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Combo Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtSelecteditems
            // 
            this.txtSelecteditems.Location = new System.Drawing.Point(328, 82);
            this.txtSelecteditems.Multiline = true;
            this.txtSelecteditems.Name = "txtSelecteditems";
            this.txtSelecteditems.Size = new System.Drawing.Size(228, 225);
            this.txtSelecteditems.TabIndex = 1;
            // 
            // btnFindCombo
            // 
            this.btnFindCombo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnFindCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCombo.Image")));
            this.btnFindCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCombo.Location = new System.Drawing.Point(440, 66);
            this.btnFindCombo.Name = "btnFindCombo";
            this.btnFindCombo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnFindCombo.Size = new System.Drawing.Size(85, 28);
            this.btnFindCombo.TabIndex = 20;
            this.btnFindCombo.Text = "Search";
            this.btnFindCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindCombo.UseVisualStyleBackColor = true;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(99, 46);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(270, 20);
            this.txtSearchName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Combo Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Detail(s)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 1);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 33);
            this.label14.TabIndex = 1;
            this.label14.Text = "Combo ";
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
            this.panel2.Size = new System.Drawing.Size(612, 67);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFindCombo);
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 104);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Details(s)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnUpdateCombo
            // 
            this.btnUpdateCombo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCombo.Image")));
            this.btnUpdateCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCombo.Location = new System.Drawing.Point(394, 421);
            this.btnUpdateCombo.Name = "btnUpdateCombo";
            this.btnUpdateCombo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnUpdateCombo.Size = new System.Drawing.Size(70, 28);
            this.btnUpdateCombo.TabIndex = 57;
            this.btnUpdateCombo.Text = "Save";
            this.btnUpdateCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCombo.UseVisualStyleBackColor = true;
            // 
            // addEmployee
            // 
            this.addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee.Image = ((System.Drawing.Image)(resources.GetObject("addEmployee.Image")));
            this.addEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee.Location = new System.Drawing.Point(480, 421);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addEmployee.Size = new System.Drawing.Size(76, 28);
            this.addEmployee.TabIndex = 58;
            this.addEmployee.Text = "Delete";
            this.addEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addEmployee.UseVisualStyleBackColor = true;
            // 
            // frmComboMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 652);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmComboMaintain";
            this.Text = "Maintain Combo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtcomboPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcomboName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSelecteditems;
        private System.Windows.Forms.Button btnFindCombo;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateCombo;
        private System.Windows.Forms.Button addEmployee;
    }
}