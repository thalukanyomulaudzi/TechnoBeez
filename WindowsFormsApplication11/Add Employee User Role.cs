﻿using System;
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Employee_User_Role_Load(object sender, EventArgs e)
        {
            User_Role role = new User_Role();
            role.User_Role_Description = txtdes.Text;
            
        }
    }
}
