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
    public partial class frmMaintain_Menu_Item : Form
    {
        public frmMaintain_Menu_Item()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileop = new OpenFileDialog()
            { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (fileop.ShowDialog() == DialogResult.OK)
                {
                    Globals.fileName = fileop.FileName;

                    pictureBox1.Image = Image.FromFile(Globals.fileName);
                    Globals.browse = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string phrase = txtMenuPrice.Text;

            int number;
            bool isNumeric = int.TryParse(phrase, out number);
            if (isNumeric == true)
            {
                int id = Globals.MenuCombopassing;
                Menu_Item item = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == id);
                Menu_Item_Type type = db.Menu_Item_Type.FirstOrDefault(c => c.Menu_Item_Description == cmbMenuItemType.Text);


                Menu_Item_Price price = db.Menu_Item_Price.FirstOrDefault(c => c.Menu_Price_ID == id);
                price.Menu_Price = Convert.ToDouble(txtMenuPrice.Text);
               // db.Menu_Item_Price.Add(price);

                item.Menu_Item_Name = txtMenuItemName.Text;
                item.Menu_Item_Description = richDescription.Text;
                item.Menu_Item_Type_ID = type.Menu_Item_Type_ID;
                item.Menu_Item_Price = price.Menu_Price;
                item.Menu_Price_ID = price.Menu_Price_ID;

                //item.fileName =fileName = ConvertImageToBinary(pictureBox1.Image);

                // db.Menu_Item.Add(item);

                //item = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_Name == txtMenuItemName.Text);
                ItemsPicture itempic = db.ItemsPictures.FirstOrDefault(c => c.Menu_Item_ID == id);
                {

                    if ((Globals.browse == true) && (itempic != null))
                    {
                        itempic.ItemName = Globals.fileName;
                        itempic.imageVar = Globals.ConvertImageToBinary(pictureBox1.Image);
                        // itempic.ImageID = item.Combo_ID;
                        // Globals.browse = false;

                    }
                   



                }
                //itempic.ImageID = item.Menu_Item_ID;
                // itempic.Menu_Item_ID = item.Menu_Item_ID;
                //db.ItemsPictures.Add(itempic);






                db.SaveChanges();
                Globals.refresher = true;
                MessageBox.Show("Menu item updated successfully");
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Error: Values entered is not in correct format(not numeric)");
            }
        }

        private void frmMaintain_Menu_Item_Load(object sender, EventArgs e)
        {



            cmbMenuItemType.ValueMember = "Menu_Item_Type_ID";
            cmbMenuItemType.DisplayMember = "Menu_Item_Description";

            cmbMenuItemType.DataSource = db.Menu_Item_Type.ToList();
            int id = Globals.MenuCombopassing;
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.Menu_Item_ID == id);
            // Image n = (Bitmap)((new ImageConverter()).ConvertFrom(pic.imageVar));
            Menu_Item item = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == id);
            Menu_Item_Price price = db.Menu_Item_Price.FirstOrDefault(c => c.Menu_Price_ID == id);
            Menu_Item_Type type = db.Menu_Item_Type.FirstOrDefault(c => c.Menu_Item_Type_ID == item.Menu_Item_Type_ID);

            pictureBox1.Image = Globals.converBinToImage(pic.imageVar);
            txtMenuItemName.Text = item.Menu_Item_Name;
            txtMenuPrice.Text = Convert.ToString(price.Menu_Price);
            cmbMenuItemType.Text = type.Menu_Item_Description;
            richDescription.Text = item.Menu_Item_Description;
            Globals.browse = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
