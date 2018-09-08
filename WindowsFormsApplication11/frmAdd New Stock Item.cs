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
        MmasweEntities5 db = new MmasweEntities5();
        public frmAdd_New_Stock_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string phrase = txtStockItemPrice.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length < 9) && isNumeric == true)
            {

                if ( cmbStockItemType.Text == "Ingredient")
                {
                    Stock_Price newPrice = new Stock_Price();
                    newPrice.Stock_Price1 = Convert.ToDouble(txtStockItemPrice.Text);
                    db.Stock_Price.Add(newPrice);
                    //newPrice.Stock_Price1 = Convert.ToDouble(txtStockItemPrice.Text);


                    //db.Stock_Price.Add(newPrice);
                    Stock_Item newItem = new Stock_Item();
                    Stock_Type idTracker = db.Stock_Type.FirstOrDefault(c => c.Stock_Type_Description == "Ingredient");
                    newItem.Stock_Item_Name = txtStockItemnName.Text;
                    newItem.Stock_Item_Description = txtStockItemDescription.Text;
                    newItem.Stock_Item_Quantity = 0;
                    newItem.Stock_Type_ID = idTracker.Stock_Type_ID;
                    newItem.Stock_Price_ID = newPrice.Stock_Price_ID;
                    db.Stock_Item.Add(newItem);
                    db.SaveChanges();
                    MessageBox.Show("Stock item added successfully");
                    Globals.refresher = true;
                    txtStockItemnName.Text = "";
                    txtStockItemDescription.Text = "";
                    txtStockItemPrice.Text = "";
                    cmbStockItemType.Text = "";

                }


                if ((phrase.Length < 9) && cmbStockItemType.Text == "Product")
                {
                    Stock_Price newPrice = new Stock_Price();
                    newPrice.Stock_Price1 = Convert.ToDouble(txtStockItemPrice.Text);
                    db.Stock_Price.Add(newPrice);
                    newPrice.Stock_Price1 = Convert.ToDouble(txtStockItemPrice.Text);


                    db.Stock_Price.Add(newPrice);
                    Stock_Item newItem = new Stock_Item();
                    Stock_Type idTracker = db.Stock_Type.FirstOrDefault(c => c.Stock_Type_Description == "Product");
                    newItem.Stock_Item_Name = txtStockItemnName.Text;
                    newItem.Stock_Item_Description = txtStockItemDescription.Text;
                    newItem.Stock_Item_Quantity = 0;
                    newItem.Stock_Type_ID = cmbStockItemType.SelectedIndex;
                    newItem.Stock_Price_ID = newPrice.Stock_Price_ID;

                    db.Stock_Item.Add(newItem);

                    db.SaveChanges();
                    MessageBox.Show("Stock item added successfully");
                    Globals.refresher = true;
                    txtStockItemnName.Text = "";
                    txtStockItemDescription.Text = "";
                    txtStockItemPrice.Text = "";
                    cmbStockItemType.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Error: Price value entered is not in correct format or too large");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdd_New_Stock_Item_Load(object sender, EventArgs e)
        {

        }
    }
}
