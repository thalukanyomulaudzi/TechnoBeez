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
    public partial class Customer_Order : Form
    {
        public Customer_Order()
        {
            InitializeComponent();
        }

        private void Customer_Order_Load(object sender, EventArgs e)
        {
            dataGridView1.MouseClick += new MouseEventHandler(mouse_click);
        }
        void mouse_click(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Start Order").Name = "Started";
                    myMenu.Items.Add("Complete Order").Name = "Completed";
                }


                myMenu.Show(dataGridView1, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);

            }
        }
        void myMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            deleteForm deleteF = new deleteForm();

            if (e.ClickedItem.Name.ToString() == "Started")
            {
                MessageBox.Show(e.ClickedItem.Name.ToString());
            }
            else if(e.ClickedItem.Name.ToString() == "Completed")
            {
                MessageBox.Show(e.ClickedItem.Name.ToString());
            }


        }

    }
}
