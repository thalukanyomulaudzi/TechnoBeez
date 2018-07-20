namespace WindowsFormsApplication11
{
    partial class Customer_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Order));
            this.panel2 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.jobQuotePanelActions = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.deleteJobQuote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.jobQuotePanelActions.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 76);
            this.panel2.TabIndex = 20;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(25, 21);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(236, 33);
            this.header.TabIndex = 1;
            this.header.Text = "Customer Orders";
            // 
            // jobQuotePanelActions
            // 
            this.jobQuotePanelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.jobQuotePanelActions.Controls.Add(this.panel28);
            this.jobQuotePanelActions.Controls.Add(this.label3);
            this.jobQuotePanelActions.Controls.Add(this.panel22);
            this.jobQuotePanelActions.Controls.Add(this.comboBox3);
            this.jobQuotePanelActions.Controls.Add(this.label8);
            this.jobQuotePanelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobQuotePanelActions.Location = new System.Drawing.Point(0, 0);
            this.jobQuotePanelActions.Name = "jobQuotePanelActions";
            this.jobQuotePanelActions.Size = new System.Drawing.Size(648, 60);
            this.jobQuotePanelActions.TabIndex = 21;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.deleteJobQuote);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel28.Location = new System.Drawing.Point(547, 0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(101, 60);
            this.panel28.TabIndex = 9;
            // 
            // deleteJobQuote
            // 
            this.deleteJobQuote.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.deleteJobQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteJobQuote.Image = ((System.Drawing.Image)(resources.GetObject("deleteJobQuote.Image")));
            this.deleteJobQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteJobQuote.Location = new System.Drawing.Point(12, 16);
            this.deleteJobQuote.Name = "deleteJobQuote";
            this.deleteJobQuote.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteJobQuote.Size = new System.Drawing.Size(76, 28);
            this.deleteJobQuote.TabIndex = 9;
            this.deleteJobQuote.Text = "Cancel";
            this.deleteJobQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteJobQuote.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search:";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.Controls.Add(this.textBox3);
            this.panel22.Controls.Add(this.button11);
            this.panel22.Location = new System.Drawing.Point(85, 20);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(162, 21);
            this.panel22.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(7, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 13);
            this.textBox3.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Transparent;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(133, -1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(24, 24);
            this.button11.TabIndex = 1;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Client Number Ascending",
            "Client Name Ascending",
            "Client Number Descending",
            "Client Name Descending"});
            this.comboBox3.Location = new System.Drawing.Point(329, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(156, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(270, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sort by:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(3, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 213);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Order Status";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Order Date";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Customer_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.jobQuotePanelActions);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_Order";
            this.Text = "Customer_Order";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.jobQuotePanelActions.ResumeLayout(false);
            this.jobQuotePanelActions.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel jobQuotePanelActions;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button deleteJobQuote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}