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
    public partial class frmRetrieveOrder : Form
    {
        public frmRetrieveOrder()
        {
            InitializeComponent();
        }

        MmasweEntities5 db = new MmasweEntities5();

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string phrase = txtOrderNo.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length < 9) && (isNumeric == true))
            {
                if (Convert.ToInt32(txtOrderNo.Text) > -1)
                {
                    listBox1.Items.Clear();
                    int orderNo = Convert.ToInt32(txtOrderNo.Text);
                    Company_Information inf = db.Company_Information.FirstOrDefault(c => c.Company_Info_ID == 1);

                    var combos = from obj in db.DeliveryLines
                                 where (obj.orderId == orderNo) && (obj.comboItemId != null)
                                 select new
                                 {
                                     itemId = obj.comboItemId,
                                     itemQuantity = obj.comboItemQuantity

                                 };

                    foreach (var item in combos)
                    {

                        var comboId = item.itemId;
                        Combo comb = db.Comboes.FirstOrDefault(c => c.Combo_ID == comboId);
                        string itemAdd = "ItemName:: " + comb.Combo_Name + " Price: " + comb.Combo_Price + " Quantity: " + Convert.ToString(item.itemQuantity);
                        Globals.vatAmountDelivery = Globals.vatAmountDelivery + comb.Combo_Price * inf.VAT_Percentage;
                        listBox1.Items.Add(itemAdd);

                    }


                    var menus = from obj in db.DeliveryLines
                                where (obj.orderId == orderNo) && (obj.menuItemId != null)
                                select new
                                {
                                    itemId = obj.menuItemId,
                                    itemQuantity = obj.menuItemQuantity

                                };

                    foreach (var item in menus)
                    {

                        var Menu_Item_ID = item.itemId;
                        Menu_Item comb = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == Menu_Item_ID);
                        string itemAdd = "ItemName:: " + comb.Menu_Item_Name + " Price:: " + comb.Menu_Item_Price + " Quantity: " + Convert.ToString(item.itemQuantity);
                        Globals.vatAmountDelivery = Globals.vatAmountDelivery + comb.Menu_Item_Price * inf.VAT_Percentage;
                        listBox1.Items.Add(itemAdd);

                    }

                    var stocks = from obj in db.DeliveryLines
                                 where (obj.orderId == orderNo) && (obj.stockItemId != null)
                                 select new
                                 {
                                     itemId = obj.stockItemId,
                                     itemQuantity = obj.stockItemQuantity

                                 };

                    foreach (var item in stocks)
                    {

                        var Stock_ID = item.itemId;
                        Stock_Item comb = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == Stock_ID);
                        string itemAdd = "ItemName:: " + comb.Stock_Item_Name + " Price: " + comb.Stock_Price + " Quantity: " + Convert.ToString(item.itemQuantity);
                        Stock_Price pric = db.Stock_Price.FirstOrDefault(c=> c.Stock_Price_ID == Stock_ID);
                        Globals.vatAmountDelivery = Globals.vatAmountDelivery + pric.Stock_Price1 * inf.VAT_Percentage;
                        listBox1.Items.Add(itemAdd);
                     

                    }

                    if (listBox1.Items.Count != 0)
                    {
                        btnPay.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string phrase = txtOrderNo.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length < 9) && (isNumeric == true))
            {
                if (Convert.ToInt32(txtOrderNo.Text) > -1)
                {

                    int id = Convert.ToInt32(txtOrderNo.Text);

                    DeliveryTable orderD = db.DeliveryTables.FirstOrDefault(c => c.OrderId == id);
                    if(orderD == null)
                    {
                        MessageBox.Show("Order not found");
                        return;
                        
                    }

                    Payment pay = new Payment();
            Payment_Type type = db.Payment_Type.FirstOrDefault(c => c.Payment_Description == "Cash");


            pay.Payment_Amount = Convert.ToDouble(Globals.AmountDue);
            pay.Payment_Date = DateTime.Today;



            db.Payments.Add(pay);
            db.SaveChanges();
            Globals.SalesPaymentID = pay.Payment_ID;



            Customer_Order order = new Customer_Order();


            string name = orderD.customerName;
            dynamic num = orderD.customerContact;
            int contact = num;
            Customer custom = db.Customers.FirstOrDefault(c => (c.Customer_Name == name) && (c.Customer_Contact_Number == contact));

            //Object Declaration---------------------------------//

            try
            {

                Company_Information inf = db.Company_Information.FirstOrDefault(c => c.Company_Info_ID == 1);





                //-----------------------------------------------------//

                //Order Details insert------------------------------------//
                order.Order_Status = "D";
                order.Order_Date = DateTime.Now;
                order.Payment_ID = 2;// db.Payments.LastOrDefault().Payment_ID;
                order.Delivery_Status_ID = 1;
                order.OrderNotes = orderD.orderNotesf;
                order.OrderTotal = orderD.orderTotal;
                order.TotalItems = orderD.totalItemsf;
                order.Sale_Vat_Amount = Globals.vatAmountDelivery;
                order.Customer_ID = custom.Customer_ID;

                //---------------------------------------------------------//

                db.Customer_Order.Add(order);
                db.SaveChanges();


            }
            catch (Exception i)
            {
                MessageBox.Show(Convert.ToString(i));
            }



            int orderNo = orderD.OrderId;

            var combos = from obj in db.DeliveryLines
                         where (obj.orderId == orderNo) && (obj.comboItemId != null)
                         select new
                         {
                             itemId = obj.comboItemId,
                             itemQuantity = obj.comboItemQuantity


                         };

            foreach (var item in combos)
            {


                //MessageBox.Show(Convert.ToString(order.Order_ID)+ " " + Convert.ToString(order.Order_ID));
                Customer_Order_Line orderLine = new Customer_Order_Line();
                orderLine.Customer_Order_ID = order.Order_ID;
                orderLine.Combo_Quantity = item.itemQuantity;
                orderLine.Combo_ID = item.itemId;

                db.Customer_Order_Line.Add(orderLine);


            }



            var menus = from obj2 in db.DeliveryLines
                        where (obj2.orderId == orderNo) && (obj2.menuItemId != null)
                        select new
                        {
                            itemId = obj2.menuItemId,
                            itemQuantity = obj2.menuItemQuantity


                        };

            foreach (var item2 in menus)
            {


                //MessageBox.Show(Convert.ToString( item.itemQuantity) + Convert.ToString(item.itemId));
                Customer_Order_Line orderLine = new Customer_Order_Line();
                orderLine.Customer_Order_ID = order.Order_ID;
                orderLine.Menu_Item_Quantity = item2.itemQuantity;
                orderLine.Menu_Item_ID = item2.itemId;

                db.Customer_Order_Line.Add(orderLine);


            }

            var stocks = from obj3 in db.DeliveryLines
                         where (obj3.orderId == orderNo) && (obj3.stockItemId != null)
                         select new
                         {
                             itemId = obj3.stockItemId,
                             itemQuantity = obj3.stockItemQuantity


                         };

            foreach (var item3 in stocks)
            {



                Customer_Order_Line orderLine = new Customer_Order_Line();
                orderLine.Customer_Order_ID = order.Order_ID;
                orderLine.Menu_Item_Quantity = item3.itemQuantity;
                orderLine.Menu_Item_ID = item3.itemId;

                db.Customer_Order_Line.Add(orderLine);


            }


            db.SaveChanges();


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
                    MessageBox.Show("Error: Order number can't be less than one");
                }
    }
            else
            {
                MessageBox.Show("Error: Order number should be numerical");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmRetrieveOrder_Load(object sender, EventArgs e)
        {
            btnPay.Visible = false;
           
        }

        private void txtOrderNo_TextChanged(object sender, EventArgs e)
        {
            btnPay.Visible = false;
        }
    }
}
