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
    public partial class ListStockOrderItems : Form
    {
        MmasweEntities5 db = new MmasweEntities5();
        OrderList list;
       
        StockOrder order = new StockOrder();

        int supplierID = -1;
        public ListStockOrderItems()
        {
            InitializeComponent();
        }
        //public ListStockOrderItems(OrderList f)
        //{
        //    InitializeComponent();
        //    list = f;
        //}


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Stock_Order sOrder = new Stock_Order();

            // orderLine.Q = orderLine.Stock_Order_Quantity;
            sOrder.Stock_Order_Description="Description";
            sOrder.Stock_Order_Issue_Date = DateTime.Now;
            sOrder.Stock_Order_Status_ID = 1;
            sOrder.Supplier_ID = supplierID;
            db.Stock_Order.Add(sOrder);
            db.SaveChanges();
            foreach (var item in Globals.StockOrders)
            {
                Stock_Order_Line orderLine = new Stock_Order_Line();
                orderLine.Stock_ID = item.OrderNo;


                orderLine.Stock_Order_Quantity = item.sOrderQuantity;

                orderLine.Stock_Order_ID = sOrder.Stock_Order_ID;
                // sOrder.Stock_Order_ID = item.OrderNo;

                db.Stock_Order_Line.Add(orderLine);
                db.SaveChanges();
                list.load();


            }




            order.SendEmail();
            // parent.loadReceivedOrder();
            MessageBox.Show("New Order Placed");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (StockOrder newOrder = new StockOrder())
            {
                if(newOrder.DialogResult==DialogResult.OK)
                {
                    string i = "Stock Item Name: "+ Globals.StockOrders.Last().StockItemName + "    Quantity: " + Globals.StockOrders.Last().sOrderQuantity.ToString();
                    listBox1.Items.Add(i);
                }
            }
                //order.ShowDialog();
        }

        private void ListStockOrderItems_Load(object sender, EventArgs e)
        {

        }
    }
}
