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
    public partial class frmAdd_New_Stock_Item : Form
    {
        public frmAdd_New_Stock_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MmasweEntities3 context = new MmasweEntities3())
            {
                
                Stock_Price newPrice = new Stock_Price
                {
                    Stock_Price1 = Convert.ToDouble(txtStockItemPrice.Text),

                };
                context.Stock_Price.Add(newPrice);

                if (cmbStockItemType.Text == "Ingredient")
                {
                    Stock_Item newItem = new Stock_Item
                    {

                        Stock_Item_Name = txtStockItemnName.Text,
                        Stock_Item_Description = txtStockItemDescription.Text,
                        Stock_Item_Quantity = 0,
                        Stock_Type_ID = 18
                        
                    };
                   
                    context.Stock_Item.Add(newItem);

                    context.SaveChanges();
                }

                if (cmbStockItemType.Text == "Product")
                {
                    Stock_Item newItem = new Stock_Item
                    {


                        Stock_Item_Name = txtStockItemnName.Text,
                        Stock_Item_Description = txtStockItemDescription.Text,
                        Stock_Item_Quantity = 0,
                        Stock_Type_ID = 19,
                       // Stock_Price_ID = 


                    };

                    context.Stock_Item.Add(newItem);

                    context.SaveChanges();
                }

            }


           


        }
    }
}
