using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
 
            
            
        }
        bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        bool IsPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^[0-9]{9}$");
        }

        bool IsNumber(string number)
        {
            return Regex.IsMatch(number, @"^[0-9]+$");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    //City city = db.Cities.FirstOrDefault(c => c.City_Name == txtCity.Text);
                    Suburb suburb = db.Suburbs.FirstOrDefault(c => c.Suburb_Name == txtSurburb.Text);

                    cust.Customer_Name = txtCustomerNames.Text;
                    cust.Customer_Surname = txtCustomerSurname.Text;
                    if ((suburb != null))
                    {
                        // cust.City_ID =  city.City_ID;
                        cust.Suburb_ID = suburb.Suburb_ID;

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
                    Globals.refresher = true;
                    MessageBox.Show("New customer added successfully");

                }
                catch (Exception i)
                {
                    MessageBox.Show(Convert.ToString(i));
                }
            }

        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerNames.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomerNames, "Please enter customer name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCustomerNames, null);
            }
        }


        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNumber(txtContactNo.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtContactNo, "Please enter valid phone number");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtContactNo, null);
            }
        }

        private void txtCustomerStrName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStreeName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtStreeName, "Please enter street name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtStreeName, null);
            }
        }

        private void txtCustomerSuburb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurburb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSurburb, "Please enter Suburb");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSurburb, null);
            }
        }

        private void txtCustomerCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCity, "Please enter city");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCity, null);
            }
        }

        private void txtCustomerProvince_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProvimce.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtProvimce, "Please enter province");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtProvimce, null);
            }
        }

        private void txtCustomerSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerSurname.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomerSurname, "Please enter customer surname");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCustomerSurname, null);
            }
        }
    }
}
