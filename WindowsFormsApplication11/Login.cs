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
        MmasweEntities5 db = new MmasweEntities5();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (IsvalidUser(txtUsername.Text, txtPassword.Text))

            //{
            string username = txtUsername.Text;
            string pass = txtPassword.Text;
           
              // txtPassword = null;
                //txtUsername = null;


            User use = db.Users.FirstOrDefault(c => c.UserName == username && c.User_Password == pass);
            if (use != null)
            {
                Globals.LogInTieme = DateTime.Now;
                Globals.LogedUser = use.User_ID;
                Globals.roleID = use.User_Role_ID;
                Globals.roleID = use.User_Role_ID;
                Form2 frm = new Form2();
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Error:Combination not found");
                return;
            }
               
                //db.SaveChanges();
            //   
            //}
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
            this.Hide();
            Retrieve_Lost_Password RP = new Retrieve_Lost_Password();
            RP.Show();
        }
    }
    }
