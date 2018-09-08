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
    public partial class Add_Employee : Form
    {
        MmasweEntities5 db = new MmasweEntities5();
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCombo_Click(object sender, EventArgs e)
        {
            Employee NewE = new Employee();
            int gender = comboBox1.SelectedIndex;
            NewE.Employee_Name = txtName.Text;
            NewE.Employee_Surname = txtSurname.Text;
            NewE.Employee_Identity_Number = Convert.ToInt32(txtIdNumber.Text);
            NewE.Gender_ID = gender;
            NewE.Adress = txtAddress.Text;
            NewE.Email_Adress = txtEmail.Text;
            NewE.Next_Of_Kin_Name = txtNextOfKin.Text;
            NewE.Next_Of_Kin_Contact_Number = Convert.ToInt32(txtNKC.Text);

            //Generate Login Details

            User NewU = new User();
            string userprif = txtName.Text.Substring(0, 3);
            Random rd = new Random();
            int number = rd.Next(100, 999);
            NewU.UserName = userprif + number.ToString();
            int password = rd.Next(10000, 99999);

            NewU.User_Password = password.ToString();



            //send email to user address with username and password
            MessageBox.Show("Employee Login details has been sent to their email address");


        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            //populate combo boxes
        }
    }
}
