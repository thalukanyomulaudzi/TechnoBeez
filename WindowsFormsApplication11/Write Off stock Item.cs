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
    public partial class Write_Off_stock_Item : Form
    {
        public Write_Off_stock_Item()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();

        private void Write_Off_stock_Item_Load(object sender, EventArgs e)
        {
            int id = Globals.MStockpassing;
            Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
            Stock_Price priceEdit = db.Stock_Price.FirstOrDefault(c => c.Stock_Price_ID == id);
            Stock_Type stockType = db.Stock_Type.FirstOrDefault(c => c.Stock_Type_ID == itemEdited.Stock_Type_ID);

            txtStockItemID.Text = Convert.ToString(itemEdited.Stock_ID);
            txtStockItemNamee.Text = itemEdited.Stock_Item_Name;


            var customers = from p in db.Stock_WriteOff_Line
                            select new
                            {
                                WriteOffLineID = p.Stock_WriteOff_LineID,
                                StockItemName = p.Stock_Item_Name,
                                Quantity = p.Quantity,
                                WriteOffID = p.Write_Off_ID,
                                StockItemID = p.Stock_ID,

                            };
            dgvWriteOffHistory.DataSource = customers.ToList();
            dgvWriteOffHistory.ClearSelection();

            txtStockItemID.Enabled = false;
            txtStockItemNamee.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string phrase = txtStockQuantity.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if (isNumeric == true)
            {
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                if ((phrase.Length < 9) && (Convert.ToInt32(txtStockQuantity.Text) <= itemEdited.Stock_Item_Quantity) && Convert.ToInt32(txtStockQuantity.Text) >0)
                {
                    itemEdited.Stock_Item_Quantity = itemEdited.Stock_Item_Quantity - Convert.ToInt32(txtStockQuantity.Text);
                    db.SaveChanges();
                    MessageBox.Show("Stock item writen off successfully,quantity: -" + txtStockQuantity.Text);
                    Globals.refresher = true;
                    this.Close();
                }
               

                 else
                {
                    MessageBox.Show("Error:Quantity exceeds available stock items/Quantity less than 1 or too large");
                }
            }
            else
            {
                MessageBox.Show("Error: Value entered is not in correct format(not numeric)");
            }
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
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                Stock_Write_Off writeoff = new Stock_Write_Off();
                Stock_WriteOff_Line writeline = new Stock_WriteOff_Line();

                if ((phrase.Length < 9) && (Convert.ToInt32(txtStockQuantity.Text) <= itemEdited.Stock_Item_Quantity) && Convert.ToInt32(txtStockQuantity.Text) > 0)
                {
                    itemEdited.Stock_Item_Quantity = itemEdited.Stock_Item_Quantity - Convert.ToInt32(txtStockQuantity.Text);

                    writeoff.WriteOff_Stock_Name = itemEdited.Stock_Item_Name;
                    writeoff.WriteOff_Reason = txtReason.Text;
                    writeoff.Stock_WriteOff_Quantity = Convert.ToInt32(txtStockQuantity.Text);
                    writeoff.WriteOffDate = DateTime.Today;

                    writeline.Stock_ID = itemEdited.Stock_ID;
                    writeline.Write_Off_ID = writeoff.Write_Off_ID;
                    writeline.Quantity = Convert.ToInt32(txtStockQuantity.Text);
                    writeline.Stock_Item_Name = itemEdited.Stock_Item_Name;

                    db.Stock_Write_Off.Add(writeoff);
                    db.Stock_WriteOff_Line.Add(writeline);

                    db.SaveChanges();
                    MessageBox.Show("Stock item writen off successfully,quantity: -" + txtStockQuantity.Text);
                    Globals.refresher = true;
                    this.Close();
                }


                else
                {
                    MessageBox.Show("Error:Quantity exceeds available stock items/Quantity less than 1 or too large");
                }
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
