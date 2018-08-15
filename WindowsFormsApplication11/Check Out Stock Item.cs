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
        MmasweEntities4 db = new MmasweEntities4();
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

            txtStockItemID.Enabled = false;
            txtStockItemNamee.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
