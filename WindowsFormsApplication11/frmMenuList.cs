using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApplication11
{
    public partial class frmMenuList : Form
    {
        public frmMenuList()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();
        int detector = 0;
        dynamic id2 = 0;
        private void frmMenuList_Load(object sender, EventArgs e)
        {
            dynamic items = from obj in db.Menu_Item
                            select new
                            {
                                Id = obj.Menu_Item_ID,
                                Name = obj.Menu_Item_Name
                                

                            };

            dynamic items2 = from obj in db.Comboes
                        select new
                        {
                            Id = obj.Combo_ID,
                            Name = obj.Combo_Name
                           

                        };
            
          foreach(var i in items)
            {
                this.dgvDDisplayImages.Rows.Add(i.Id,i.Name);
            }

            foreach (var i in items2)
            {
                this.dgvDDisplayImages.Rows.Add(i.Id, i.Name);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //if (id2 == 1) { 
                
               
            // }
            int dent = id2;
           
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx1.Image = Globals.converBinToImage(pic.imageVar);
                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val   = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl1.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }

        }

        private void dgvDDisplayImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDDisplayImages.SelectedRows.Count > 0)
            {

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                id2 = dgvDDisplayImages.Rows[rowindex].Cells[0].Value;

              

            }
        }

        private void dgvDDisplayImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
            //id2 = dgvDDisplayImages.Rows[rowindex].Cells[0].Value;

            //MessageBox.Show(id2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int dent = id2;
          
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx2.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl2.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int dent = id2;
           // MessageBox.Show(dent.ToString());
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx3.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl3.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int dent = id2;
           // MessageBox.Show(dent.ToString());
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx4.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl4.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int dent = id2;
            //MessageBox.Show(dent.ToString());
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx5.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl5.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dent = id2;
           // MessageBox.Show(dent.ToString());
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx6.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl6.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dent = id2;
           // MessageBox.Show(dent.ToString());
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx7.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl7.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dent = id2;
            //MessageBox.Show(dent.ToString());
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx8.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl8.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dent = id2;
            //MessageBox.Show(dent.ToString());
            ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.ImageID == dent);
            if (pic != null)
            {
                pbx9.Image = Globals.converBinToImage(pic.imageVar);

                int rowindex = dgvDDisplayImages.CurrentCell.RowIndex;
                dynamic val = dgvDDisplayImages.Rows[rowindex].Cells[1].Value;
                lbl9.Text = val;
            }

            else
            {
                MessageBox.Show("Picture not found");
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
           

            if(btnHide.Text == "Hide Buttons")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
                btn6.Visible = false;
                btn7.Visible = false;
                btn8.Visible = false;
                btn9.Visible = false;

                dgvDDisplayImages.Visible = false;
                lblHint.Visible = false;
            
                btnHide.Text = "Show Buttons";
            }
            else if(btnHide.Text == "Show Buttons")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;
                btn5.Visible = true;
                btn6.Visible = true;
                btn7.Visible = true;
                btn8.Visible = true;
                btn9.Visible = true;
                dgvDDisplayImages.Visible = true;
                lblHint.Visible = true;
                btnHide.Text = "Hide Buttons";
            }

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

            Bitmap bit = new Bitmap(this.Width,this.Height);
            DrawToBitmap(bit,new Rectangle(0,0,bit.Width,bit.Height));
            bit.Save("C:\\Users\\phindulo\\Pictures\\Menu.jpeg",ImageFormat.Jpeg);

        }
    }
}
