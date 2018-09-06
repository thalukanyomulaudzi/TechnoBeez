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
    public partial class Combo_LookUp : Form
    {
        public Combo_LookUp()
        {
            InitializeComponent();
        }
        MmasweEntities9 db = new MmasweEntities9();
       
        List<Globals> another = new List<Globals>();

        private void Combo_LookUp_Load(object sender, EventArgs e)
        {
            var items = from obj in db.Comboes
                        join obj2 in db.Combo_Price
                        on obj.Combo_Price_ID equals obj2.Combo_Price_ID
                        select new
                        {
                         ComboId = obj.Combo_ID,
                         ComboName = obj.Combo_Name,
                         ComboPrice = obj2.Combo_Price1,
                         ComboDescription = obj.Combo_Description
                        };
            dgvComboItems.DataSource = items.ToList();
            dgvComboItems.ClearSelection();
        }

        private void dgvComboItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text != "0")
            {
                int id = Globals.OrderComboItem;


                Combo item = db.Comboes.FirstOrDefault(c => c.Combo_ID == id);
                Combo_Price price = db.Combo_Price.FirstOrDefault(c => c.Combo_Price_ID == id);

                if ((item != null) && (price != null))
                {
                    string itemDesc = "ID:  " + Convert.ToString(item.Combo_ID) + " Name:  " + item.Combo_Name
                    + " Description:  " + item.Combo_Description + " Quantity:  " + numericUpDown1.Text + " Notes:  " + comboRichTextBox.Text;
                    listBox1.Items.Add(itemDesc);
                    Globals ComboItem = new Globals();
                    ComboItem.OrderItemId = id;
                    ComboItem.OrderItemName = item.Combo_Name;
                    ComboItem.OrderItemDescription = item.Combo_Description;
                    ComboItem.OrderItemPrice = price.Combo_Price1;
                    ComboItem.OrderItemNotes = comboRichTextBox.Text;
                    ComboItem.OrderQuantity = Convert.ToInt32(numericUpDown1.Text);
                    another.Add(ComboItem);

                }
            }
            else
            {
                MessageBox.Show("Error:Quantity can't be zero");
            }
           
        }



        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(listBox1.SelectedIndex));



            try
            {
                another.RemoveRange(listBox1.SelectedIndex, 1);
                foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                listBox1.Items.Remove(s);
            }
            catch(Exception )
            {
                MessageBox.Show("Error:No item selected");

            }
               
            
        }


        private void button6_Click(object sender, EventArgs e)
        {
            foreach(var item in another)
            {

                Globals.ComboItems.Add(item);
                Globals.AmountDue = Globals.AmountDue + item.OrderItemPrice * item.OrderQuantity;
            }

            Globals.DisplayCombos = true;
            Globals.refresher2 = true;
            this.Close();
          
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgvComboItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (dgvComboItems.Rows.Count > 0)
            {
             int rowindex = dgvComboItems.CurrentCell.RowIndex;
             Globals.OrderComboItem = dgvComboItems.Rows[rowindex].Cells[0].Value;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
