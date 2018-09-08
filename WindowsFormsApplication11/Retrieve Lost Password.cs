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

        private void button1_Click(object sender, EventArgs e)
        {
            //Send password to email address


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
    }
}
