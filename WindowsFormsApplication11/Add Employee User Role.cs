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
    public partial class Add_Employee_User_Role : Form
    {

        public Add_Employee_User_Role()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                User_Role role = new User_Role();
                
                role.User_Role_Description = txtdes.Text;
                role.Access_Level_ID = Convert.ToInt32(cmbAccess.Text);
                db.User_Role.Add(role);
                db.SaveChanges();
                MessageBox.Show("Role added successfully");
            }
            catch(Exception i)
            {
                MessageBox.Show(i.ToString());

            }
               
            

        }

        private void Add_Employee_User_Role_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
