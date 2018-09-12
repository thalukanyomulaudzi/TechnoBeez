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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(txtUsername.Text, txtPassword.Text))

            {
                MmasweEntities5 db = new MmasweEntities5();
                txtPassword = null;
                txtUsername = null;
                Form2 F = new Form2();
                User_Log log = new User_Log();
                log.Login_Time = DateTime.Today.TimeOfDay;
                db.User_Log.Add(log);
               
                db.SaveChanges();
                F.Show();
            }
        }
        private bool IsvalidUser(string userName, string password)

        {
            


                MmasweEntities5 db = new MmasweEntities5();

            
                var q = from p in db.Users

                        where p.UserName == txtUsername.Text

                        && p.User_Password == txtPassword.Text

                        select p;



                if (q.Any())
    
               {

                    return true;

                }

                else

                {

                MessageBox.Show("The login details entered are incorrect");
                txtPassword = null;
                txtUsername = null;
                return false;
                

                }
                        
        }

        private void linkLabelRestPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Retrieve_Lost_Password RP = new Retrieve_Lost_Password();
            RP.ShowDialog();
        }
    }
    }
