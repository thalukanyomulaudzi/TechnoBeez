using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
//using System.Drawing.fo




namespace WindowsFormsApplication11
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();
        DataTable dt = new DataTable();
        private void frmReports_Load(object sender, EventArgs e)
        {
            var items = from objecT in db.Check_In
                        join objecT2 in db.Check_In_Line
                        on objecT.Check_In_ID equals objecT2.Check_In_ID
                        select new
                        {
                            CheckInId = objecT.Check_In_ID,
                            CheckInDate = objecT.Check_In_Date,
                            ItemName = objecT.Stock_Item_Name,
                            CheckInQuantity = objecT2.Quantity

                        };

            dgvReports.DataSource = items.ToList();
            dgvReports.ClearSelection();
            DataTable MakeDataTable()
            {
                //Create friend table object
                DataTable friend = new DataTable();

                //Define columns
                friend.Columns.Add("CheckInId");
                friend.Columns.Add("CheckInDate");
                friend.Columns.Add("ItemName");
                friend.Columns.Add("CheckInQuantity");

                //Populate with friends :)
                foreach (var i in items)
                {
                    friend.Rows.Add(i.CheckInId.ToString(), i.CheckInDate.ToString(), i.ItemName.ToString(), i.CheckInQuantity.ToString());
                }


                return friend;
            }

            dt = MakeDataTable();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var items = from objecT in db.Check_Out
                        join objecT2 in db.Check_Out_Line
                        on objecT.Check_Out_ID equals objecT2.Check_Out_ID
                        select new
                        {
                            CheckOutId = objecT.Check_Out_ID,
                            CheckOutDate = objecT.Check_Out_Date,
                            ItemName = objecT.Stock_Item_Name,
                            CheckOutQuantity = objecT2.Quaantity

                        };

            dgvReports.DataSource = items.ToList();
            dgvReports.ClearSelection();

            DataTable MakeDataTable()
            {
                //Create friend table object
                DataTable friend = new DataTable();

                //Define columns
                friend.Columns.Add("CheckOutId");
                friend.Columns.Add("CheckOutDate");
                friend.Columns.Add("ItemName");
                friend.Columns.Add("CheckOutQuantity");

                //Populate with friends :)
                foreach (var i in items)
                {
                    friend.Rows.Add(i.CheckOutId.ToString(), i.CheckOutDate.ToString(), i.ItemName.ToString(), i.CheckOutQuantity.ToString());
                }


                return friend;
            }

            dt = MakeDataTable();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = from objecT in db.Check_In
                        join objecT2 in db.Check_In_Line
                        on objecT.Check_In_ID equals objecT2.Check_In_ID
                        select new
                        {
                            CheckInId = objecT.Check_In_ID,
                            CheckInDate = objecT.Check_In_Date,
                            ItemName = objecT.Stock_Item_Name,
                            CheckInQuantity = objecT2.Quantity

                        };

            dgvReports.DataSource = items.ToList();
            dgvReports.ClearSelection();
            DataTable MakeDataTable()
            {
                //Create friend table object
                DataTable friend = new DataTable();

                //Define columns
                friend.Columns.Add("CheckInId");
                friend.Columns.Add("CheckInDate");
                friend.Columns.Add("ItemName");
                friend.Columns.Add("CheckInQuantity");

                //Populate with friends :)
                foreach (var i in items)
                {
                    friend.Rows.Add(i.CheckInId.ToString(), i.CheckInDate.ToString(), i.ItemName.ToString(), i.CheckInQuantity.ToString());
                }


                return friend;
            }

            dt = MakeDataTable();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var items = from objecT in db.Stock_Write_Off
                        join objecT2 in db.Stock_WriteOff_Line
                        on objecT.Write_Off_ID equals objecT2.Write_Off_ID
                        select new
                        {
                            WriteOffId = objecT.Write_Off_ID,
                            WriteOffDate = objecT.WriteOffDate,
                            ItemName = objecT.WriteOff_Stock_Name,
                            WriteOffQuantity = objecT2.Quantity

                        };

            dgvReports.DataSource = items.ToList();
            dgvReports.ClearSelection();

            DataTable MakeDataTable()
            {
                //Create friend table object
                DataTable friend = new DataTable();

                //Define columns
                friend.Columns.Add("WriteOffId");
                friend.Columns.Add("WriteOffDate");
                friend.Columns.Add("ItemName");
                friend.Columns.Add("WriteOffQuantity");

                //Populate with friends :)
                foreach (var i in items)
                {
                    friend.Rows.Add(i.WriteOffId.ToString(), i.WriteOffDate.ToString(), i.ItemName.ToString(), i.WriteOffQuantity.ToString());
                }


                return friend;
            }

            dt = MakeDataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var items = from objecT in db.Customers
                        select new
                        {
                            CustomerID = objecT.Customer_ID,
                            CustomerName = objecT.Customer_Name,
                            CustomerNumber = objecT.Customer_Contact_Number,
                            CustomerAddress = objecT.Customer_Address

                        };
            dgvReports.DataSource = items.ToList();
            dgvReports.ClearSelection();


            DataTable MakeDataTable()
            {
                //Create friend table object
                DataTable friend = new DataTable();

                //Define columns
                friend.Columns.Add("CustomerID");
                friend.Columns.Add("CustomerName");
                friend.Columns.Add("CustomerNumber");
                friend.Columns.Add("CustomerAddress");

                //Populate with friends :)
                foreach (var i in items)
                {
                    friend.Rows.Add(i.CustomerID.ToString(), i.CustomerName.ToString(), i.CustomerNumber.ToString(), i.CustomerAddress.ToString());
                }


                return friend;
            }

            dt = MakeDataTable();

        }

        private void btnStockOnHandRep_Click(object sender, EventArgs e)
        {
            var items = from objectT in db.Stock_Item
                        join objecT2 in db.Stock_Type
                        on objectT.Stock_Type_ID equals objecT2.Stock_Type_ID
                        select new
                        {
                            StockItemName = objectT.Stock_Item_Name,
                            ItemQuantity = objectT.Stock_Item_Quantity,
                            Description = objectT.Stock_Item_Description,
                            StockItemType = objecT2.Stock_Type_Description

                        };
            dgvReports.DataSource = items.ToList();
            dgvReports.ClearSelection();

            DataTable MakeDataTable()
            {
                //Create friend table object
                DataTable friend = new DataTable();

                //Define columns
                friend.Columns.Add("StockItemName");
                friend.Columns.Add("ItemQuantity");
                friend.Columns.Add("Description");
                friend.Columns.Add("StockItemType");

                //Populate with friends :)
                foreach (var i in items)
                {
                    friend.Rows.Add(i.StockItemName.ToString(), i.ItemQuantity.ToString(), i.Description.ToString(), i.StockItemType.ToString());
                }


                return friend;
            }

            dt = MakeDataTable();


        }

        #region Events
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Author : Dotnet Mob", fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //BindingSource bs = (BindingSource)dataGridView1.DataSource;


                // DataTable dtbl = MakeDataTable();
                Random i = new Random();
                int num = i.Next(0, 10000);
                string s = num.ToString();
                ExportDataTableToPdf(dt, @"C:\Users\phindulo\Documents\Test2"+ s + ".pdf", "**********************REPORT***********************");
                //if (cbxOpen.Checked)
                //{
                System.Diagnostics.Process.Start(@"C:\Users\phindulo\Documents\Test2" + s + ".pdf");
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}

#endregion