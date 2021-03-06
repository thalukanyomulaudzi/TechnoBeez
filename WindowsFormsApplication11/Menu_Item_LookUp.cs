﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Menu_Item_LookUp : Form
    {
        public Menu_Item_LookUp()
        {
            InitializeComponent();
        }

        MmasweEntities5 db = new MmasweEntities5();
        List<Globals> itemsA = new List<Globals>();

        private void button7_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text != "0")
            {
                int id = Globals.OrderMenuItem;

                Menu_Item item = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == id);
                Menu_Item_Price price = db.Menu_Item_Price.FirstOrDefault(c => c.Menu_Price_ID == id);

                if ((item != null) && (price != null))
                {
                    string itemDesc = "ID:  " + Convert.ToString(item.Menu_Item_ID) + " Name:  " + item.Menu_Item_Name
                    + " Description:  " + item.Menu_Item_Description + " Quantity:  " + numericUpDown1.Text ;
                    listBox1.Items.Add(itemDesc);
                    Globals menu = new Globals();

                    menu.OrderItemId = id;
                    menu.OrderItemName = item.Menu_Item_Name;
                    menu.OrderItemDescription = item.Menu_Item_Description;

                    menu.OrderItemPrice = price.Menu_Price;
                   
                    menu.OrderQuantity = Convert.ToInt32(numericUpDown1.Text);
                    itemsA.Add(menu);
                }
            }
            else
            {
                MessageBox.Show("Error:Quantity can't be zero");
            }
        }

        private void Menu_Item_LookUp_Load(object sender, EventArgs e)
        {
            var items = from obj in db.Menu_Item
                        join obj2 in db.Menu_Item_Price
                        on obj.Menu_Price_ID equals obj2.Menu_Price_ID
                        select new
                        {
                            MenuId = obj.Menu_Item_ID,
                            MenuName = obj.Menu_Item_Name,
                            MenuPrice = obj2.Menu_Price,
                            MenuDescription = obj.Menu_Item_Description
                        };
            dgvMenuItems.DataSource = items.ToList();
            dgvMenuItems.ClearSelection();
         
            Globals.refresher2 = -1;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMenuItems.Rows.Count > 0)
            {
                int rowindex = dgvMenuItems.CurrentCell.RowIndex;
                Globals.OrderMenuItem = dgvMenuItems.Rows[rowindex].Cells[0].Value;
               

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                itemsA.RemoveRange(listBox1.SelectedIndex, 1);
                foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                listBox1.Items.Remove(s);
            }
            catch(Exception)
            {
                MessageBox.Show("Error:No item selected");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach(var item in itemsA)
            {
                Globals.MenuItems.Add(item);
                Globals.AmountDue = Globals.AmountDue + item.OrderItemPrice * item.OrderQuantity;
            }

            this.Close();          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
