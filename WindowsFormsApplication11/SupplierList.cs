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
    public partial class SupplierList : Form
    {
        StockOrder parent;
        MmasweEntities13 db = new MmasweEntities13();
        public SupplierList()
        {
            InitializeComponent();
        }
        public SupplierList(StockOrder f)
        {
            InitializeComponent();
            parent = f;
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            ListSupplier();
        }
        public void ListSupplier()
        {
            var customers = from p in db.Suppliers
                            join q in db.Addresses
                                on p.Supplier_ID equals q.Supplier_ID

                            join y in db.Supplier_Contact_Details
                                on p.Supplier_ID equals y.Supplier_ID
                            select new
                            {
                                SupplierId = p.Supplier_ID,
                                SupplierName = p.Supplier_Name,
                                SupplierEmail = y.Supplier_Email_Adress,
                                SupplierContactNumber = y.Supplier_Contact_Number,
                                Province = q.Province,
                            };
            dgvListSupplier.DataSource = customers.ToList();
            dgvListSupplier.ClearSelection();
            db.SaveChanges();

            dgvListSupplier.MouseClick += new MouseEventHandler(mouse_click);
        }
        void mouse_click(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int position_xy = dgvListSupplier.HitTest(e.X, e.Y).RowIndex;

                if (position_xy >= 0)
                {
                    int index = int.Parse(dgvListSupplier.Rows[position_xy].Cells[0].Value.ToString());
                    parent.supplier(index);
                    this.Close();
                }
            }
        }
    }
}
