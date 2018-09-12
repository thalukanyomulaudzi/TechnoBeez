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
    public partial class ListOrders : Form
    {
        MmasweEntities5 db = new MmasweEntities5();
        public ListOrders()
        {
            InitializeComponent();
        }

        private void ListOrders_Load(object sender, EventArgs e)
        {
            //foreach(var orders in Globals.StockOrders)
            //{
            //    TreeNode node = new TreeNode(orders.OrderNo.ToString());
            //    node.Nodes.Add(orders.StockItemName);
            //    treeView1.Nodes.Add(node);
            //}
           


            foreach (var orders in db.Stock_Order)
            {
                Stock_Order so = new Stock_Order();
                Stock_Order_Line sol = db.Stock_Order_Line.Where(x => x.Stock_Order_Line_ID == orders.Stock_Order_ID).FirstOrDefault();

                TreeNode node = new TreeNode("Order No "+orders.Stock_Order_ID.ToString());
                node.Nodes.Add(sol.Stock_Item.Stock_Item_Name);
                treeView1.Nodes.Add(node);
            }
        }
    }
}
