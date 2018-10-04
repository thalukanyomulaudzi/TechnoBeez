namespace WindowsFormsApplication11
{
    partial class frmReports
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
            this.btnCheckInRep = new System.Windows.Forms.Button();
            this.btnCustRep = new System.Windows.Forms.Button();
            this.btnWrteOffrep = new System.Windows.Forms.Button();
            this.btnCheckOutRep = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnStockOnHandRep = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckInRep
            // 
            this.btnCheckInRep.Location = new System.Drawing.Point(55, 37);
            this.btnCheckInRep.Name = "btnCheckInRep";
            this.btnCheckInRep.Size = new System.Drawing.Size(163, 31);
            this.btnCheckInRep.TabIndex = 0;
            this.btnCheckInRep.Text = "CheckIn(s) Report";
            this.btnCheckInRep.UseVisualStyleBackColor = true;
            this.btnCheckInRep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustRep
            // 
            this.btnCustRep.Location = new System.Drawing.Point(55, 180);
            this.btnCustRep.Name = "btnCustRep";
            this.btnCustRep.Size = new System.Drawing.Size(163, 31);
            this.btnCustRep.TabIndex = 2;
            this.btnCustRep.Text = "Customers";
            this.btnCustRep.UseVisualStyleBackColor = true;
            this.btnCustRep.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnWrteOffrep
            // 
            this.btnWrteOffrep.Location = new System.Drawing.Point(55, 132);
            this.btnWrteOffrep.Name = "btnWrteOffrep";
            this.btnWrteOffrep.Size = new System.Drawing.Size(163, 31);
            this.btnWrteOffrep.TabIndex = 4;
            this.btnWrteOffrep.Text = "WriteOff(s) Report";
            this.btnWrteOffrep.UseVisualStyleBackColor = true;
            this.btnWrteOffrep.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCheckOutRep
            // 
            this.btnCheckOutRep.Location = new System.Drawing.Point(55, 83);
            this.btnCheckOutRep.Name = "btnCheckOutRep";
            this.btnCheckOutRep.Size = new System.Drawing.Size(163, 31);
            this.btnCheckOutRep.TabIndex = 5;
            this.btnCheckOutRep.Text = "CheckOut(s) Report";
            this.btnCheckOutRep.UseVisualStyleBackColor = true;
            this.btnCheckOutRep.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(376, 37);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(606, 222);
            this.dgvReports.TabIndex = 6;
            // 
            // btnStockOnHandRep
            // 
            this.btnStockOnHandRep.Location = new System.Drawing.Point(55, 228);
            this.btnStockOnHandRep.Name = "btnStockOnHandRep";
            this.btnStockOnHandRep.Size = new System.Drawing.Size(163, 31);
            this.btnStockOnHandRep.TabIndex = 7;
            this.btnStockOnHandRep.Text = "Stock On Hand";
            this.btnStockOnHandRep.UseVisualStyleBackColor = true;
            this.btnStockOnHandRep.Click += new System.EventHandler(this.btnStockOnHandRep_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate And Export To PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Location = new System.Drawing.Point(55, 276);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSalesReport.Size = new System.Drawing.Size(163, 31);
            this.btnSalesReport.TabIndex = 14;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 350);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStockOnHandRep);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnCheckOutRep);
            this.Controls.Add(this.btnWrteOffrep);
            this.Controls.Add(this.btnCustRep);
            this.Controls.Add(this.btnCheckInRep);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckInRep;
        private System.Windows.Forms.Button btnCustRep;
        private System.Windows.Forms.Button btnWrteOffrep;
        private System.Windows.Forms.Button btnCheckOutRep;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnStockOnHandRep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalesReport;
    }
}