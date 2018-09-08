using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication11
{
    public partial class StockOrder : Form
    {
        OrderList parent;
        MmasweEntities5 db = new MmasweEntities5();
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
            orderLine.Stock_Order_Quantity = orderLine.Stock_Order_Quantity;
            sOrder.Stock_Order_Description = "Description";
            sOrder.Stock_Order_Issue_Date = DateTime.Now;
            sOrder.Stock_Order_Status_ID = 1;

            StockOrder f = new StockOrder();
          //  if (this.Close())
                
            orderLine.Stock_Order_ID = sOrder.Stock_Order_ID;
            

            db.Stock_Order_Line.Add(orderLine);
            db.Stock_Order.Add(sOrder);
            db.SaveChanges();

            parent.load();
            SendEmail();
            // parent.loadReceivedOrder();
            MessageBox.Show("New Order Placed");

        }
        public void SendEmail()
        {
            Supplier s = db.Suppliers.Where(x => x.Supplier_ID == supplierID).FirstOrDefault();
            Supplier_Contact_Details sc = db.Supplier_Contact_Details.Where(x => x.Supplier_Contact_ID == supplierID).FirstOrDefault();
            Stock_Item st = db.Stock_Item.Where(x=>x.Stock_ID==stockID).FirstOrDefault();
            Stock_Order_Line so = db.Stock_Order_Line.Where(x => x.Stock_Order_Line_ID == stockID).FirstOrDefault();

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                MailMessage message = new MailMessage();

                string myEmail = "thalu.tuks@gmail.com";
                string pswd = "@mulaudzi";
                message.From = new MailAddress(myEmail);
                message.Subject = "Placing an order";
                message.Body = "Dear \n"+s.Supplier_Name+"\nWe are very interested in making an order for the following item: \n"+
                                st.Stock_Item_Name +" Quantity"+ so.Stock_Order_Quantity +
                                "\n\nWe look forward to your reply \n\nKind Regards Mr Mafokwane (Manager)";
                //message.To.Add(sc.Supplier_Email_Adress);
                message.To.Add("thalu0014@gmail.com");
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                client.Credentials = new System.Net.NetworkCredential(myEmail,pswd);
                client.Send(message);
                message = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error "+ ex);
            }

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
