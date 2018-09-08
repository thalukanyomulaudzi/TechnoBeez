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
    public partial class frmMaintainMenuItem : Form
    {
        public frmMaintainMenuItem()
        {
            InitializeComponent();
        }
        MmasweEntities13 db = new MmasweEntities13();

        private void frmMaintainMenuItem_Load(object sender, EventArgs e)
        {
            int id = Globals.MenuCombopassing;
            Menu_Item item = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == id);
            Menu_Item_Type type = db.Menu_Item_Type.FirstOrDefault(c => c.Menu_Item_Type_ID == item.Menu_Price_ID);
            txtMenuItemName.Text = item.Menu_Item_Name;
            txtMenuPrice.Text = Convert.ToString(item.Menu_Item_Price);
            richDescription.Text = item.Menu_Item_Description;
           // cmbMenuItemType.Text = type.Menu_Item_Description;

        }
    }
}
