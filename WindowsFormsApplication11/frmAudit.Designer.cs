namespace WindowsFormsApplication11
{
    partial class frmAudit
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
            this.dgvAuditList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAuditDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblState = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeachAudit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.auditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditList
            // 
            this.dgvAuditList.AutoGenerateColumns = false;
            this.dgvAuditList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAuditList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.transactionNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5});
            this.dgvAuditList.DataSource = this.auditBindingSource2;
            this.dgvAuditList.Location = new System.Drawing.Point(18, 41);
            this.dgvAuditList.Name = "dgvAuditList";
            this.dgvAuditList.RowTemplate.Height = 24;
            this.dgvAuditList.Size = new System.Drawing.Size(1091, 535);
            this.dgvAuditList.TabIndex = 0;
            this.dgvAuditList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditList_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvAuditList);
            this.groupBox1.Location = new System.Drawing.Point(23, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 588);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAuditDetails);
            this.groupBox2.Location = new System.Drawing.Point(1155, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 588);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AuditDetails";
            // 
            // dgvAuditDetails
            // 
            this.dgvAuditDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAuditDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvAuditDetails.Location = new System.Drawing.Point(22, 42);
            this.dgvAuditDetails.Name = "dgvAuditDetails";
            this.dgvAuditDetails.RowTemplate.Height = 24;
            this.dgvAuditDetails.Size = new System.Drawing.Size(303, 534);
            this.dgvAuditDetails.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ItemName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ItemQuantity";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select audit to view more details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1263, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Export To Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 649);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1451, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(732, 680);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(110, 17);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "Processing...0%";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Audit:";
            // 
            // txtSeachAudit
            // 
            this.txtSeachAudit.Location = new System.Drawing.Point(288, 13);
            this.txtSeachAudit.Name = "txtSeachAudit";
            this.txtSeachAudit.Size = new System.Drawing.Size(165, 22);
            this.txtSeachAudit.TabIndex = 7;
            this.txtSeachAudit.TextChanged += new System.EventHandler(this.txtSeachAudit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Date:";
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(619, 13);
            this.dtDate.Name = "dtDate";
            this.dtDate.ShowUpDown = true;
            this.dtDate.Size = new System.Drawing.Size(97, 22);
            this.dtDate.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Audit_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Audit_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Audit_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Audit_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Audit_Table";
            this.dataGridViewTextBoxColumn3.HeaderText = "Audit_Table";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Audit_Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Audit_Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // transactionNumberDataGridViewTextBoxColumn
            // 
            this.transactionNumberDataGridViewTextBoxColumn.DataPropertyName = "transactionNumber";
            this.transactionNumberDataGridViewTextBoxColumn.HeaderText = "transactionNumber";
            this.transactionNumberDataGridViewTextBoxColumn.Name = "transactionNumberDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "auditDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "auditDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // auditBindingSource2
            // 
            this.auditBindingSource2.DataSource = typeof(WindowsFormsApplication11.Audit);
            // 
            // auditBindingSource
            // 
            this.auditBindingSource.DataSource = typeof(WindowsFormsApplication11.Audit);
            // 
            // auditBindingSource1
            // 
            this.auditBindingSource1.DataSource = typeof(WindowsFormsApplication11.Audit);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1347, 680);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1506, 706);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeachAudit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAudit";
            this.Text = "frmAudit";
            this.Load += new System.EventHandler(this.frmAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAuditDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblState;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditTableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource auditBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource auditBindingSource2;
        private System.Windows.Forms.BindingSource auditBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeachAudit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button button2;
    }
}