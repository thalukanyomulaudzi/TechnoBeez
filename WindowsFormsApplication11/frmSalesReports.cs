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
    public partial class frmSalesReports : Form
    {
        public frmSalesReports()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();
        List<Globals> list = new List<Globals>();

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            int rowindex = dgvOrders.CurrentCell.RowIndex;
            Globals.Salespassing = dgvOrders.Rows[rowindex].Cells[0].Value;

            int orderNo = Globals.Salespassing;
            Customer_Order ordeR = db.Customer_Order.FirstOrDefault(c => c.Order_ID == orderNo);

            txtDate.Enabled = false;
            txtOrderTotal.Enabled = false;
            txtOrdNum.Enabled = false;
            txtStatus.Enabled = false;
            txtVat.Enabled = false;
            rbxNotes.Enabled = false;

            txtDate.Text = ordeR.Order_Date.ToString();
            txtOrderTotal.Text = ordeR.OrderTotal.ToString();
            txtOrdNum.Text = ordeR.Order_ID.ToString();
            txtStatus.Text = ordeR.Order_Status.ToString();
            txtVat.Text = ordeR.Sale_Vat_Amount.ToString();
            rbxNotes.Text = ordeR.OrderNotes.ToString();

            var combos = from obj in db.Customer_Order_Line
                         where (obj.Customer_Order_ID == orderNo) && (obj.Combo_ID != null)
                         select new
                         {
                             itemId = obj.Combo_ID,
                             itemQuantity = obj.Combo_Quantity

                         };

            foreach (var item in combos)
            {
                Globals it = new Globals();
                dynamic num = item.itemId;
                int id = num;
                dynamic num2 = item.itemQuantity;
                int quant = num2;
                Combo comb = db.Comboes.FirstOrDefault(c => c.Combo_ID == id);
                it.OrderItemName = comb.Combo_Name;
                it.OrderQuantity = num2;
                it.OrderItemPrice = comb.Combo_Price;

                list.Add(it);
            }



            var menus = from obj in db.Customer_Order_Line
                        where (obj.Customer_Order_ID == orderNo) && (obj.Menu_Item_ID != null)
                        select new
                        {
                            itemId = obj.Menu_Item_ID,
                            itemQuantity = obj.Menu_Item_Quantity

                        };

            foreach (var item in menus)
            {
                Globals it = new Globals();
                dynamic num = item.itemId;
                int id = num;
                dynamic num2 = item.itemQuantity;
                int quant = num2;
                Menu_Item comb = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == id);
                it.OrderItemName = comb.Menu_Item_Name;
                it.OrderQuantity = num2;
                it.OrderItemPrice = comb.Menu_Item_Price;

                list.Add(it);
            }

            var stocks = from obj in db.Customer_Order_Line
                         where (obj.Customer_Order_ID == orderNo) && (obj.Stock_ID != null)
                         select new
                         {
                             itemId = obj.Stock_ID,
                             itemQuantity = obj.Stock_Item_Quantity

                         };

            foreach (var item in stocks)
            {
                Globals it = new Globals();
                dynamic num = item.itemId;
                int id = num;
                dynamic num2 = item.itemQuantity;
                int quant = num2;
                Stock_Item comb = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                it.OrderItemName = comb.Stock_Item_Name;
                it.OrderQuantity = num2;
                dynamic num3 = comb.Stock_ID;
                int id5 = num3;
                Stock_Price pric = db.Stock_Price.FirstOrDefault(c => c.Stock_Price_ID == id5);
                it.OrderItemPrice = pric.Stock_Price1;

                list.Add(it);
            }





            var products = from obj in list
                           select new
                           {
                               ItemName = obj.OrderItemName,
                               ItemQuantity = obj.OrderQuantity,
                               ItemPrice = obj.OrderItemPrice

                           };


            dataGridView1.DataSource = products.ToList();
            list.Clear();
        }

        private void frmSalesReports_Load(object sender, EventArgs e)
        {
            var customers = from p in db.Customer_Order
                            select new
                            {
                                OrderId = p.Order_ID,
                               
                                OrderDate = p.Order_Date,
                                SaleVatAmount = p.Sale_Vat_Amount,
                                OrderTotal = p.OrderTotal,
                             
                                

                            };
            dgvOrders.DataSource = customers.ToList();
            dgvOrders.ClearSelection();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
