namespace WindowsFormsApplication11
{
    partial class Write_Off_stock_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Write_Off_stock_Item));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.txtStockItemNamee = new System.Windows.Forms.TextBox();
            this.txtStockItemID = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStockDescription = new System.Windows.Forms.Label();
            this.dgvWriteOffHistory = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriteOffHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 74);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1168, 1);
            this.panel15.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(18, 21);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(116, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(190, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(174, 198);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(198, 22);
            this.txtReason.TabIndex = 81;
            // 
            // s
            // 
            this.s.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(19, 201);
            this.s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(121, 17);
            this.s.TabIndex = 80;
            this.s.Text = "Write Off Reason:";
            // 
            // txtStockItemNamee
            // 
            this.txtStockItemNamee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemNamee.Location = new System.Drawing.Point(174, 108);
            this.txtStockItemNamee.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemNamee.Name = "txtStockItemNamee";
            this.txtStockItemNamee.Size = new System.Drawing.Size(198, 22);
            this.txtStockItemNamee.TabIndex = 79;
            // 
            // txtStockItemID
            // 
            this.txtStockItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemID.Location = new System.Drawing.Point(174, 60);
            this.txtStockItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemID.Name = "txtStockItemID";
            this.txtStockItemID.Size = new System.Drawing.Size(198, 22);
            this.txtStockItemID.TabIndex = 78;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockQuantity.Location = new System.Drawing.Point(174, 156);
            this.txtStockQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(198, 22);
            this.txtStockQuantity.TabIndex = 77;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnCancel);
            this.panel17.Controls.Add(this.button1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(836, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(332, 74);
            this.panel17.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 423);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1168, 75);
            this.panel14.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(339, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "Write Off Stock Item";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 17);
            this.lblName.TabIndex = 70;
            this.lblName.Text = "Stock Item ID:";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(19, 159);
            this.lblStockQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(134, 17);
            this.lblStockQuantity.TabIndex = 76;
            this.lblStockQuantity.Text = "Stock Item Quantity:";
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
            this.panel2.Size = new System.Drawing.Size(1168, 70);
            this.panel2.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.s);
            this.groupBox1.Controls.Add(this.txtStockItemNamee);
            this.groupBox1.Controls.Add(this.txtStockItemID);
            this.groupBox1.Controls.Add(this.txtStockQuantity);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblStockQuantity);
            this.groupBox1.Controls.Add(this.lblStockDescription);
            this.groupBox1.Location = new System.Drawing.Point(33, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 257);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Item Details";
            // 
            // lblStockDescription
            // 
            this.lblStockDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockDescription.AutoSize = true;
            this.lblStockDescription.Location = new System.Drawing.Point(17, 116);
            this.lblStockDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockDescription.Name = "lblStockDescription";
            this.lblStockDescription.Size = new System.Drawing.Size(118, 17);
            this.lblStockDescription.TabIndex = 74;
            this.lblStockDescription.Text = "Stock Item Name:";
            // 
            // dgvWriteOffHistory
            // 
            this.dgvWriteOffHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWriteOffHistory.Location = new System.Drawing.Point(19, 21);
            this.dgvWriteOffHistory.Name = "dgvWriteOffHistory";
            this.dgvWriteOffHistory.RowTemplate.Height = 24;
            this.dgvWriteOffHistory.Size = new System.Drawing.Size(546, 225);
            this.dgvWriteOffHistory.TabIndex = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvWriteOffHistory);
            this.groupBox2.Location = new System.Drawing.Point(517, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 257);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write Off History";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 498);
            this.panel3.TabIndex = 34;
            // 
            // Write_Off_stock_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 498);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Write_Off_stock_Item";
            this.Text = "Write_Off_stock_Item";
            this.Load += new System.EventHandler(this.Write_Off_stock_Item_Load);
            this.panel17.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriteOffHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox txtStockItemNamee;
        private System.Windows.Forms.TextBox txtStockItemID;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStockDescription;
        private System.Windows.Forms.DataGridView dgvWriteOffHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
    }
}