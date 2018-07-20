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
    public partial class Add_New_Stock_Item : Form
    {
        public Add_New_Stock_Item()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock Item added successfully");
            MessageBox.Show("Stock Item details format not valid");
        }
    }
}
