using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Menu_And_Combo : Form
    {
        public Menu_And_Combo()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Process.Start(@"explorer.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuTypeList menuList = new MenuTypeList();
            menuList.ShowDialog();
        }
    }
}
