using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApplication11
{
    public partial class frmEmployeePicture : Form
    {
        public frmEmployeePicture()
        {
            InitializeComponent();
        }
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;

        MmasweEntities5 db = new MmasweEntities5();
        private void frmEmployeePicture_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

       public void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }
        private void button1_Click(object sender,EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // saveFileDialog1.InitialDirectory = @"C:\Users\phindulo\Pictures";
            //if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            // pictureBox1.Image.Save(saveFileDialog1.FileName);
            try
            {
                ItemsPicture itempic = new ItemsPicture();
                {
                    itempic.ItemName = Globals.emNameImage;
                    itempic.imageVar = Globals.ConvertImageToBinary(pictureBox1.Image);
                    itempic.ImageID = Globals.imageIdEmployee;
                    itempic.EmployeeID = Globals.imageIdEmployee;

                    db.ItemsPictures.Add(itempic);
                    db.SaveChanges();
                    Globals.imageIdEmployee = 0;
                    Globals.emNameImage = "";
                    Globals.refresher = true;
                    this.Close();
                }
            }
            catch(Exception i)
            {
                MessageBox.Show(i.ToString());
            }
           // }
        }
    }
}
