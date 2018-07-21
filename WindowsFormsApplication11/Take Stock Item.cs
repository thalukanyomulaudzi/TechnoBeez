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
    public partial class Take_Stock_Item : Form
    {
        public Take_Stock_Item()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock item taken successfully");
            MessageBox.Show("Stock item details format invalid");
        }
    }
}
