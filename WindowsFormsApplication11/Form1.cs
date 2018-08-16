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
       
        Button navButton;
        MmasweEntities5 db = new MmasweEntities5();
        
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
            MenuPan.BringToFront();

            //dgvMenu.Show();
            //dgvDataGrid.Columns[0].HeaderCell.Value = "Menu ID";
            //dgvDataGrid.Columns[1].HeaderCell.Value = "Menu Name";
            //dgvDataGrid.Columns[2].HeaderCell.Value = "Menu Price";
            dgvMenu.MouseClick += new MouseEventHandler(Menu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //EmployeePan.Visible = false;

            
            //CustomerPan.Visible = false;

           
            //SalesPan.Visible = false;

           
            //MenuPan.Visible = false;

            
            //ComboPan.Visible = false;

           
            //StockPan.Visible = false;

           
            //SupplierPan.Visible = false;
        }

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Sales and Ordering";
            if (navButton != quoteBtn)
            {
                navigate(quoteBtn);
            }
            SalesPan.BringToFront();
            //clientPanelActions.BringToFront();
            //dgvDataGrid.Show();
            //dgvDataGrid.Columns[0].HeaderCell.Value = "Sales ID";
            //dgvDataGrid.Columns[1].HeaderCell.Value = "Sale Date";
            //dgvDataGrid.Columns[2].HeaderCell.Value = "Sale Amount";
            dgvSales.MouseClick += new MouseEventHandler(salesClick);

        }




        void myMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            deleteForm deleteF = new deleteForm();

            if (e.ClickedItem.Name.ToString() == "Deleted")
            {
                //deleteF.ShowDialog();
                if (MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //deleteEmployee(index);
                    //  MessageBox.Show("");
                }
            }



            //Stock Management Click Event Handlers
            //
            //-----------------------------------------------------------------------------------------------------//
            if (e.ClickedItem.Name.ToString() == "Maintain")
            {

                Maintain_Stock_Item myform = new Maintain_Stock_Item();
                myform.ShowDialog();
            }

            else if (e.ClickedItem.Name.ToString() == "Check In")
            {

                Check_In_Stock_Item myform = new Check_In_Stock_Item();
                myform.ShowDialog();
            }

            else if (e.ClickedItem.Name.ToString() == "Check Out")
            {

                Check_Out_Stock_Item myform = new Check_Out_Stock_Item();
                myform.ShowDialog();
            }

            else if (e.ClickedItem.Name.ToString() == "Take")
            {

                Take_Stock_Item myform = new Take_Stock_Item();
                myform.ShowDialog();
            }
            else if (e.ClickedItem.Name.ToString() == "Write Off")
            {

                Write_Off_stock_Item myform = new Write_Off_stock_Item();
                myform.ShowDialog();
            }

        }





        /*Employee Grid Mouse Click Func*/

        void employeeClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvEmployee.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvEmployee, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }
        }



        /*Customer Grid Mouse Click Func*/

        void customerClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvCustomer2.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvCustomer2, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }
        }

        /*Sales Grid Mouse Click Func*/

        void salesClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSales.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvSales, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }
        }


        /*Menu Grid Mouse Click Func*/

        void Menu(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvMenu.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvMenu, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }
        }

        /*Combo Grid Mouse Click Func*/

        void comboClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvCombo.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvCombo, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }
        }


        /*Combo Grid Mouse Click Func*/

        void supplierClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvStock.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvStock, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }
        }



        void Stock_mouse_click(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvStock.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Maintain").Name = "Maintain";
                    myMenu.Items.Add("Check In").Name = "Check In";
                    myMenu.Items.Add("Check Out").Name = "Check Out";
                    myMenu.Items.Add("Take").Name = "Take";
                    myMenu.Items.Add("Write Off").Name = "Write Off";


                }

                frmAdd_New_Stock_Item myform = new frmAdd_New_Stock_Item();

                myMenu.Show(dgvStock, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }

        }

        private void dgvDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    
    //private void button11_Click(object sender, EventArgs e)
    //{

    //}



    //Maintain Stock Mouse Right Click
    //Maintain Stock Mouse Right Click-------------------------------------------------------------------//


    //Maintain Stock Mouse Right Click
    //Maintain Stock Mouse Right Click-------------------------------------------------------------------//











    //Stock Management Click Event Handlers
    //
    //-----------------------------------------------------------------------//






    private void button1_Click(object sender, EventArgs e)
    {
        if (navButton == quoteBtn)
        {
           // SalesAndOrdering sales = new SalesAndOrdering();
            //sales.ShowDialog();
            //navigate(quoteBtn);
        }
        if (navButton == btnSuppliers11)
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

            frmAdd_New_Stock_Item addStock = new frmAdd_New_Stock_Item();
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


        dgvCombo.MouseClick += new MouseEventHandler(comboClick);
    }

    private void clientBtn_Click(object sender, EventArgs e)
    {
        header.Text = "Customer";
        if (navButton != clientBtn)
        {
            navigate(clientBtn);
        }

        dgvCustomer2.MouseClick += new MouseEventHandler(customerClick);

    }

    private void inventoryBtn_Click(object sender, EventArgs e)
    {



    }

    private void btnSuppliers11_Click(object sender, EventArgs e)
    {

    }

    private void empBtn_Click(object sender, EventArgs e)
    {

    }

    private void btnorderList_Click(object sender, EventArgs e)
    {
        OrderList f = new OrderList();
        f.ShowDialog();
    }

        private void empBtn_Click_1(object sender, EventArgs e)
        {
            header.Text = "Employee";


            //EmployeePan.Visible = false;


            CustomerPan.Visible = false;


            SalesPan.Visible = false;


            MenuPan.Visible = false;


            ComboPan.Visible = false;


            StockPan.Visible = false;




            EmployeePan.Visible = true;
            EmployeePan.BringToFront();
            if (navButton != empBtn)
            {
                navigate(empBtn);
            }

            var customers = from p in db.Employees
                            select new
                            {
                               ID = p.Employee_ID,
                               NAME = p.Employee_Name,
                               SURNAME = p.Employee_Surname,
                               IDENTITY = p.Employee_Identity_Number,
                               ADRESS = p.Adress,
                               EMAIL = p.Email_Adress,
                               CONTACTNO = p.Contact_Number,
                               NEXTOFKINNAME = p.Next_Of_Kin_Name,
                               NEXTOFKINNUMBER = p.Next_Of_Kin_Contact_Number,
                               GENDERID = p.Gender_ID,
                               USERID = p.User_ID

                            };
            dgvEmployee.DataSource = customers.ToList();
            db.SaveChanges();

            ;
            dgvEmployee.MouseClick += new MouseEventHandler(employeeClick);
        }

        private void clientBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void supplierBtn_Click_1(object sender, EventArgs e)
        {
            header.Text = "Combo";
            if (navButton != supplierBtn)
            {
                navigate(supplierBtn);
            }
            ComboPan.BringToFront();


            dgvCombo.MouseClick += new MouseEventHandler(comboClick);
        }

        private void inventoryBtn_Click_1(object sender, EventArgs e)
        {
            header.Text = "Stock";


            EmployeePan.Visible = false;
         

            CustomerPan.Visible = false;


            SalesPan.Visible = false;


            MenuPan.Visible = false;


            ComboPan.Visible = false;


            //StockPan.Visible = false;


            SupplierPan.Visible = false;

            StockPan.Visible = true;
            StockPan.BringToFront();
            //Form2 fr = new Form2();
            //fr.ShowDialog();
            if (navButton != inventoryBtn)
            {
                navigate(inventoryBtn);
            }

            var customers = from p in db.Stock_Item
                            select new
                            {
                                CustomerId = p.Stock_ID,
                                ContactName = p.Stock_Item_Name,
                                Quantity = p.Stock_Item_Quantity,
                                Description = p.Stock_Item_Description,
                                StockTypeId = p.Stock_Type_ID,
                                StockPriceId = p.Stock_Price_ID,
                                //StockWrietOffId = p.Write_Off_ID

                            };
            dgvStock.DataSource = customers.ToList();
            db.SaveChanges();

            dgvStock.MouseClick += new MouseEventHandler(Stock_mouse_click);
        }

        private void btnSuppliers11_Click_1(object sender, EventArgs e)
        {
            header.Text = "Suppliers";
            if (navButton != btnSuppliers11)
            {
                navigate(btnSuppliers11); 
            }
            SupplierPan.BringToFront();
            
          
            dgvSupplier.MouseClick += new MouseEventHandler(supplierClick);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void SupplierPan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


