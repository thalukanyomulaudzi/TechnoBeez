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
    public partial class StockOrder : Form
    {
        public StockOrder()
        {
            InitializeComponent();
        }

        private void btnSelectStock_Click(object sender, EventArgs e)
        {
            Stock_ItemList f = new Stock_ItemList();
            f.ShowDialog();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            SupplierList f = new SupplierList();
            f.ShowDialog();
        }
    }
}
