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
       // SalesAndOrdering parent;
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
            header.Text = "Menu";
            if (navButton != jobOBtn)
            {
                navigate(jobOBtn);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Menu ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Menu Name";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Menu Price";
            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);
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
                //deleteF.ShowDialog();
                if (MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //deleteEmployee(index);
                  //  MessageBox.Show("");
                }
            }
            
            MessageBox.Show(e.ClickedItem.Name.ToString());
        }
        private void dgvDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (navButton == quoteBtn)
            {
                SalesAndOrdering sales = new SalesAndOrdering();
                sales.ShowDialog();
                //navigate(quoteBtn);
            }
            if(navButton==btnSuppliers11)
            {
                SupplierForm supplier = new SupplierForm();
                supplier.ShowDialog();
            }
            if (navButton == clientBtn)
            {
                frmAddCustomer customer = new frmAddCustomer();
                customer.ShowDialog();
            }
            if (navButton == supplierBtn)
            {

                frmAddCombo combo = new frmAddCombo();
                combo.ShowDialog();
            }

            if (navButton == jobOBtn)
            {

                Menu_And_Combo menu = new Menu_And_Combo();
                menu.ShowDialog();
            }
            if (navButton == inventoryBtn)
            {
                Add_New_Stock_Item addStock = new Add_New_Stock_Item();
                addStock.ShowDialog();
                
            }
            if (navButton == empBtn)
            {
                Add_Employee employee = new Add_Employee();
                employee.ShowDialog();
            }
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Combo";
            if (navButton != supplierBtn)
            {
                navigate(supplierBtn);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Combo ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Combo Name";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Combo Price ";

            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Customer";
            if (navButton != clientBtn)
            {
                navigate(clientBtn);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Customer ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Customer Name";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Customer Phone Number";
            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Stock";
            if (navButton != inventoryBtn)
            {
                navigate(inventoryBtn);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Stock ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Stock Name";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Stock Description";
            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);
           
        }

        private void btnSuppliers11_Click(object sender, EventArgs e)
        {
            header.Text = "Suppliers";
            if (navButton != btnSuppliers11)
            {
                navigate(btnSuppliers11);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Supplier ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Supplier Name";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Supplier Email";

            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Employees";
            if (navButton != empBtn)
            {
                navigate(empBtn);
            }
            //clientPanel.BringToFront();
            //clientPanelActions.BringToFront();
            dgvDataGrid.Show();
            dgvDataGrid.Columns[0].HeaderCell.Value = "Employee ID";
            dgvDataGrid.Columns[1].HeaderCell.Value = "Employee Name";
            dgvDataGrid.Columns[2].HeaderCell.Value = "Employee Email";

            dgvDataGrid.MouseClick += new MouseEventHandler(mouse_click);
        }
    }
}
