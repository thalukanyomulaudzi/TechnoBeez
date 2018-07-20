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
    public partial class Maintain_Stock_Item : Form
    {
        public Maintain_Stock_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock Item updated successfully");
            MessageBox.Show("Stock Item details format not valid");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock Item deleted successfully");
        }
    }
}
