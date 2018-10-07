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
    public partial class Retrieve_Lost_Password : Form
    {
        public Retrieve_Lost_Password()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();
        private void button1_Click(object sender, EventArgs e)
        {
            string username, pass;           ;
            //Retrieve pass
            var q = from f in db.Users
                    join m in db.Employees on f.User_ID equals m.User_ID
                    where m.Email_Adress == txtEmail.ToString()
                    select new
                    {
                        username = f.UserName,

                        pass = f.User_Password

                    };

            if (q.Any())
            {
                SendEmail(txtEmail.Text, username, pass);
                
            }
            else
            {
                MessageBox.Show("Email provided does not exist in the system");
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        public void SendEmail(string e, string usename, string password)
        {

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();

                string myEmail = "thalu.tuks@gmail.com";
                string pswd = "@mulaudzi";
                message.From = new MailAddress(myEmail);
                message.Subject = "Login Details";
                message.Body =" Your retrieved login are as follows :" + "\n Your Login details are: " + "\n Username : " + usename + "\n Password : " + password;

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

        private void button2_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close();
        }
    }
}
