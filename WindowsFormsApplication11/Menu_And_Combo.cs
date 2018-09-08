using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;

namespace WindowsFormsApplication11
{
    public partial class Menu_And_Combo : Form
    {
        public Menu_And_Combo()
        {
            InitializeComponent();
        }
        MmasweEntities13 db = new MmasweEntities13();
       
        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Process.Start(@"explorer.exe");

            //MenuTypeList menuList = new MenuTypeList();
            //menuList.ShowDialog();

            using (OpenFileDialog fileop = new OpenFileDialog()
            { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (fileop.ShowDialog() == DialogResult.OK)
                {
                    Globals.fileName = fileop.FileName;

                    pictureBox1.Image = Image.FromFile(Globals.fileName);
                }
            }
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

        private /*async*/ void button7_Click(object sender, EventArgs e)
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

                //item.fileName =fileName = ConvertImageToBinary(pictureBox1.Image);

                db.Menu_Item.Add(item);

                //item = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_Name == txtMenuItemName.Text);
                ItemsPicture itempic = new ItemsPicture();
                {
                    itempic.ItemName = item.Menu_Item_Name;
                    itempic.imageVar = Globals.ConvertImageToBinary(pictureBox1.Image);
                    itempic.ImageID = item.Menu_Item_ID;
                    itempic.Menu_Item_ID = item.Menu_Item_ID;
                    db.ItemsPictures.Add(itempic);
                    //db.SaveChanges();
                }




                db.SaveChanges();
                Globals.refresher = true;
                MessageBox.Show("Menu item added successfully");
                txtMenuItemName.Text = "";
                txtMenuPrice.Text = "";
                richDescription.Text = "";
                pictureBox1.Image = null;
             
            }
            else
            {
                MessageBox.Show("Error: Values entered is not in correct format(not numeric)");
            }


        }

        private /*async*/ void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



//Picture retrieval//

//ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == 1);

//pictureBox1.Image = Globals.converBinToImage(pic.imageVar);