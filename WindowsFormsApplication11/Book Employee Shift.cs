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
    public partial class Book_Employee_Shift : Form
    {
        public Book_Employee_Shift()
        {
            InitializeComponent();
        }

        MmasweEntities5 db = new MmasweEntities5();
        dynamic number = 0;

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Book_Employee_Shift_Load(object sender, EventArgs e)
        {
            var items = from obj in db.Employee_Shifts
                        where obj.CooksAllocated != obj.MaximumCooks && obj.CashiersAllocated != obj.MaximumCashiers
                        select new
                        {
                            ShiftID = obj.Employee_Shift_ID,
                            StartTime = obj.Employee_Shift_Start_Time,
                            EndTime = obj.Employee_Shift_End_Time
                        };

            dgvShifts.DataSource = items.ToList();
            dgvShifts.ClearSelection();


        }

        private void dgvShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShifts.SelectedRows.Count > 0)
            {
                int rowindex = dgvShifts.CurrentCell.RowIndex;
                number = dgvShifts.Rows[rowindex].Cells[0].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
