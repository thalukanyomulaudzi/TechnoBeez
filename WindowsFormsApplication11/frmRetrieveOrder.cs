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
            int orderNo = Convert.ToInt32(txtOrderNo.Text);

            //DeliveryLine items = new DeliveryLine();
            var combos = from obj in db.DeliveryLines
                         where obj.orderId == orderNo
                         select new
                         {
                             itemId = obj.comboItemId,
                             itemQuantity = obj.comboItemQuantity

                       };
            
            foreach (var item in combos)
            {
                var comboId = item.itemId;
                Combo comb = db.Comboes.FirstOrDefault(c=> c.Combo_ID == comboId);
                string itemAdd = comb.Combo_Name + " Price: " + comb.Combo_Price1 + " Quantity: " + Convert.ToString(item.itemQuantity);
                listBox1.Items.Add(itemAdd);
                
            }


            var menus = from obj in db.DeliveryLines
                         where obj.orderId == orderNo
                         select new
                         {
                             itemId = obj.menuItemId,
                             itemQuantity = obj.menuItemQuantity

                         };

            foreach (var item in menus)
            {
                var Menu_Item_ID = item.itemId;
                Menu_Item comb = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == Menu_Item_ID);
                string itemAdd = comb.Menu_Item_Name + " Price: " + comb.Menu_Item_Price1 + " Quantity: " + Convert.ToString(item.itemQuantity);
                listBox1.Items.Add(itemAdd);

            }

            var stocks = from obj in db.DeliveryLines
                        where obj.orderId == orderNo
                        select new
                        {
                            itemId = obj.stockItemId,
                            itemQuantity = obj.stockItemQuantity

                        };

            foreach (var item in menus)
            {
                var Stock_ID = item.itemId;
                Stock_Item comb = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == Stock_ID);
                string itemAdd = comb.Stock_Item_Name + " Price: " + comb.Stock_Price + " Quantity: " + Convert.ToString(item.itemQuantity);
                listBox1.Items.Add(itemAdd);

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Payment pay = new Payment();
            Payment_Type type = db.Payment_Type.FirstOrDefault(c => c.Payment_Description == "Cash");


            pay.Payment_Amount = Convert.ToDouble(Globals.AmountDue);
            pay.Payment_Date = DateTime.Today;



            db.Payments.Add(pay);
            db.SaveChanges();
            Globals.SalesPaymentID = pay.Payment_ID;

          

            Customer_Order order = new Customer_Order();
            int id = Convert.ToInt32(txtOrderNo.Text);
            DeliveryTable orderD = db.DeliveryTables.FirstOrDefault(c=> c.OrderId == id);

            //Object Declaration---------------------------------//

            try
            {

                Company_Information inf = db.Company_Information.FirstOrDefault(c => c.Company_Info_ID == 1);


        


                //-----------------------------------------------------//
               
                //Order Details insert------------------------------------//
                order.Order_Status = "D";
                order.Order_Date = DateTime.Today;
               
                //order.Sale_Vat_Amount = orderD.vatTot;
                order.Payment_ID = db.Payments.LastOrDefault().Payment_ID;
                order.Delivery_Status_ID = 1;
               
                order.OrderNotes = orderD.orderNotesf;
                order.OrderTotal = orderD.orderTotal;
                order.TotalItems = orderD.totalItemsf;
               // order.Cash = Convert.ToDouble(txtCash.Text);
                //order.Change = Convert.ToDouble(txtCash.Text) - Globals.AmountDue;
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
    }
}
