namespace WindowsFormsApplication11
{
    partial class Check_In_Stock_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_In_Stock_Item));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStockItemNamee = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.txtStockItemID = new System.Windows.Forms.TextBox();
            this.lblStockDescription = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCheckin = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1246, 340);
            this.panel3.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStockItemNamee);
            this.groupBox1.Controls.Add(this.txtStockQuantity);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblStockQuantity);
            this.groupBox1.Controls.Add(this.txtStockItemID);
            this.groupBox1.Controls.Add(this.lblStockDescription);
            this.groupBox1.Location = new System.Drawing.Point(23, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 246);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Item Details";
            // 
            // txtStockItemNamee
            // 
            this.txtStockItemNamee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemNamee.Location = new System.Drawing.Point(174, 107);
            this.txtStockItemNamee.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemNamee.Name = "txtStockItemNamee";
            this.txtStockItemNamee.Size = new System.Drawing.Size(198, 22);
            this.txtStockItemNamee.TabIndex = 73;
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
            // txtStockItemID
            // 
            this.txtStockItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockItemID.Location = new System.Drawing.Point(174, 59);
            this.txtStockItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockItemID.Name = "txtStockItemID";
            this.txtStockItemID.Size = new System.Drawing.Size(198, 22);
            this.txtStockItemID.TabIndex = 71;
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
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.btnCancel);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 410);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1246, 75);
            this.panel14.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(13, 19);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(107, 34);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnCheckIn);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(997, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(249, 74);
            this.panel17.TabIndex = 8;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckIn.Image")));
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.Location = new System.Drawing.Point(136, 19);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCheckIn.Size = new System.Drawing.Size(100, 34);
            this.btnCheckIn.TabIndex = 9;
            this.btnCheckIn.Text = "Submit";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 74);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1246, 1);
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
            this.panel2.Size = new System.Drawing.Size(1246, 70);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 1);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(345, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "Check In Stock Item";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCheckin);
            this.groupBox2.Location = new System.Drawing.Point(637, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 246);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check In History";
            // 
            // dgvCheckin
            // 
            this.dgvCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckin.Location = new System.Drawing.Point(23, 21);
            this.dgvCheckin.Name = "dgvCheckin";
            this.dgvCheckin.RowTemplate.Height = 24;
            this.dgvCheckin.Size = new System.Drawing.Size(555, 219);
            this.dgvCheckin.TabIndex = 0;
            // 
            // Check_In_Stock_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel2);
            this.Name = "Check_In_Stock_Item";
            this.Text = "Check_In_Stock_Item";
            this.Load += new System.EventHandler(this.Check_In_Stock_Item_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStockItemNamee;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.TextBox txtStockItemID;
        private System.Windows.Forms.Label lblStockDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCheckin;
    }
}