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
    public partial class OrderList : Form
    {
        Form2 mainForm;
        // int index = -1;
        MmasweEntities5 db = new MmasweEntities5();
        public OrderList()
        {
            InitializeComponent();
        }
        public OrderList(Form2 f)
        {
            InitializeComponent();
            mainForm = f;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //ListStockOrderItems m = new ListStockOrderItems(this);
            StockOrder m = new StockOrder(this);
            m.ShowDialog();
        }
        public void load()
        {
            var orderList = from p in db.Stock_Order.Where(x => x.Stock_Order_Status_ID == 1)
                            join q in db.Stock_Order_Line
                                on p.Stock_Order_ID equals q.Stock_Order_ID
                            join x in db.Stock_Order_Status
                                on p.Stock_Order_Status_ID equals x.Stock_Order_Status_ID

                            join y in db.Suppliers
                                on p.Supplier_ID equals y.Supplier_ID

                            select new
                            {
                                Order_No = p.Stock_Order_ID,
                                Stock_Item = q.Stock_Item.Stock_Item_Name,
                                Supplier_Name = y.Supplier_Name,
                                Quantity = q.Stock_Order_Quantity,
                                Order_Date =p.Stock_Order_Issue_Date,
                                Order_Status = x.Stock_Order_Status_Description,
                            };
            
            dgvPlacedOrder.DataSource = orderList.ToList();
            dgvPlacedOrder.ClearSelection();
            db.SaveChanges();

            var orderL = from p in db.Stock_Order.Where(x =>x.Stock_Order_Status_ID==2)
                         join q in db.Stock_Order_Line
                                on p.Stock_Order_ID equals q.Stock_Order_Line_ID
                            join x in db.Stock_Order_Status
                                on p.Stock_Order_Status_ID equals x.Stock_Order_Status_ID

                            join y in db.Suppliers
                                on p.Supplier_ID equals y.Supplier_ID

                            select new
                            {
                                Order_No = p.Stock_Order_ID,
                                Stock_Item = q.Stock_Item.Stock_Item_Name,
                                Supplier_Name = y.Supplier_Name,
                                QuantityReceived = q.Stock_Order_Quantity,
                                Order_Date = p.Stock_Order_Issue_Date,
                               // Date_Received = p.DateReceived ?? DateTime.Now,
                            };

            dgvReceivedOrder.DataSource = orderL.ToList();
           dgvReceivedOrder.ClearSelection();
            db.SaveChanges();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
           load();
           dgvPlacedOrder.MouseClick += new MouseEventHandler(mouse_click);
            //loadReceivedOrder();
        }
        void mouse_click(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
            }
            else
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int position_xy = dgvPlacedOrder.HitTest(e.X, e.Y).RowIndex;

                if (position_xy >= 0)
                {
                    my_menu.Items.Add("Order Received").Name = "Received";

                    my_menu.Show(dgvPlacedOrder, new Point(e.X, e.Y));
                    int index = int.Parse(dgvPlacedOrder.Rows[position_xy].Cells[0].Value.ToString());

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler((x, y) => right_click(x, y, index, my_menu));
                }
            }
        }

        void right_click(Object sender, ToolStripItemClickedEventArgs e, int index, ContextMenuStrip my_menu)
        {
            if (e.ClickedItem.Name.ToString() == "Received")
            {
                my_menu.Hide();
                if (MessageBox.Show("Are you sure Order is received?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    UpdateOrder(index);
                    MessageBox.Show("Order Received");
                }
            }
        }
        void UpdateOrder(int index)
        {
           
            var order = db.Stock_Order.Where(x => x.Stock_Order_ID == index).Single<Stock_Order>();
            //order.DateReceived = DateTime.Now;
            order.Stock_Order_Status_ID = 2;

           // Stock_Order_Line orderLine = new Stock_Order_Line();
            var orderL = db.Stock_Order_Line.Where(x => x.Stock_Order_Line_ID == order.Stock_Order_ID).SingleOrDefault<Stock_Order_Line>();
            var stock = db.Stock_Item.Where(x => x.Stock_ID ==orderL.Stock_ID).Single<Stock_Item>();
            stock.Stock_Item_Quantity += orderL.Stock_Order_Quantity;
            db.SaveChanges();
            load();
            mainForm.LoadStock();
        }
    }
}
