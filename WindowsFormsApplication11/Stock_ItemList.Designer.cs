namespace WindowsFormsApplication11
{
    partial class Stock_ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_ItemList));
            this.header = new System.Windows.Forms.Label();
            this.jobQuotePanelActions = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplierResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.jobQuotePanelActions.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(16, 23);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(201, 40);
            this.header.TabIndex = 1;
            this.header.Text = "Stock Items";
            // 
            // jobQuotePanelActions
            // 
            this.jobQuotePanelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.jobQuotePanelActions.Controls.Add(this.label3);
            this.jobQuotePanelActions.Controls.Add(this.panel22);
            this.jobQuotePanelActions.Controls.Add(this.comboBox3);
            this.jobQuotePanelActions.Controls.Add(this.label8);
            this.jobQuotePanelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobQuotePanelActions.Location = new System.Drawing.Point(0, 94);
            this.jobQuotePanelActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jobQuotePanelActions.Name = "jobQuotePanelActions";
            this.jobQuotePanelActions.Size = new System.Drawing.Size(951, 74);
            this.jobQuotePanelActions.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search:";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.Controls.Add(this.textBox3);
            this.panel22.Controls.Add(this.button11);
            this.panel22.Location = new System.Drawing.Point(113, 25);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(216, 26);
            this.panel22.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(9, 5);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 15);
            this.textBox3.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Transparent;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(177, -1);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 30);
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
            this.comboBox3.Location = new System.Drawing.Point(439, 25);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(207, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(360, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sort by:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 94);
            this.panel2.TabIndex = 27;
            // 
            // dgvStockList
            // 
            this.dgvStockList.AutoGenerateColumns = false;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.DataSource = this.supplierResultBindingSource;
            this.dgvStockList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockList.Location = new System.Drawing.Point(0, 168);
            this.dgvStockList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.Size = new System.Drawing.Size(951, 327);
            this.dgvStockList.TabIndex = 29;
            // 
            // Stock_ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 495);
            this.Controls.Add(this.dgvStockList);
            this.Controls.Add(this.jobQuotePanelActions);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Stock_ItemList";
            this.Text = "Stock_ItemList";
            this.jobQuotePanelActions.ResumeLayout(false);
            this.jobQuotePanelActions.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource supplierResultBindingSource;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel jobQuotePanelActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource inventoryResultBindingSource;
        private System.Windows.Forms.BindingSource clientResultBindingSource;
        private System.Windows.Forms.DataGridView dgvStockList;
    }
}