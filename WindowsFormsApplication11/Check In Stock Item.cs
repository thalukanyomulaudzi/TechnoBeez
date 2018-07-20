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
    public partial class Check_In_Stock_Item : Form
    {
        public Check_In_Stock_Item()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock Item checked in successfully");
            MessageBox.Show("Stock Item details format not valid");
        }
    }
}
