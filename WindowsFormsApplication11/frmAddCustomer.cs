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
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        MmasweEntities5 db = new MmasweEntities5();

        private void button7_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            try
            {
                //City city = db.Cities.FirstOrDefault(c => c.City_Name == txtCity.Text);
                Suburb suburb = db.Suburbs.FirstOrDefault(c => c.Suburb_Name == txtSurburb.Text);

                cust.Customer_Name = txtCustomerNames.Text;
                cust.Customer_Surname = txtCustomerSurname.Text;
                if ( (suburb != null))
                {
                   // cust.City_ID =  city.City_ID;
                    cust.Suburb_ID =  suburb.Suburb_ID;
                  
                }
                else
                {
                    MessageBox.Show("Error:City or Suburb not found");
                    return;

                }
                cust.Customer_Address = txtProvimce.Text + " " + 
               "\n " + suburb.Suburb_Name + " " + txtStreeName.Text;

                cust.Customer_Contact_Number = Convert.ToInt32(txtContactNo.Text);

                db.Customers.Add(cust);
                db.SaveChanges();
                Globals.addCustomer = true;
                Globals.custId = cust.Customer_ID;
               MessageBox.Show("New customer added successfully");
            }
            catch(Exception i)
            {
                MessageBox.Show(Convert.ToString(i));
            }
            
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
