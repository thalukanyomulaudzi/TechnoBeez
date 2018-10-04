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
       // ListStockOrderItems parent;
        MmasweEntities5 db = new MmasweEntities5();

        bool isTrue = true;
        int stockID = -1;
        int supplierID = -1;
      //  ListStockOrderItems list = new ListStockOrderItems();
        // int index = -1;     <connectionStrings><add name="MmasweEntities5" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=LAPTOP-FU49UF7O\MSSQLSERVER01;initial catalog=Mmaswe;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  //</connectionStrings>
        public StockOrder()
        {
            InitializeComponent();
        }
        public string Get_SupplierText()
        {
            return txtSelectSupplier.Text;
        }
        public StockOrder(OrderList f)
        {
            InitializeComponent();
            parent = f;
        }

        private void btnSupplierSelect_Click(object sender, EventArgs e)
        {
             SupplierList f1 = new SupplierList(this);
            f1.ShowDialog();
            if(txtSelectSupplier.Text!="")
            {
                btnSupplierSelect.Enabled = false;
            }
            else
                btnSupplierSelect.Enabled = true;

        }
        public void check(bool ch)
        {
            ch = isTrue;
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

            Globals newGlobal = new Globals();

            //StockOrder f = new StockOrder();
            newGlobal.OrderNo = stockID;
            newGlobal.sOrderQuantity = Convert.ToInt32(txtOrderQuantity.Text);
            newGlobal.SupplierName = txtSelectSupplier.Text;
            newGlobal.StockItemName = txtSelectStock.Text;
            newGlobal.StockOrderDescription = richTextBox1.Text;
            newGlobal.DateIssued = DateTime.Now;

            Globals.StockOrders.Add(newGlobal);
            this.Close();
            //parent.ShowDialog();
        }
        public string StockOrderDescription()
        {
            return richTextBox1.Text;
        }
        public void SendEmail()
        {
            Supplier s = db.Suppliers.Where(x => x.Supplier_ID == supplierID).FirstOrDefault();
            Supplier_Contact_Details sc = db.Supplier_Contact_Details.Where(x => x.Supplier_Contact_ID == s.Supplier_ID).FirstOrDefault();
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
                
                foreach (var order in Globals.StockOrders)
                {
                    message.Body = "Dear " + s.Supplier_Name + "\nWe are very interested in making an order for the following item:\n\n" +
                    order.StockItemName + "     Quantity: " + order.sOrderQuantity +
                    "\n\nWe look forward to your reply \n\nKind Regards Mr Mafokwane (Manager)";
                }

                //message.Body = "Dear \n"+s.Supplier_Name+"\nWe are very interested in making an order for the following item: \n"+
                //                st.Stock_Item_Name +" Quantity"+ so.Stock_Order_Quantity +
                //                "\n\nWe look forward to your reply \n\nKind Regards Mr Mafokwane (Manager)";
                //message.To.Add(sc.Supplier_Email_Adress);
                message.To.Add(sc.Supplier_Email_Adress);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (txtOrderQuantity.Text == "" && txtSelectStock.Text == "" && txtSelectSupplier.Text == "")
            //{
            //    btnSubmit.Enabled = false;
            //}
            //else
            //    btnSubmit.Enabled = true;
            Stock_Order sOrder = new Stock_Order();

            // orderLine.Q = orderLine.Stock_Order_Quantity;
            sOrder.Stock_Order_Description = "Description";
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
                // parent.load();


                //}




                //SendEmail();
                //// parent.loadReceivedOrder();
                //MessageBox.Show("New Order Placed");
            }
        }

        private void StockOrder_Load(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtSelectStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void employeeTypeBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void genderBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void genderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void employeeTypeBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void employeeTypeBindingSource_CurrentChanged(object sender, EventArgs e)
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
