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

namespace WindowsFormsApplication11
{
    public partial class Menu_And_Combo : Form
    {
        public Menu_And_Combo()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();
        string fileName;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Process.Start(@"explorer.exe");

            MenuTypeList menuList = new MenuTypeList();
            menuList.ShowDialog();

            using (OpenFileDialog fileop = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (fileop.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileop.FileName;

                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
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

        private void button7_Click(object sender, EventArgs e)
        {
            string phrase = txtMenuPrice.Text;

            int number;
            bool isNumeric = int.TryParse(phrase, out number);
            if (isNumeric == true)
            {
                Menu_Item item = new Menu_Item();
                Menu_Item_Type type = db.Menu_Item_Type.FirstOrDefault(c => c.Menu_Item_Description == cmbMenuItemType.Text);

                ItemsPicture itempic = new ItemsPicture();
                {
                  // string name   /*= fileName, Data*/ = ConvertImageToBinary(pictureBox1.Image);


                };
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
