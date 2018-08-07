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
    public partial class Add_New_Stock_Item : Form
    {
        public Add_New_Stock_Item()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            using (MmasweEntities1 context = new MmasweEntities1())
            {


                Stock_Price newPrice = new Stock_Price
                {
                    Stock_Price1 = Convert.ToDecimal(txtStockItemPrice.Text)

                };
                context.Stock_Price.Add(newPrice);


                Stock_Type newType = new Stock_Type
                {
                    Stock_Type_Description = Convert.ToString(cmbStockType.Text)
                };
                context.Stock_Type.Add(newType);

                Stock_Item newItem = new Stock_Item
                { Stock_Item_Name = txtStockItemnName.Text,
                    Stock_Item_Description = txtStockItemDescription.Text,
                    Stock_Item_Quantity = 0

                };
                context.Stock_Item.Add(newItem);
                
                context.SaveChanges();

            }
        }

        private void lblStockQuantity_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
