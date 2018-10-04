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
    public partial class update_Employee_Details : Form
    {
        public update_Employee_Details()
        {
            InitializeComponent();
        }

        private void update_Employee_Details_Load(object sender, EventArgs e)
        {
            MmasweEntities5 db = new MmasweEntities5();
            int id = Globals.Employeepassing;
            try
            {
                Employee EmEdited = db.Employees.FirstOrDefault(c => c.Employee_ID == id);

                txtName.Text = EmEdited.Employee_Name;
                txtSurname.Text = EmEdited.Employee_Surname;
                txtAddress.Text = EmEdited.Adress;
                txtNextOfKin.Text = EmEdited.Next_Of_Kin_Name;
                txtNKC.Text = EmEdited.Next_Of_Kin_Contact_Number.ToString();
                txtEmail.Text = EmEdited.Email_Adress;
                txtIdNumber.Text = EmEdited.Employee_ID.ToString();

                ItemsPicture pic = db.ItemsPictures.FirstOrDefault(c => c.EmployeeID == id);
                // Image n = (Bitmap)((new ImageConverter()).ConvertFrom(pic.imageVar));

                pictureBox1.Image = Globals.converBinToImage(pic.imageVar);
            }
            catch(Exception i)
            {
                MessageBox.Show(i.ToString());

            }
        }

        private void btnUpdateEmployeeInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
