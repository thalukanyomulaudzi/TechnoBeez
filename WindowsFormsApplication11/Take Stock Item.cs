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
    public partial class Take_Stock_Item : Form
    {
        public Take_Stock_Item()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string phrase = txtStockQuantity.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if (isNumeric == true)
            {
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                if ((phrase.Length < 9) && (Convert.ToInt32(txtStockQuantity.Text) != itemEdited.Stock_Item_Quantity) && (Convert.ToInt32(txtStockQuantity.Text)>0) && (Convert.ToInt32(txtStockQuantity.Text) <2000000000))
                {
                    itemEdited.Stock_Item_Quantity =  Convert.ToInt32(txtStockQuantity.Text);
                    db.SaveChanges();
                    MessageBox.Show("Stock item taken successfully,quantity: " + txtStockQuantity.Text);
                    Globals.refresher = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error:Quantity not changed/Quantity less than 1 or too large");
                }
               
            }
            else
            {
                MessageBox.Show("Error: Value entered is not in correct format(not numeric)");
            }
        }

        private void Take_Stock_Item_Load(object sender, EventArgs e)
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
