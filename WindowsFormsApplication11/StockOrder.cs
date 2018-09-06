using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class StockOrder : Form
    {
        OrderList parent;
        MmasweEntities9 db = new MmasweEntities9();
        int stockID = -1;
        int supplierID = -1;
       // int index = -1;
        public StockOrder()
        {
            InitializeComponent();
        }
        public StockOrder(OrderList f)
        {
            InitializeComponent();
            parent = f;
        }

        private void btnSupplierSelect_Click(object sender, EventArgs e)
        {
             SupplierList f = new SupplierList(this);
            f.ShowDialog();
        }
  
        private void btnStockSelect_Click(object sender, EventArgs e)
        {
            Stock_ItemList f = new Stock_ItemList(this);
            f.ShowDialog();
        }
        public void stock(int index)
        {
            stockID = index;
            Stock_Item i = db.Stock_Item.Where(x => x.Stock_ID == stockID).FirstOrDefault();
            txtSelectStock.Text = i.Stock_Item_Name;
        }
        public void supplier(int index)
        {
            supplierID = index;
            Supplier i = db.Suppliers.Where(x => x.Supplier_ID == supplierID).FirstOrDefault();
            txtSelectSupplier.Text = i.Supplier_Name;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Stock_Order sOrder = new Stock_Order();
            Stock_Order_Line orderLine = new Stock_Order_Line();
            orderLine.Stock_ID = stockID;
            sOrder.Supplier_ID = supplierID;
            orderLine.Stock_Order_Quantity = Convert.ToInt32(txtOrderQuantity.Text);
            orderLine.Quantity_Received = orderLine.Stock_Order_Quantity;
            sOrder.Stock_Order_Description = "Description";
            sOrder.Stock_Order_Issue_Date = DateTime.Now;
            sOrder.Stock_Order_Status_ID = 1;
            


            orderLine.Stock_Order_ID = sOrder.Stock_Order_ID;
            

            db.Stock_Order_Line.Add(orderLine);
            db.Stock_Order.Add(sOrder);
            db.SaveChanges();

            parent.load();
            // parent.loadReceivedOrder();
            MessageBox.Show("New Order Placed");

        }

        private void StockOrder_Load(object sender, EventArgs e)
        {

        }
        //private void groupBox1_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtSelectSupplier.Text) || supplierID == -1)
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(groupBox1, "Please select supplier");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(groupBox1, null);
        //    }
        //}

        //private void groupBox2_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtSelectStock.Text) || stockID == -1)
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(groupBox2, "Please select stock");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(groupBox2, null);
        //    }
        //}

        //private void groupBox3_Validating(object sender, CancelEventArgs e)
        //{
        //    if (!IsNumber(txtOrderQuantity.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(groupBox3, "Please enter quantity");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(groupBox3, null);
        //    }
        //}
        //bool IsNumber(string number)
        //{
        //    return Regex.IsMatch(number, @"^[0-9]+$");
        //}
    }
}
