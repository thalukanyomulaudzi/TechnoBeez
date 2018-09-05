﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }
        MmasweEntities9 db = new MmasweEntities9();

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Combo_LookUp form = new Combo_LookUp();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu_Item_LookUp form = new Menu_Item_LookUp();
            form.ShowDialog();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            if (Globals.refresher2 == true)
            {
                List<Globals> something = new List<Globals>();
                something = Globals.ComboItems;
                var items = from obj in something
                            select new
                            {
                                Id = obj.OrderItemId,
                                Name = obj.OrderItemName,
                                Description = obj.OrderItemDescription,
                                ItemQuantity = obj.OrderQuantity,
                                ItemPrice = obj.OrderItemPrice
                            };

                dgvCombo.DataSource = items.ToList();
                dgvCombo.ClearSelection();



                List<Globals> something2 = new List<Globals>();

                something2 = Globals.MenuItems;
                var items2 = from obj2 in something2
                             select new
                             {
                                 Id = obj2.OrderItemId,
                                 Name = obj2.OrderItemName,
                                 Description = obj2.OrderItemDescription,
                                 ItemQuantity = obj2.OrderQuantity,
                                 ItemPrice = obj2.OrderItemPrice
                             };

                dgvMenuItemz.DataSource = items2.ToList();
                dgvMenuItemz.ClearSelection();
                Globals.refresher2 = false;


            }
            Globals.refresher2 = false;


        }

        private void dgvCombo_Click(object sender, EventArgs e)
        {

        }

        private void dgvCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCombo.Rows.Count > 0)
            {


                Globals.SalesComboSelect = dgvCombo.CurrentCell.RowIndex;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int ind = Globals.SalesComboSelect;
            int total = Globals.ComboItems.Count;
            if ((ind > -1) && (ind <= (total - 1)))
            {
                Globals.ComboItems.RemoveRange(ind, 1);

                List<Globals> something = new List<Globals>();
                something = Globals.ComboItems;
                var items = from obj in something
                            select new
                            {
                                Id = obj.OrderItemId,
                                Name = obj.OrderItemName,
                                Description = obj.OrderItemDescription,
                                ItemQuantity = obj.OrderQuantity,
                                ItemPrice = obj.OrderItemPrice
                            };

                dgvCombo.DataSource = items.ToList();
                dgvCombo.ClearSelection();
                MessageBox.Show("Item deleted successfully");
            }

            else
            {
                MessageBox.Show("No items to delete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = Globals.SalesMenuSelect;
            int total = Globals.MenuItems.Count;
            if ((ind > -1) && (ind <= (total - 1)))
            {
                Globals.MenuItems.RemoveRange(ind, 1);

                List<Globals> something = new List<Globals>();
                something = Globals.MenuItems;
                var items = from obj in something
                            select new
                            {
                                Id = obj.OrderItemId,
                                Name = obj.OrderItemName,
                                Description = obj.OrderItemDescription,
                                ItemQuantity = obj.OrderQuantity,
                                ItemPrice = obj.OrderItemPrice
                            };

                dgvMenuItemz.DataSource = items.ToList();
                dgvMenuItemz.ClearSelection();
                MessageBox.Show("Item deleted successfully");
            }

            else
            {
                MessageBox.Show("No items to delete");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Globals shelf = new Globals();

            int id = Convert.ToInt32(txtShelfId.Text);

            Stock_Item item = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
            Stock_Price price = db.Stock_Price.FirstOrDefault(c => c.Stock_Price_ID == id);

            if ((item != null) && (price != null))
            {
                shelf.OrderItemId = id;
                shelf.OrderItemName = item.Stock_Item_Name;
                shelf.OrderItemDescription = item.Stock_Item_Description;

                shelf.OrderItemPrice = price.Stock_Price1;
                shelf.OrderQuantity = Convert.ToInt32(txtQuantity.Text);
                Globals.StockItems.Add(shelf);
            }



            List<Globals> something = new List<Globals>();
            something = Globals.StockItems;
            var items = from obj in something
                        select new
                        {
                            Id = obj.OrderItemId,
                            Name = obj.OrderItemName,
                            Description = obj.OrderItemDescription,
                            ItemQuantity = obj.OrderQuantity,
                            ItemPrice = obj.OrderItemPrice
                        };

            dgvShelfItemz.DataSource = items.ToList();
            dgvShelfItemz.ClearSelection();

        }

        private void dgvMenuItemz_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvShelfItemz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShelfItemz.Rows.Count > 0)
            {


                Globals.SalesComboSelect = dgvShelfItemz.CurrentCell.RowIndex;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            int ind = Globals.SalesShelfSelect;
            int total = Globals.StockItems.Count;
            if ((ind > -1) && (ind <= (total - 1)))
            {
                Globals.StockItems.RemoveRange(ind, 1);

                List<Globals> something = new List<Globals>();
                something = Globals.StockItems;
                var items = from obj in something
                            select new
                            {
                                Id = obj.OrderItemId,
                                Name = obj.OrderItemName,
                                Description = obj.OrderItemDescription,
                                ItemQuantity = obj.OrderQuantity,
                                ItemPrice = obj.OrderItemPrice
                            };

                dgvShelfItemz.DataSource = items.ToList();
                dgvShelfItemz.ClearSelection();
                MessageBox.Show("Item deleted successfully");
            }
        }

        private void dgvMenuItemz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvShelfItemz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Object Declaration---------------------------------//
            Customer_Order order = new Customer_Order();
            Company_Information inf = new Company_Information();
            Customer cust = db.Customers.FirstOrDefault(c=> (c.Customer_Name == txtCustName.Text) && (c.Customer_Adress == txtAdress.Text));
            Customer newCustomer = new Customer();
            Customer_Order_Line orderLine = new Customer_Order_Line();
            //--------------------------------------------------//

            //
            //Vat Calculation------------------------------------//
            if (cust == null)
            {
                newCustomer.Customer_Name = txtCustName.Text;
                newCustomer.Customer_Adress = txtAdress.Text;
                cust = newCustomer;
                db.Customers.Add(cust);
            }
            
            double VatAmount = 0;
            if (Globals.ComboItems.Count != 0)
            {
                foreach (var item in Globals.ComboItems)
                {
                    VatAmount = VatAmount + item.OrderItemPrice * inf.VAT_Percentage;

                }
            }

            if (Globals.ComboItems.Count != 0)
            {
                foreach (var item in Globals.MenuItems)
                {
                    VatAmount = VatAmount + item.OrderItemPrice * inf.VAT_Percentage;

                }
            }

            if (Globals.StockItems.Count != 0)
            {
                foreach (var item in Globals.StockItems)
                {
                    VatAmount = VatAmount + item.OrderItemPrice * inf.VAT_Percentage;

                }
            }

            //-----------------------------------------------------//

            //Order Details insert------------------------------------//
            order.Order_Status = "N";
            order.Order_Date = DateTime.Today;
            order.Sale_Vat_Amount = VatAmount;
            order.Payment_ID = Globals.SalesPaymentID;
            order.Delivery_Status_ID = 2;
            order.Customer_ID = cust.Customer_ID;
            //---------------------------------------------------------//

            //Order Order Order details//----Line----//

            orderLine.Customer_Order_ID = order.Order_ID;
           // orderLine.cus

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            Payment_Type type = db.Payment_Type.FirstOrDefault(c => c.Payment_Description == cmbType.Text);

            type.Payment_Description = cmbType.Text;
            pay.Payment_Amount = Convert.ToDouble(txtAmoutDue.Text);
            pay.Payment_Date = DateTime.Today;
            pay.Payment_Type_ID = type.Payment_Type_ID;

            db.Payments.Add(pay);
            db.SaveChanges();

            Globals.SalesPaymentID = db.Payments.Last().Payment_ID;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
