using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
namespace WindowsFormsApplication11
{
    public partial class Add_Employee : Form
    {
        
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        MmasweEntities5 db = new MmasweEntities5();

        private void btnSaveCombo_Click(object sender, EventArgs e)
        {
            
            User NewU = new User();
            Employee NewE = new Employee();
            string ges = cmbGender.Text;
            Employee_Gender_ gend = db.Employee_Gender_.FirstOrDefault(c=> c.Gender_Description ==ges );

           

            int gender = cmbGender.SelectedIndex;
            NewE.Employee_Name = txtName.Text;
            NewE.Employee_Surname = txtSurname.Text;
            NewE.Employee_Identity_Number = txtIdNumber.Text;
            NewE.Gender_ID = gend.Gender_ID;
            NewE.Adress = txtAddress.Text;
            NewE.Contact_Number = txtEmpContact.Text;
            NewE.Email_Adress = txtEmail.Text;
            NewE.Next_Of_Kin_Name = txtNextOfKin.Text;
            NewE.Next_Of_Kin_Contact_Number = txtNKC.Text;
            NewE.User_ID = NewU.User_ID;

            //Generate Login Details


            if (txtName.Text.Length >= 3)
            {
                string userprif = txtName.Text.Substring(0, 3);
                Random rd = new Random();
                int number = rd.Next(100, 999);
                string username = userprif + number.ToString();
                NewU.UserName = username;

                int password = rd.Next(10000, 99999);

                NewU.User_Password = password.ToString();

                string r = cmbRole.Text;
                User_Role role = db.User_Role.FirstOrDefault(c => c.User_Role_Description == r);

                NewU.User_Role_ID = role.User_Role_ID;



                //send email to user address with username and password


                SendEmail(txtEmail.Text, txtName.Text, username, password.ToString());
            }
            else
            {
                MessageBox.Show("Error: Name too short");
                return;
                
            }
            db.Employees.Add(NewE);
            db.Users.Add(NewU);
            db.SaveChanges();
            MessageBox.Show("Employee added successfully,employee Login details has been sent to their email address");
            this.Close();

        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            //populate combo boxes
        }
        public void SendEmail(string e,string EmployeeN,string usename ,string password)
        {
            
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();

                string myEmail = "thalu.tuks@gmail.com";
                string pswd = "@mulaudzi";
                message.From = new MailAddress(myEmail);
                message.Subject = "Login Details";
                message.Body = "Hi "+ EmployeeN +" Welcome to the team " + "\n Your Login details are: "+ "\n Username : " + usename +"\n Password : " +password;
               
                message.To.Add(e);
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                client.Credentials = new System.Net.NetworkCredential(myEmail, pswd);
                client.Send(message);
                message = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
