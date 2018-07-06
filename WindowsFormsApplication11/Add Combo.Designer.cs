namespace WindowsFormsApplication11
{
    partial class Add_Combo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Combo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchCombo = new System.Windows.Forms.Button();
            this.btnAddCombo = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnMaintainCombo = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(545, 67);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 1);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 33);
            this.label14.TabIndex = 1;
            this.label14.Text = "COMBO";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Combo(s)";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(171)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.panel4);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 321);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(545, 61);
            this.panel14.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaintainCombo);
            this.panel4.Controls.Add(this.btnAddCombo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(229, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 60);
            this.panel4.TabIndex = 11;
            // 
            // btnSearchCombo
            // 
            this.btnSearchCombo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSearchCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCombo.Image")));
            this.btnSearchCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCombo.Location = new System.Drawing.Point(19, 17);
            this.btnSearchCombo.Name = "btnSearchCombo";
            this.btnSearchCombo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSearchCombo.Size = new System.Drawing.Size(85, 28);
            this.btnSearchCombo.TabIndex = 8;
            this.btnSearchCombo.Text = "Search";
            this.btnSearchCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchCombo.UseVisualStyleBackColor = true;
            // 
            // btnAddCombo
            // 
            this.btnAddCombo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCombo.Image")));
            this.btnAddCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCombo.Location = new System.Drawing.Point(12, 17);
            this.btnAddCombo.Name = "btnAddCombo";
            this.btnAddCombo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAddCombo.Size = new System.Drawing.Size(84, 28);
            this.btnAddCombo.TabIndex = 10;
            this.btnAddCombo.Text = "Add";
            this.btnAddCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCombo.UseVisualStyleBackColor = true;
            this.btnAddCombo.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnSearchCombo);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(438, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(107, 60);
            this.panel17.TabIndex = 8;
            // 
            // btnMaintainCombo
            // 
            this.btnMaintainCombo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMaintainCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintainCombo.Image")));
            this.btnMaintainCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintainCombo.Location = new System.Drawing.Point(121, 17);
            this.btnMaintainCombo.Name = "btnMaintainCombo";
            this.btnMaintainCombo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnMaintainCombo.Size = new System.Drawing.Size(82, 28);
            this.btnMaintainCombo.TabIndex = 9;
            this.btnMaintainCombo.Text = "Maintain";
            this.btnMaintainCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaintainCombo.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 60);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(545, 1);
            this.panel15.TabIndex = 0;
            // 
            // Add_Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 382);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "Add_Combo";
            this.Text = "Combo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMaintainCombo;
        private System.Windows.Forms.Button btnAddCombo;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnSearchCombo;
        private System.Windows.Forms.Panel panel15;
    }
}