namespace WindowsFormsApplication11
{
    partial class StockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOrder));
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStockSelect = new System.Windows.Forms.Button();
            this.txtSelectStock = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSupplierSelect = new System.Windows.Forms.Button();
            this.txtSelectSupplier = new System.Windows.Forms.TextBox();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(118, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnOrder.Size = new System.Drawing.Size(70, 34);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnOrder);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(180, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(200, 39);
            this.panel17.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 275);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(380, 40);
            this.panel14.TabIndex = 18;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 39);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(380, 1);
            this.panel15.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(380, 57);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 1);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 33);
            this.label14.TabIndex = 1;
            this.label14.Text = "Order Stock";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOrderQuantity);
            this.groupBox3.Location = new System.Drawing.Point(12, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 63);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantity";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(17, 24);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(142, 20);
            this.txtOrderQuantity.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStockSelect);
            this.groupBox2.Controls.Add(this.txtSelectStock);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 68);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // btnStockSelect
            // 
            this.btnStockSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockSelect.Location = new System.Drawing.Point(230, 22);
            this.btnStockSelect.Name = "btnStockSelect";
            this.btnStockSelect.Size = new System.Drawing.Size(110, 23);
            this.btnStockSelect.TabIndex = 6;
            this.btnStockSelect.Text = "Select Stock";
            this.btnStockSelect.UseVisualStyleBackColor = true;
            this.btnStockSelect.Click += new System.EventHandler(this.btnStockSelect_Click);
            // 
            // txtSelectStock
            // 
            this.txtSelectStock.Location = new System.Drawing.Point(17, 24);
            this.txtSelectStock.Name = "txtSelectStock";
            this.txtSelectStock.ReadOnly = true;
            this.txtSelectStock.Size = new System.Drawing.Size(201, 20);
            this.txtSelectStock.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupplierSelect);
            this.groupBox1.Controls.Add(this.txtSelectSupplier);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 63);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // btnSupplierSelect
            // 
            this.btnSupplierSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierSelect.Location = new System.Drawing.Point(231, 22);
            this.btnSupplierSelect.Name = "btnSupplierSelect";
            this.btnSupplierSelect.Size = new System.Drawing.Size(110, 23);
            this.btnSupplierSelect.TabIndex = 6;
            this.btnSupplierSelect.Text = "Select Supplier";
            this.btnSupplierSelect.UseVisualStyleBackColor = true;
            this.btnSupplierSelect.Click += new System.EventHandler(this.btnSupplierSelect_Click);
            // 
            // txtSelectSupplier
            // 
            this.txtSelectSupplier.Location = new System.Drawing.Point(18, 24);
            this.txtSelectSupplier.Name = "txtSelectSupplier";
            this.txtSelectSupplier.ReadOnly = true;
            this.txtSelectSupplier.Size = new System.Drawing.Size(201, 20);
            this.txtSelectSupplier.TabIndex = 5;
            // 
            // StockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 315);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel2);
            this.Name = "StockOrder";
            this.Text = "StockOrder";
            
            this.panel17.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeTypeBindingSource2;
        private System.Windows.Forms.BindingSource genderBindingSource1;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource1;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStockSelect;
        private System.Windows.Forms.TextBox txtSelectStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSupplierSelect;
        private System.Windows.Forms.TextBox txtSelectSupplier;
    }
}