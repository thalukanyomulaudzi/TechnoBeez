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
    public partial class Write_Off_stock_Item : Form
    {
        public Write_Off_stock_Item()
        {
            InitializeComponent();
        }

        private void Write_Off_stock_Item_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock item written off successfully");
            MessageBox.Show("Stock item details format invalid");
        }
    }
}
