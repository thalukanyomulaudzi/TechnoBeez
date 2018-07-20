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
    public partial class SalesAndOrdering : Form
    {
        public SalesAndOrdering()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_Order cus = new Customer_Order();
            cus.ShowDialog();
        }
    }
}
