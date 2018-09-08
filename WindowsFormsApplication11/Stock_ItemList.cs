//using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication11
{
    public partial class Stock_ItemList : Form
    {
        MmasweEntities13 db = new MmasweEntities13();
        StockOrder order;
        public Stock_ItemList()
        {
            InitializeComponent();
        }
        public Stock_ItemList(StockOrder f)
        {
            InitializeComponent();
            order = f;
        }

        private void Stock_ItemList_Load(object sender, EventArgs e)
        {


            var stockList = from p in db.Stock_Item
                            join q in db.Stock_Price
                                on p.Stock_ID equals q.Stock_Price_ID
                            //join r in db.Stock_Type
                            //    on p.Stock_ID equals r.Stock_Type_ID
                            select new
                            {
                                StockId = p.Stock_ID,
                                StockItemName = p.Stock_Item_Name,
                                AvailableQuantity = p.Stock_Item_Quantity,
                                StockDescription = p.Stock_Item_Description,
                                //StockType = r.Stock_Type_Description,
                                StockPrice = q.Stock_Price1,
                            };

    

            dgvListStock.DataSource = stockList.ToList(); 
            dgvListStock.ClearSelection();
            db.SaveChanges();

            //MessageBox.Show("hahahahaha");

            dgvListStock.MouseClick += new MouseEventHandler(mouse_click);
        }
        void mouse_click(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int position_xy = dgvListStock.HitTest(e.X, e.Y).RowIndex;

                if (position_xy >= 0)
                {
                    int index = int.Parse(dgvListStock.Rows[position_xy].Cells[0].Value.ToString());
                    order.stock(index);
                    this.Close();
                }
            }
        }
    } 
}
