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
    public partial class Maintain_Stock_Item : Form
    {
        public Maintain_Stock_Item()
        {
            InitializeComponent();
        }
        MmasweEntities13 db = new MmasweEntities13();

        private void button1_Click(object sender, EventArgs e)
        {
            string phrase = txtCostPrice.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length < 9) && isNumeric == true)
            {
            
            int id = Globals.MStockpassing;
            Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
            Stock_Price priceEdit = db.Stock_Price.FirstOrDefault(c => c.Stock_Price_ID == id);


            itemEdited.Stock_Item_Name = txtStockItemNameMaint.Text;
            itemEdited.Stock_Item_Description = txtStockItemDescriptionMaint.Text;
            priceEdit.Stock_Price1 = Convert.ToDouble(txtCostPrice.Text);
            if (cmbSTypeMaint.Text == "Ingredient")
            {
                Stock_Type idTracker = db.Stock_Type.FirstOrDefault(c => c.Stock_Type_Description == "Ingredient");
                itemEdited.Stock_Type_ID = idTracker.Stock_Type_ID;
            }
            else if (cmbSTypeMaint.Text == "Product")
            {
                Stock_Type idTracker = db.Stock_Type.FirstOrDefault(c => c.Stock_Type_Description == "Product");
                itemEdited.Stock_Type_ID = idTracker.Stock_Type_ID;

            }
            db.SaveChanges();

                MessageBox.Show("Stock item updated successfully");
                Globals.refresher = true;
                
                this.Close();
            }

            else
            {
                MessageBox.Show("Error: Price value entered is not in correct format or value too large");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Globals.MStockpassing;
            Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
            db.Stock_Item.Remove(itemEdited);
            db.SaveChanges();
            MessageBox.Show("Stock item deleted successfully");
            Globals.refresher = true;
            this.Close();

            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Maintain_Stock_Item_Load(object sender, EventArgs e)
        {
           
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);

                Stock_Price priceEdit = db.Stock_Price.FirstOrDefault(c => c.Stock_Price_ID == id);
                Stock_Type stockType = db.Stock_Type.FirstOrDefault(c => c.Stock_Type_ID == itemEdited.Stock_Type_ID);

                txtStockItemNameMaint.Text = itemEdited.Stock_Item_Name;
                txtStockItemDescriptionMaint.Text = itemEdited.Stock_Item_Description;
                txtCostPrice.Text = Convert.ToString(priceEdit.Stock_Price1);
                cmbSTypeMaint.Text = stockType.Stock_Type_Description;

           
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
