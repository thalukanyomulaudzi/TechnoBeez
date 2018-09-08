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
    public partial class frmAddCustomer : Form
    {
        MmasweEntities13 db = new MmasweEntities13();
        private Form2 f = null;
        int index = -1;
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        public frmAddCustomer(Form callingForm)
        {
            f = callingForm as Form2;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            Suburb csSuburb = new Suburb();
            

            cs.Customer_Name=txtCustomerNames.Text;
            cs.Customer_Surname = txtCustomerSurname.Text;
            cs.Customer_Contact_Number = Convert.ToInt32(txtContactNo.Text);
            cs.Customer_Email = txtEmail.Text;
            cs.Customer_Address = richTextBox1.Text;
            csSuburb.Suburb_Name = txtSurburb.Text;
            csSuburb.Zip_Code = txtCode.Text;

            cs.Suburb_ID = csSuburb.Suburb_ID;

            db.Suburbs.Add(csSuburb);
            db.Customers.Add(cs);
            db.SaveChanges();

            this.Close();
            f.LoadCustomers();
            MessageBox.Show("Customer details successfully added");
            
        }
        public void View(int index)
        {
            this.index = index;
            //this.sb = sb;
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            if(index!=-1)
            {
                Customer cs = new Customer();
                Suburb csSuburb = new Suburb();

                cs = db.Customers.Single(x => x.Customer_ID == index);
                csSuburb = db.Suburbs.Single(x => x.Suburb_ID == cs.Suburb_ID);

                txtCustomerNames.Text= cs.Customer_Name;
                txtCustomerSurname.Text= cs.Customer_Surname;
                txtContactNo.Text= cs.Customer_Contact_Number.ToString();
                txtEmail.Text = cs.Customer_Email;
                richTextBox1.Text= cs.Customer_Address;
                txtSurburb.Text= csSuburb.Suburb_Name;
                txtCode.Text= csSuburb.Zip_Code;

                cs.Suburb_ID = csSuburb.Suburb_ID;
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            Suburb csSuburb = new Suburb();


            cs.Customer_Name = txtCustomerNames.Text;
            cs.Customer_Surname = txtCustomerSurname.Text;
            cs.Customer_Contact_Number = Convert.ToInt32(txtContactNo.Text);
            cs.Customer_Email = txtEmail.Text;
            cs.Customer_Address = richTextBox1.Text;
            csSuburb.Suburb_Name = txtSurburb.Text;
            csSuburb.Zip_Code = txtCode.Text;

            cs.Suburb_ID = csSuburb.Suburb_ID;

            db.Suburbs.Add(csSuburb);
            db.Customers.Add(cs);
            db.SaveChanges();

            this.Close();
            f.LoadCustomers();
            MessageBox.Show("Customer details successfully updated");
        }
    }
}
