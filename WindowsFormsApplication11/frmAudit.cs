using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Threading;

namespace WindowsFormsApplication11
{
    public partial class frmAudit : Form
    {
        public frmAudit()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();
        private void frmAudit_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            lblState.Visible = false;

            auditBindingSource2.DataSource = db.Audits.ToList();
        }

        private void dgvAuditList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAuditDetails.DataSource = null;
            dgvAuditDetails.Rows.Clear();
            int rowindex = dgvAuditList.CurrentCell.RowIndex;
            dynamic value  = dgvAuditList.Rows[rowindex].Cells[0].Value;
            if (value != null)
            {
                int v = value;
                Audit t = db.Audits.FirstOrDefault(c => c.Audit_ID == v);
                if (t.Audit_Description == "Order Processing")
                {
                    var Menus = from obj in db.Customer_Order_Line
                                join obj2 in db.Customer_Order
                                on obj.Customer_Order_ID equals obj2.Order_ID
                                where (obj.Menu_Item_ID != null && obj2.Order_ID == t.transactionNumber)
                                select new
                                {
                                    Id = obj.Menu_Item_ID,
                                    Quantity1 = obj.Menu_Item_Quantity

                                };

                    var Combos = from obj in db.Customer_Order_Line
                                 join obj2 in db.Customer_Order
                                 on obj.Customer_Order_ID equals obj2.Order_ID
                                 where (obj.Combo_ID != null && obj2.Order_ID == t.transactionNumber)
                                 select new
                                 {
                                     Id = obj.Combo_ID,
                                     Quantity1 = obj.Combo_Quantity

                                 };

                    var Stocks = from obj in db.Customer_Order_Line
                                 join obj2 in db.Customer_Order
                                 on obj.Customer_Order_ID equals obj2.Order_ID
                                 where (obj.Stock_ID != null && obj2.Order_ID == t.transactionNumber)
                                 select new
                                 {
                                     Id = obj.Stock_ID,
                                     Quantity1 = obj.Stock_Item_Quantity

                                 };



                    foreach (var i in Menus)
                    {
                        Menu_Item m = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == i.Id);
                        this.dgvAuditDetails.Rows.Add(m.Menu_Item_Name, i.Quantity1);
                    }

                    foreach (var i in Combos)
                    {
                        Combo m = db.Comboes.FirstOrDefault(c => c.Combo_ID == i.Id);
                        this.dgvAuditDetails.Rows.Add(m.Combo_Name, i.Quantity1);

                    }

                    foreach (var i in Stocks)
                    {
                        Stock_Item m = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == i.Id);
                        this.dgvAuditDetails.Rows.Add(m.Stock_Item_Name, i.Quantity1);

                    }
                }

                else if (t.Audit_Description == "Order Saving")
                {
                    var Menus = from obj in db.DeliveryLines
                                join obj2 in db.DeliveryTables
                                on obj.orderId equals obj2.OrderId
                                where (obj.menuItemId != null && obj2.OrderId == t.transactionNumber)
                                select new
                                {
                                    Id = obj.menuItemId,
                                    Quantity1 = obj.menuItemQuantity

                                };

                    var Combos = from obj in db.DeliveryLines
                                 join obj2 in db.DeliveryTables
                                 on obj.orderId equals obj2.OrderId
                                 where (obj.comboItemId != null && obj2.OrderId == t.transactionNumber)
                                 select new
                                 {
                                     Id = obj.comboItemId,
                                     Quantity1 = obj.comboItemQuantity

                                 };

                    var Stocks = from obj in db.DeliveryLines
                                 join obj2 in db.DeliveryTables
                                 on obj.orderId equals obj2.OrderId
                                 where (obj.stockItemId != null && obj2.OrderId == t.transactionNumber)
                                 select new
                                 {
                                     Id = obj.stockItemId,
                                     Quantity1 = obj.stockItemQuantity

                                 };



                    foreach (var i in Menus)
                    {
                        Menu_Item m = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == i.Id);
                        this.dgvAuditDetails.Rows.Add(m.Menu_Item_Name, i.Quantity1);
                    }

                    foreach (var i in Combos)
                    {
                        Combo m = db.Comboes.FirstOrDefault(c => c.Combo_ID == i.Id);
                        this.dgvAuditDetails.Rows.Add(m.Combo_Name, i.Quantity1);

                    }

                    foreach (var i in Stocks)
                    {
                        Stock_Item m = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == i.Id);
                        this.dgvAuditDetails.Rows.Add(m.Stock_Item_Name, i.Quantity1);

                    }
                }

                else if (t.Audit_Description == "Stock_Item_Write_Off")
                {
                    Stock_WriteOff_Line w = db.Stock_WriteOff_Line.FirstOrDefault(c => c.Stock_WriteOff_LineID == t.transactionNumber);
                    Stock_Item s = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == w.Stock_ID);
                    this.dgvAuditDetails.Rows.Add(s.Stock_Item_Name, w.Quantity);

                }
                else if (t.Audit_Description == "Item_CheckIn")
                {
                    Check_In_Line w = db.Check_In_Line.FirstOrDefault(c => c.Check_In_Line_ID == t.transactionNumber);
                    Stock_Item s = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == w.Stock_ID);
                    this.dgvAuditDetails.Rows.Add(s.Stock_Item_Name, w.Quantity);

                }

                else if (t.Audit_Description == "Item_CheckOut")
                {
                    Check_Out_Line w = db.Check_Out_Line.FirstOrDefault(c => c.Check_Out_ID == t.transactionNumber);
                    Stock_Item s = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == w.Stock_ID);
                    this.dgvAuditDetails.Rows.Add(s.Stock_Item_Name, w.Quaantity);

                }
            }

        }

        struct DataParameter
        {
            public List<Audit> AuditList;
            public string FileName { get; set; }
                
        }

        DataParameter _inputParameter;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            List<Audit> list = ((DataParameter)e.Argument).AuditList;
            string FileName = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application Ex = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Ex.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Ex.ActiveSheet;

            Ex.Visible = false;
            int index = 1;
            
            //MessageBox.Show(list.Count.ToString());
            int process = list.Count;

            ws.Cells[1, 1] = "AuditID";
            ws.Cells[1, 2] = "AuditName";
            ws.Cells[1, 3] = "AuditDescription";
            ws.Cells[1, 4] = "TransactionNumber";
            ws.Cells[1, 1] = "AuditTable";
            ws.Cells[1, 1] = "AuditDate";

            foreach (Audit p in list)
            {
                if(!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = p.Audit_ID.ToString();
                    ws.Cells[index, 2] = p.Audit_Name;
                    ws.Cells[index, 3] = p.Audit_Description;
                    ws.Cells[index, 4] = p.Audit_Table;
                    ws.Cells[index, 5] = p.transactionNumber.ToString();
                    ws.Cells[index, 6] = p.auditDate.ToString();
                    
                }

            }

            ws.SaveAs(FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            Ex.Quit();


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblState.Text = string.Format("Processing...{0}", e.ProgressPercentage);
            progressBar1.Update();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error == null)
            {
                Thread.Sleep(100);
                lblState.Text = "Your data has been successfully exported.";
                Thread.Sleep(50);
                progressBar1.Visible = false;
                lblState.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                return;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Audits |*.xls" })
            {
                if(sfd.ShowDialog()== DialogResult.OK)
                {
                    progressBar1.Visible = true;
                    lblState.Visible = true;
                    _inputParameter.FileName = sfd.FileName;
                    _inputParameter.AuditList = auditBindingSource2.DataSource as List<Audit>;

                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(_inputParameter);
                }
            }
        }

        private void txtSeachAudit_TextChanged(object sender, EventArgs e)
        {






            int id = 900000000;
            string Quantity = "900000000";
            int Cont = 900000000;
            if (!(txtSeachAudit.Text == ""))
            {
                int number;
                bool result = Int32.TryParse(txtSeachAudit.Text, out number);
                if (result)
                {
                    // Conversion to a number was successful.
                    // The number variable contains your value. 
                    id = Convert.ToInt32(txtSeachAudit.Text);
                    Quantity = txtSeachAudit.Text;
                }
                else
                {
                    id = 900000000;
                    Quantity = "900000000";
                    Cont = 900000000;

                }
                

                            dgvAuditList.DataSource = db.Audits.Where(c=> c.Audit_ID == id || c.Audit_Name.Contains(txtSeachAudit.Text)
                            || c.Audit_Description.Contains(txtSeachAudit.Text) || c.Audit_Table.Contains(txtSeachAudit.Text)
                            || c.auditDate == dtDate.Value || c.transactionNumber == id).ToList();
            }
            else
            {
                dgvAuditList.DataSource = db.Audits.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
