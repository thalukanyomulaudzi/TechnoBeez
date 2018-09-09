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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            using (Combo_LookUp frm = new Combo_LookUp() { })
            {
                if(frm.ShowDialog() == DialogResult.OK)
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
              

                    lblAmountDue.Text = Convert.ToString(Globals.AmountDue);
                }

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Menu_Item_LookUp frm = new Menu_Item_LookUp() { })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
     

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
                    lblAmountDue.Text = Convert.ToString(Globals.AmountDue);
                }

            }

        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            //Globals.refresher2 = false;
            groupBox1.Visible = false;
            Globals.addCustomer = false;

           
            btnDeliverySaveOrder.Visible = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Globals.refresher2 == 1)
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
                lblAmountDue.Text = Convert.ToString(Globals.AmountDue);

                
            }

            Globals.refresher2 = -1;
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
                Globals.AmountDue = Globals.AmountDue - Globals.ComboItems[ind].OrderItemPrice * Globals.ComboItems[ind].OrderQuantity;
                lblAmountDue.Text = Convert.ToString(Globals.AmountDue);
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

                Globals.AmountDue = Globals.AmountDue - Globals.MenuItems[ind].OrderItemPrice * Globals.MenuItems[ind].OrderQuantity;
                lblAmountDue.Text = Convert.ToString(Globals.AmountDue);
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
            string phrase = txtShelfId.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length < 9) && (isNumeric == true) )
            {
                if (Convert.ToInt32(txtShelfId.Text) > -1)
                {
                    if (numericUpDown1.Text != "0")
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
                            shelf.OrderQuantity = Convert.ToInt32(numericUpDown1.Text);
                            Globals.StockItems.Add(shelf);
                            Globals.AmountDue = Globals.AmountDue + shelf.OrderItemPrice * shelf.OrderQuantity;
                            lblAmountDue.Text = Convert.ToString(Globals.AmountDue);

                        }
                        else
                        {
                            MessageBox.Show("Item not found");
                            return;
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

                    else
                    {
                        MessageBox.Show("Error:Quantity cant be zero");
                    }
                }

                else
                {
                    MessageBox.Show("Error: Item 'ID' can't be less than one");
                }
            }
            else
            {
              
                MessageBox.Show("Error: Item 'ID' not numeric,please anter a numeric value(integer)");
            }
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
                Globals.AmountDue = Globals.AmountDue - Globals.StockItems[ind].OrderItemPrice * Globals.StockItems[ind].OrderQuantity;
                lblAmountDue.Text = Convert.ToString(Globals.AmountDue);
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
            string phrase = txtCash.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length < 9) && (isNumeric == true))
            {
                if (Convert.ToInt32(txtCash.Text) > -1)
                {
                    Payment pay = new Payment();
                    Payment_Type type = db.Payment_Type.FirstOrDefault(c => c.Payment_Description == "Cash");


                    pay.Payment_Amount = Convert.ToDouble(Globals.AmountDue);
                    pay.Payment_Date = DateTime.Today;


                    pay.Payment_Type_ID = type.Payment_Type_ID;



                    db.Payments.Add(pay);
                    db.SaveChanges();
                    Globals.SalesPaymentID = pay.Payment_ID;

                    //int contact = Convert.ToInt32(txtContact.Text);

                    Customer_Order order = new Customer_Order();


                    //Object Declaration---------------------------------//

                    try
                    {

                        Company_Information inf = db.Company_Information.FirstOrDefault(c => c.Company_Info_ID == 1);


                        double VatAmount = 0;
                        if (Globals.ComboItems.Count != 0)
                        {
                            foreach (var item in Globals.ComboItems)
                            {

                                VatAmount = VatAmount + item.OrderItemPrice * inf.VAT_Percentage;

                                MessageBox.Show(Convert.ToString(inf.VAT_Percentage));
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
                        VatAmount = Math.Round(VatAmount, 2);
                        //Order Details insert------------------------------------//
                        order.Order_Status = "N";
                        order.Order_Date = DateTime.Now;
                        order.Sale_Vat_Amount = VatAmount;
                        order.Payment_ID = Globals.SalesPaymentID;
                        order.Delivery_Status_ID = 2;
                        order.OrderNotes = richTextBox1.Text;
                        order.OrderTotal = Globals.AmountDue;
                        order.TotalItems = Globals.ComboItems.Count + Globals.MenuItems.Count + Globals.StockItems.Count;
                        order.Cash = Convert.ToDouble(txtCash.Text);
                        order.Change = Convert.ToDouble(txtCash.Text) - Globals.AmountDue;
                        //order.Customer_ID = cust.Customer_ID;
                        //---------------------------------------------------------//

                        db.Customer_Order.Add(order);
                        db.SaveChanges();


                    }
                    catch (Exception i)
                    {
                        MessageBox.Show(Convert.ToString(i));
                    }
                    for (int i = 0; i < Globals.ComboItems.Count; i++)
                    {
                        Customer_Order_Line orderLine = new Customer_Order_Line();
                        orderLine.Customer_Order_ID = order.Order_ID;
                        orderLine.Combo_Quantity = Globals.ComboItems[i].OrderQuantity;
                        orderLine.Combo_ID = Globals.ComboItems[i].OrderItemId;

                        db.Customer_Order_Line.Add(orderLine);
                        db.SaveChanges();

                    }

                    for (int i = 0; i < Globals.StockItems.Count; i++)
                    {
                        Customer_Order_Line orderLine = new Customer_Order_Line();
                        orderLine.Customer_Order_ID = order.Order_ID;
                        orderLine.Stock_Item_Quantity = Globals.StockItems[i].OrderQuantity;
                        orderLine.Stock_ID = Globals.StockItems[i].OrderItemId;

                        db.Customer_Order_Line.Add(orderLine);
                        db.SaveChanges();
                    }

                    for (int i = 0; i < Globals.MenuItems.Count; i++)
                    {
                        Customer_Order_Line orderLine = new Customer_Order_Line();
                        orderLine.Customer_Order_ID = order.Order_ID;
                        orderLine.Menu_Item_Quantity = Globals.MenuItems[i].OrderQuantity;
                        orderLine.Menu_Item_ID = Globals.MenuItems[i].OrderItemId;

                        db.Customer_Order_Line.Add(orderLine);
                        db.SaveChanges();


                    }

                    Globals.ComboItems.Clear();
                    Globals.MenuItems.Clear();
                    Globals.StockItems.Clear();

                    Globals.refresher = true;

                    Globals.AmountDue = 0;

                    this.Close();
                    MessageBox.Show("Order created successfully");
                }
                else
                {
                    MessageBox.Show("Error: Cash can't be less than one");
                }
            }
            else
            {
                MessageBox.Show("Error: Cash not numeric,please anter a numeric value(integer)");


               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void timez_Tick(object sender, EventArgs e)
        {
            if (Globals.refr == 1)
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
                lblAmountDue.Text = Convert.ToString(Globals.AmountDue);


            }

            Globals.refr = -1;
        }

        private void cbxYes_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxYes.Checked)
            {
                groupBox1.Visible = true;
                btnDeliverySaveOrder.Visible = true;
                btnEatIn.Visible = false;
                lblCash.Visible = false;
                txtCash.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                btnDeliverySaveOrder.Visible = false;
                btnEatIn.Visible = true;

                lblCash.Visible = true;
                txtCash.Visible = true;
            }
        }

        private void cbxNo_CheckedChanged(object sender, EventArgs e)
        {
           
        }
       
        private void btnDeliverySubmit_Click(object sender, EventArgs e)
        {
            string phrase = txtShelfId.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length < 9) && (isNumeric == true))
            {
                if (Convert.ToInt32(txtShelfId.Text) > -1)
                {
                    double VatAmount = 0;
                    DeliveryTable order = new DeliveryTable();
                    order.ItemName = "";
                    order.orderTotal = Globals.AmountDue;

                    int contact = Convert.ToInt32(txtContact.Text);


                    VatAmount = Math.Round(VatAmount, 2);


                    order.orderDatef = DateTime.Today;
                    order.vatTot = Globals.vatAmountDelivery;

                    order.orderNotesf = richTextBox1.Text;
                    order.orderTotal = Globals.AmountDue;
                    order.totalItemsf = Globals.ComboItems.Count + Globals.MenuItems.Count + Globals.StockItems.Count;
                    



                    Customer cust = db.Customers.FirstOrDefault(c => ((c.Customer_Name == txtCustName.Text) && (c.Customer_Contact_Number == contact)));
                    if (cust == null)
                    {
                        MessageBox.Show("Customer does not exist,Add customer");
                        using (frmAddCustomer frm = new frmAddCustomer() { })
                        {
                            if ((frm.ShowDialog() == DialogResult.OK) && (Globals.addCustomer == true))
                            {

                                var some = db.Customers.ToList();
                                cust = some.LastOrDefault();

                                order.customerName = cust.Customer_Name;
                                order.customerContact = cust.Customer_Contact_Number;

                            }

                            else
                            {
                                MessageBox.Show("Something went wrong");
                                return;

                            }

                        }



                    }
                    else
                    {
                        order.customerName = txtCustName.Text;
                        order.customerContact = Convert.ToInt32(txtContact.Text);
                    }
                    db.DeliveryTables.Add(order);
                    db.SaveChanges();


                    for (int i = 0; i < Globals.ComboItems.Count; i++)
                    {

                        DeliveryLine item = new DeliveryLine();

                        item.comboItemId = Globals.ComboItems[i].OrderItemId;
                        item.orderId = order.OrderId;
                        item.comboItemQuantity = Globals.ComboItems[i].OrderQuantity;

                        db.DeliveryLines.Add(item);

                    }


                    for (int i = 0; i < Globals.StockItems.Count; i++)
                    {
                        DeliveryLine item = new DeliveryLine();

                        item.stockItemId = Globals.StockItems[i].OrderItemId;
                        item.orderId = order.OrderId;
                        item.stockItemQuantity = Globals.StockItems[i].OrderQuantity;

                        db.DeliveryLines.Add(item);
                    }

                    for (int i = 0; i < Globals.MenuItems.Count; i++)
                    {
                        DeliveryLine item = new DeliveryLine();

                        item.menuItemId = Globals.MenuItems[i].OrderItemId;
                        item.orderId = order.OrderId;
                        item.menuItemQuantity = Globals.MenuItems[i].OrderQuantity;

                        db.DeliveryLines.Add(item);


                    }

                    db.SaveChanges();
                    this.Close();
                    Globals.ComboItems.Clear();
                    Globals.MenuItems.Clear();
                    Globals.StockItems.Clear();


                    MessageBox.Show("Order saved successfully");
                }
                else
                {

                    MessageBox.Show("Error: Contact number can't be a negative number");
                }
            }

            else
            {
                
                MessageBox.Show("Error: Contact number not numeric,please anter a numeric value(integer)");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmRetrieveOrder form = new frmRetrieveOrder();
            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
