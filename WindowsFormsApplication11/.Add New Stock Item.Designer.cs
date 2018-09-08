namespace WindowsFormsApplication11
{
    partial class _
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cmbStockItemType = new System.Windows.Forms.ComboBox();
            this.txtStockItemPrice = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockItemnName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtStockItemDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblStockDescription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel17.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 60);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(600, 1);
            this.panel15.TabIndex = 0;
            // 
            // cmbStockItemType
            // 
            this.cmbStockItemType.FormattingEnabled = true;
            this.cmbStockItemType.Items.AddRange(new object[] {
            "Ingredient",
            "Product"});
            this.cmbStockItemType.Location = new System.Drawing.Point(134, 115);
            this.cmbStockItemType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStockItemType.Name = "cmbStockItemType";
            this.cmbStockItemType.Size = new System.Drawing.Size(133, 21);
            this.cmbStockItemType.TabIndex = 97;
            // 
            // txtStockItemPrice
            // 
            this.txtStockItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemPrice.Location = new System.Drawing.Point(134, 150);
            this.txtStockItemPrice.Name = "txtStockItemPrice";
            this.txtStockItemPrice.Size = new System.Drawing.Size(133, 20);
            this.txtStockItemPrice.TabIndex = 94;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(17, 46);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(92, 13);
            this.lblCostPrice.TabIndex = 84;
            this.lblCostPrice.Text = "Stock Item Name:";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(19, 120);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(88, 13);
            this.lblStockQuantity.TabIndex = 88;
            this.lblStockQuantity.Text = "Stock Item Type:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Stock Item Cost Price:";
            // 
            // txtStockItemnName
            // 
            this.txtStockItemnName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemnName.Location = new System.Drawing.Point(134, 43);
            this.txtStockItemnName.Name = "txtStockItemnName";
            this.txtStockItemnName.Size = new System.Drawing.Size(133, 20);
            this.txtStockItemnName.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(103, 17);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(413, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(187, 60);
            this.panel17.TabIndex = 8;
            // 
            // txtStockItemDescription
            // 
            this.txtStockItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemDescription.Location = new System.Drawing.Point(134, 81);
            this.txtStockItemDescription.Name = "txtStockItemDescription";
            this.txtStockItemDescription.Size = new System.Drawing.Size(133, 20);
            this.txtStockItemDescription.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 31);
            this.label14.TabIndex = 1;
            this.label14.Text = "Add New Stock Item";
            // 
            // lblStockDescription
            // 
            this.lblStockDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockDescription.AutoSize = true;
            this.lblStockDescription.Location = new System.Drawing.Point(17, 85);
            this.lblStockDescription.Name = "lblStockDescription";
            this.lblStockDescription.Size = new System.Drawing.Size(117, 13);
            this.lblStockDescription.TabIndex = 86;
            this.lblStockDescription.Text = "Stock Item Description:";
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
            this.panel2.Size = new System.Drawing.Size(600, 57);
            this.panel2.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStockItemType);
            this.groupBox1.Controls.Add(this.txtStockItemPrice);
            this.groupBox1.Controls.Add(this.lblCostPrice);
            this.groupBox1.Controls.Add(this.lblStockQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStockItemnName);
            this.groupBox1.Controls.Add(this.txtStockItemDescription);
            this.groupBox1.Controls.Add(this.lblStockDescription);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(344, 216);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Item Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 305);
            this.panel3.TabIndex = 31;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 305);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(600, 61);
            this.panel14.TabIndex = 30;
            // 
            // _
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel14);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "_";
            this.Text = "_";
            this.panel17.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ComboBox cmbStockItemType;
        private System.Windows.Forms.TextBox txtStockItemPrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockItemnName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtStockItemDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblStockDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel14;
    }
}