using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Menu_And_Combo : Form
    {
        public Menu_And_Combo()
        {
            InitializeComponent();
        }
        MmasweEntities4 db = new MmasweEntities4();
        private void btnUpload_Click(object sender, EventArgs e)
        {
            Process.Start(@"explorer.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuTypeList menuList = new MenuTypeList();
            menuList.ShowDialog();
        }

        private void cmbMenuItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Menu_And_Combo_Load(object sender, EventArgs e)
        {
            
            
                cmbMenuItemType.ValueMember = "Menu_Item_Type_ID";
                cmbMenuItemType.DisplayMember = "Menu_Item_Description";
                cmbMenuItemType.DataSource = db.Menu_Item_Type.ToList();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string phrase = txtMenuPrice.Text;

            int number;
            bool isNumeric = int.TryParse(phrase, out number);
            if (isNumeric == true)
            {
                Menu_Item item = new Menu_Item();
                Menu_Item_Type type = db.Menu_Item_Type.FirstOrDefault(c => c.Menu_Item_Description == cmbMenuItemType.Text);

                Menu_Item_Price price = new Menu_Item_Price();
                price.Menu_Price = Convert.ToDouble(txtMenuPrice.Text);
                db.Menu_Item_Price.Add(price);

                item.Menu_Item_Name = txtMenuItemName.Text;
                item.Menu_Item_Description = richDescription.Text;
                item.Menu_Item_Type_ID = type.Menu_Item_Type_ID;
                item.Menu_Item_Price = price.Menu_Price;
                item.Menu_Price_ID = price.Menu_Price_ID;
                db.Menu_Item.Add(item);
                db.SaveChanges();

                MessageBox.Show("Menu item added successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Values entered is not in correct format(not numeric)");
            }
            

        }
    }
}
