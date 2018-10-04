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
    public partial class Check_Out_Stock_Item : Form
    {
        MmasweEntities5 db = new MmasweEntities5();
        public Check_Out_Stock_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phrase = txtStockQuantity.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if (isNumeric == true)
            {

                if ((phrase.Length < 9) && Convert.ToInt32(txtStockQuantity.Text)>0)
                {
                    int id = Globals.MStockpassing;
                    Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);

                    itemEdited.Stock_Item_Quantity = itemEdited.Stock_Item_Quantity + Convert.ToInt32(txtStockQuantity.Text);
                    db.SaveChanges();

                    MessageBox.Show("Stock item checked out successfully,quantity: +" + txtStockQuantity.Text);
                    Globals.refresher = true;
                    this.Close();

                }
                else
                { MessageBox.Show("Error:Quantity less than 1 or too large"); }
                
              
            }
            else
            {
                MessageBox.Show("Error: Value entered is not in correct format(not numeric)");
            }
        }

        private void Check_Out_Stock_Item_Load(object sender, EventArgs e)
        {
            int id = Globals.MStockpassing;
            Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
            Stock_Price priceEdit = db.Stock_Price.FirstOrDefault(c => c.Stock_Price_ID == id);
            Stock_Type stockType = db.Stock_Type.FirstOrDefault(c => c.Stock_Type_ID == itemEdited.Stock_Type_ID);

            txtStockItemID.Text = Convert.ToString(itemEdited.Stock_ID);
            txtStockItemNamee.Text = itemEdited.Stock_Item_Name;

            var customers = from p in db.Check_Out_Line
                            select new
                            {
                                CheckInLineID = p.Check_Out_Line_ID,
                                StockItemName = p.Stock_Item_Name,
                                Quantity = p.Quaantity,
                                CheckOutID = p.Check_Out_ID,
                                StockItemID = p.Stock_ID,

                            };
            dgvCheckOut.DataSource = customers.ToList();
            dgvCheckOut.ClearSelection();

            txtStockItemID.Enabled = false;
            txtStockItemNamee.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string phrase = txtStockQuantity.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if (isNumeric == true)
            {

                if ((phrase.Length < 9) && Convert.ToInt32(txtStockQuantity.Text) > 0)
                {
                    int id = Globals.MStockpassing;
                    Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                    Check_Out itemout = new Check_Out();
                    Check_Out_Line outline = new Check_Out_Line();

                    itemout.Stock_Item_Name = itemEdited.Stock_Item_Name;
                    itemout.Check_Out_Date = DateTime.Today;

                    outline.Stock_ID = itemEdited.Stock_ID;
                    outline.Check_Out_ID = itemout.Check_Out_ID;
                    outline.Quaantity = Convert.ToInt32(txtStockQuantity.Text);
                    outline.Stock_Item_Name = itemEdited.Stock_Item_Name;

                    itemEdited.Stock_Item_Quantity = itemEdited.Stock_Item_Quantity + Convert.ToInt32(txtStockQuantity.Text);
                    db.Check_Out.Add(itemout);
                    db.Check_Out_Line.Add(outline);
                    db.SaveChanges();

                    int id2 = Globals.LogedUser;
                    Employee emp = db.Employees.FirstOrDefault(c => c.Employee_ID == id2);
                    Audit ad = new Audit();
                    ad.Audit_Name = emp.Employee_Name;
                    ad.Audit_Table = "Check_Out";
                    ad.Audit_Description = "Item_CheckOut";
                    ad.User_ID = Globals.LogedUser;
                    ad.transactionNumber = itemout.Check_Out_ID;
                    ad.auditDate = DateTime.Now;
                    db.Audits.Add(ad);
                    db.SaveChanges();

                    MessageBox.Show("Stock item checked out successfully,quantity: +" + txtStockQuantity.Text);
                    Globals.refresher = true;
                    this.Close();

                }
                else
                { MessageBox.Show("Error:Quantity less than 1 or too large"); }


            }
            else
            {
                MessageBox.Show("Error: Value entered is not in correct format(not numeric)");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
