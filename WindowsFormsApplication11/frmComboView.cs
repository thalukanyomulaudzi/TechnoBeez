using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication11
{
    public partial class frmComboView : Form
    {
        public frmComboView()
        {
            InitializeComponent();
        }

        MmasweEntities5 db = new MmasweEntities5();

        private void frmComboView_Load(object sender, EventArgs e)
        {
            listBox1.Text = "";
           // MessageBox.Show(Convert.ToString(listBox1.Items.Count));
            cmbComboType.ValueMember = "Combo_Type_ID";
            cmbComboType.DisplayMember = "Combo_Description";
            cmbComboType.DataSource = db.Combo_Type.ToList();
            
            var items = from obj in db.Menu_Item
                        join obj2 in db.Menu_Item_Price
                        on obj.Menu_Item_ID equals obj2.Menu_Price_ID
                       

                        select new
                        {
                            ItemID = obj.Menu_Item_ID,
                            ItemName = obj.Menu_Item_Name,
                            ItemPrice = obj2.Menu_Price,
                            ItemDescription = obj.Menu_Item_Description

                        };

            dgvMenu.ForeColor = Color.Black;
            dgvMenu.DataSource = items.ToList();
            dgvMenu.ClearSelection();

            var items2 = from obj in db.Stock_Item
                         join obj2 in db.Stock_Price
                         on obj.Stock_ID equals obj2.Stock_Price_ID
                         select new
                         {
                             ItemID = obj.Stock_ID,
                             ItemName = obj.Stock_Item_Name,
                             ItemPrice = obj2.Stock_Price1,
                             ItemDescription = obj.Stock_Item_Description

                         };
            dgvProd.ForeColor = Color.Black;
            dgvProd.DataSource = items2.ToList();
            dgvProd.ClearSelection();

            int id = Globals.Combopassing;
            Combo selItem = db.Comboes.FirstOrDefault(c=> c.Combo_ID == id);
            
            string[] vals = Regex.Split(selItem.Combo_Description, "\n");

            for(int i = 0;i< vals.Length;i++)
            {
                 listBox1.Items.Add(vals[i]);

                //MessageBox.Show(vals[i]);

            }
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c=> c.Combo_Item_ID == id);
           // Image n = (Bitmap)((new ImageConverter()).ConvertFrom(pic.imageVar));

            pbxCombo.Image = Globals.converBinToImage(pic.imageVar);
            txtComboName.Text = selItem.Combo_Name;
            txtComboPrice.Text = Convert.ToString(selItem.Combo_Price);
            Globals.browse = false;





        }

        private void btnSaveCombo_Click(object sender, EventArgs e)
        {
            if (pbxCombo.Image != null)
            {
                string phrase = txtComboPrice.Text;

                double number;
                bool isNumeric = double.TryParse(phrase, out number);
                if (isNumeric == true)
                {
                    if ((Convert.ToDouble(txtComboPrice.Text) > 0) && (txtComboName.Text != ""))
                    {
                        if ((listBox1.Items.Count > 0) /*&& (listBox1.Text != "")*/)
                        {
                            int id = Globals.Combopassing;
                            Combo_Price price = db.Combo_Price.FirstOrDefault(c => c.Combo_Price_ID == id);

                            price.Combo_Price1 = Convert.ToDouble(txtComboPrice.Text);
                            price.Combo_Price_Date = DateTime.Today;
                            //db.Combo_Price.Add(price);

                            int num = listBox1.Items.Count;
                            string str = "";
                            for (int i = 0; i < num; i++)
                            {
                                str = str + listBox1.Items[i].ToString();
                            }

                       

                            Combo_Type type = db.Combo_Type.FirstOrDefault(c => c.Combo_Description == cmbComboType.Text);
                            Combo item = db.Comboes.FirstOrDefault(c => c.Combo_Price_ID == id);
                            item.Combo_Name = txtComboName.Text;
                            item.Combo_Price = Convert.ToDouble(txtComboPrice.Text);
                            item.Combo_Description = str;
                            item.Combo_Type_ID = type.Combo_Type_ID;
                            item.Combo_Price_ID = price.Combo_Price_ID;

                            //MessageBox.Show(item.Combo_Description);

                            // db.Comboes.Add(item);
                            ItemsPicture itempic = db.ItemsPictures.FirstOrDefault(c => c.Combo_Item_ID == id);
                            {

                                if (Globals.browse == true)
                                {
                                    itempic.ItemName = Globals.fileName;
                                    itempic.imageVar = Globals.ConvertImageToBinary(pbxCombo.Image);
                                    // itempic.ImageID = item.Combo_ID;
                                   // Globals.browse = false;

                                }



                            }

                            db.SaveChanges();
                            MessageBox.Show("Combo item updated successfully");
                            Globals.refresher = true;


                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error:No items added");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Error:Price value too large OR less thatn zero/Combo name field is empty");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Price not in correct format");
                }
            }
            else
            {
                MessageBox.Show("Upload a picture");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string phrase = txtQuantity.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if (isNumeric == true)
            {
                if (rowindex != -1)
                {
                    if (Convert.ToInt32(txtQuantity.Text) > 0)
                    {
                        string item = "ItemName: " + name + "    --    ItemID: " + Convert.ToString(id) + "    --    ItemQuantity: " + txtQuantity.Text + " \n";
                        listBox1.Items.Add(item);
                        txtQuantity.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error:The quantity is not valid or No quantity provided");
                    }
                }
                else
                {
                    MessageBox.Show("Error:No item selected");
                }
            }
            else
            {
                MessageBox.Show("Error:Enter a numeric value or No quantity provided");
            }
        }
        int rowindex = -1;
        dynamic id;
        dynamic name;


        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = dgvProd.CurrentCell.RowIndex;
            id = dgvProd.Rows[rowindex].Cells[0].Value;
            name = dgvProd.Rows[rowindex].Cells[1].Value;
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = dgvProd.CurrentCell.RowIndex;
            id = dgvProd.Rows[rowindex].Cells[0].Value;
            name = dgvProd.Rows[rowindex].Cells[1].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                listBox1.Items.Remove(s);
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int id = 900000000;

            if (!(txtSearch.Text == ""))
            {
                int number;
                bool result = Int32.TryParse(txtSearch.Text, out number);
                if (result)
                {

                    id = Convert.ToInt32(txtSearch.Text);

                }
                else
                {
                    id = 900000000;


                }
                var items = from obj in db.Menu_Item
                            join obj2 in db.Menu_Item_Price
                            on obj.Menu_Item_ID equals obj2.Menu_Price_ID
                            where (obj.Menu_Item_ID == id || obj.Menu_Item_Name.Contains(txtSearch.Text)
                            || obj.Menu_Item_Description.Contains(txtSearch.Text))

                            select new
                            {
                                ItemID = obj.Menu_Item_ID,
                                ItemName = obj.Menu_Item_Name,
                                ItemPrice = obj2.Menu_Price,
                                ItemDescription = obj.Menu_Item_Description

                            };

                dgvMenu.ForeColor = Color.Black;
                dgvMenu.DataSource = items.ToList();

            }

            else
            {

                var items = from obj in db.Menu_Item
                            join obj2 in db.Menu_Item_Price
                             on obj.Menu_Item_ID equals obj2.Menu_Price_ID
                            //where obj.Menu_Item_ID ==obj2.Menu_Price_ID

                            select new
                            {
                                ItemID = obj.Menu_Item_ID,
                                ItemName = obj.Menu_Item_Name,
                                ItemPrice = obj2.Menu_Price,
                                ItemDescription = obj.Menu_Item_Description

                            };

                dgvMenu.ForeColor = Color.Black;
                dgvMenu.DataSource = items.ToList();
                dgvMenu.ClearSelection();
            }
        }

        private void txtSearchNew_TextChanged(object sender, EventArgs e)
        {
            int id = 900000000;

            if (!(txtSearchNew.Text == ""))
            {
                int number;
                bool result = Int32.TryParse(txtSearchNew.Text, out number);
                if (result)
                {

                    id = Convert.ToInt32(txtSearchNew.Text);

                }
                else
                {
                    id = 900000000;


                }
                var items = from obj in db.Stock_Item
                            join obj2 in db.Stock_Price
                            on obj.Stock_ID equals obj2.Stock_Price_ID
                            where (obj.Stock_ID == id || obj.Stock_Item_Name.Contains(txtSearchNew.Text)
                            || obj.Stock_Item_Description.Contains(txtSearchNew.Text))

                            select new
                            {
                                ItemID = obj.Stock_ID,
                                ItemName = obj.Stock_Item_Name,
                                ItemPrice = obj2.Stock_Price1,
                                ItemDescription = obj.Stock_Item_Description

                            };

                dgvProd.ForeColor = Color.Black;
                dgvProd.DataSource = items.ToList();

            }

            else
            {
                var items2 = from obj in db.Stock_Item
                             join obj2 in db.Stock_Price
                             on obj.Stock_ID equals obj2.Stock_Price_ID
                             select new
                             {
                                 ItemID = obj.Stock_ID,
                                 ItemName = obj.Stock_Item_Name,
                                 ItemPrice = obj2.Stock_Price1,
                                 ItemDescription = obj.Stock_Item_Description

                             };
                dgvProd.ForeColor = Color.Black;
                dgvProd.DataSource = items2.ToList();
                dgvProd.ClearSelection();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog fileop = new OpenFileDialog()
            { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (fileop.ShowDialog() == DialogResult.OK)
                {
                    Globals.fileName = fileop.FileName;

                    pbxCombo.Image = Image.FromFile(Globals.fileName);
                    Globals.browse = true; 
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
