using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    
    public partial class Form1 : Form
    {
        SalesAndOrdering parent;
        Button navButton;


        public Form1()
        {
            InitializeComponent();
        }
        private void navigate(Button b)
        {
            if (navButton != null)
            {
                navButton.BackColor = Color.CornflowerBlue;
                navButton.TextAlign = ContentAlignment.MiddleLeft;
            }

            navButton = b;
            navButton.BackColor = Color.FromArgb(80, 120, 191);
            navButton.FlatAppearance.MouseOverBackColor = navButton.BackColor;
            navButton.TextAlign = ContentAlignment.MiddleRight;
        }
        private void jobOBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDataGrid.Hide();
        }

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Sales and Ordering";
            if (navButton != quoteBtn)
            {
                navigate(quoteBtn);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Sales ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Sale Date";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Sale Amount";
            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);

        }
        void mouse_click(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvDataGrid.HitTest(e.X, e.Y).RowIndex;
                if(position_xy__row>=0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvDataGrid, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                
            }
        }

        void myMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            deleteForm deleteF = new deleteForm();

            if(e.ClickedItem.Name.ToString() == "Deleted")
            {
                deleteF.ShowDialog();
            }
            
            MessageBox.Show(e.ClickedItem.Name.ToString());
        }
        private void dgvDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesAndOrdering sales = new SalesAndOrdering();
            sales.ShowDialog();
               
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Suppliers";
            if (navButton != supplierBtn)
            {
                navigate(supplierBtn);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Supplier ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Supplier Name";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Supplier Email";

            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);
        }
    }
}
