namespace WindowsFormsApplication11
{
    partial class OrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.header = new System.Windows.Forms.Label();
            this.jobQuotePanelActions = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvReceivedOrder = new System.Windows.Forms.DataGridView();
            this.dgvPlacedOrder = new System.Windows.Forms.DataGridView();
            this.supplierResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobQuotePanelActions.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(101, 33);
            this.header.TabIndex = 1;
            this.header.Text = "Orders";
            // 
            // jobQuotePanelActions
            // 
            this.jobQuotePanelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.jobQuotePanelActions.Controls.Add(this.button18);
            this.jobQuotePanelActions.Controls.Add(this.label3);
            this.jobQuotePanelActions.Controls.Add(this.panel22);
            this.jobQuotePanelActions.Controls.Add(this.comboBox3);
            this.jobQuotePanelActions.Controls.Add(this.label8);
            this.jobQuotePanelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobQuotePanelActions.Location = new System.Drawing.Point(0, 70);
            this.jobQuotePanelActions.Name = "jobQuotePanelActions";
            this.jobQuotePanelActions.Size = new System.Drawing.Size(633, 60);
            this.jobQuotePanelActions.TabIndex = 28;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 70);
            this.panel2.TabIndex = 27;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(545, 17);
            this.button18.Name = "button18";
            this.button18.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button18.Size = new System.Drawing.Size(76, 28);
            this.button18.TabIndex = 11;
            this.button18.Text = "Order";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 221);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPlacedOrder);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Placed Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 189);
            this.dataGridView1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvReceivedOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Received Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvReceivedOrder
            // 
            this.dgvReceivedOrder.AllowUserToAddRows = false;
            this.dgvReceivedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivedOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceivedOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvReceivedOrder.Name = "dgvReceivedOrder";
            this.dgvReceivedOrder.Size = new System.Drawing.Size(619, 189);
            this.dgvReceivedOrder.TabIndex = 17;
            // 
            // dgvPlacedOrder
            // 
            this.dgvPlacedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacedOrder.Location = new System.Drawing.Point(6, 6);
            this.dgvPlacedOrder.Name = "dgvPlacedOrder";
            this.dgvPlacedOrder.Size = new System.Drawing.Size(613, 175);
            this.dgvPlacedOrder.TabIndex = 18;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 351);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.jobQuotePanelActions);
            this.Controls.Add(this.panel2);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.jobQuotePanelActions.ResumeLayout(false);
            this.jobQuotePanelActions.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientResultBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPlacedOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvReceivedOrder;
    }
}