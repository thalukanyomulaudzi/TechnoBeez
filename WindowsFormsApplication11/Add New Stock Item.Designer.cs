namespace WindowsFormsApplication11
{
    partial class Add_New_Stock_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Stock_Item));
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtStockItemName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStockType = new System.Windows.Forms.ComboBox();
            this.txtStockItemPrice = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockItemnName = new System.Windows.Forms.TextBox();
            this.txtStockItemDescription = new System.Windows.Forms.TextBox();
            this.lblStockDescription = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(266, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "Add Stock Item";
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
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 74);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(800, 1);
            this.panel15.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(17, 21);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button7.Size = new System.Drawing.Size(85, 34);
            this.button7.TabIndex = 9;
            this.button7.Text = "Save";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button7);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(676, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(124, 74);
            this.panel17.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 375);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(800, 75);
            this.panel14.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(213, 45);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(107, 22);
            this.textBox4.TabIndex = 78;
            // 
            // txtStockItemName
            // 
            this.txtStockItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemName.Location = new System.Drawing.Point(184, 41);
            this.txtStockItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemName.Name = "txtStockItemName";
            this.txtStockItemName.Size = new System.Drawing.Size(0, 22);
            this.txtStockItemName.TabIndex = 71;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 17);
            this.lblName.TabIndex = 70;
            this.lblName.Text = "Stock Item Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.txtStockItemName);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStockType);
            this.groupBox1.Controls.Add(this.txtStockItemPrice);
            this.groupBox1.Controls.Add(this.lblCostPrice);
            this.groupBox1.Controls.Add(this.lblStockQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStockItemnName);
            this.groupBox1.Controls.Add(this.txtStockItemDescription);
            this.groupBox1.Controls.Add(this.lblStockDescription);
            this.groupBox1.Location = new System.Drawing.Point(23, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 266);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Item Details";
            // 
            // cmbStockType
            // 
            this.cmbStockType.FormattingEnabled = true;
            this.cmbStockType.Items.AddRange(new object[] {
            "Ingredient",
            "Product"});
            this.cmbStockType.Location = new System.Drawing.Point(178, 139);
            this.cmbStockType.Name = "cmbStockType";
            this.cmbStockType.Size = new System.Drawing.Size(176, 24);
            this.cmbStockType.TabIndex = 95;
            this.cmbStockType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtStockItemPrice
            // 
            this.txtStockItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemPrice.Location = new System.Drawing.Point(180, 186);
            this.txtStockItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemPrice.Name = "txtStockItemPrice";
            this.txtStockItemPrice.Size = new System.Drawing.Size(176, 22);
            this.txtStockItemPrice.TabIndex = 94;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(23, 57);
            this.lblCostPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(118, 17);
            this.lblCostPrice.TabIndex = 84;
            this.lblCostPrice.Text = "Stock Item Name:";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(25, 148);
            this.lblStockQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(113, 17);
            this.lblStockQuantity.TabIndex = 88;
            this.lblStockQuantity.Text = "Stock Item Type:";
            this.lblStockQuantity.Click += new System.EventHandler(this.lblStockQuantity_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Stock Item Cost Price:";
            // 
            // txtStockItemnName
            // 
            this.txtStockItemnName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemnName.Location = new System.Drawing.Point(178, 53);
            this.txtStockItemnName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemnName.Name = "txtStockItemnName";
            this.txtStockItemnName.Size = new System.Drawing.Size(176, 22);
            this.txtStockItemnName.TabIndex = 85;
            // 
            // txtStockItemDescription
            // 
            this.txtStockItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemDescription.Location = new System.Drawing.Point(178, 100);
            this.txtStockItemDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemDescription.Name = "txtStockItemDescription";
            this.txtStockItemDescription.Size = new System.Drawing.Size(176, 22);
            this.txtStockItemDescription.TabIndex = 87;
            // 
            // lblStockDescription
            // 
            this.lblStockDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockDescription.AutoSize = true;
            this.lblStockDescription.Location = new System.Drawing.Point(23, 105);
            this.lblStockDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockDescription.Name = "lblStockDescription";
            this.lblStockDescription.Size = new System.Drawing.Size(152, 17);
            this.lblStockDescription.TabIndex = 86;
            this.lblStockDescription.Text = "Stock Item Description:";
            // 
            // Add_New_Stock_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel3);
            this.Name = "Add_New_Stock_Item";
            this.Text = "Add_New_Stock_Item";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtStockItemName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStockItemPrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockItemnName;
        private System.Windows.Forms.TextBox txtStockItemDescription;
        private System.Windows.Forms.Label lblStockDescription;
        private System.Windows.Forms.ComboBox cmbStockType;
    }
}