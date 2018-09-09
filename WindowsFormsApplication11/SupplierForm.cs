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
    public partial class SupplierForm : Form
    {
        MmasweEntities5 db = new MmasweEntities5();
        private Form2 f = null;
        int index = -1;
        
        public SupplierForm()
        {
           
            InitializeComponent();
        }
        public SupplierForm(Form callingForm)
        {
            f = callingForm as Form2;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    Supplier newSupplier = new Supplier();
                    Supplier_Contact_Details supplierContact = new Supplier_Contact_Details();
                    Address supplierAddress = new Address();
                    City supplierCity = new City();
                    Suburb supplierSuburb = new Suburb();
                    Banking_Details bank = new Banking_Details();
                    Adress_Type addressType = new Adress_Type();
                    Supplier_Type sp = new Supplier_Type();

                    newSupplier.Supplier_Name = txtSupplierName.Text;

                    supplierContact.Supplier_Email_Adress = txtSupplierEmail.Text;
                    supplierContact.Supplier_Contact_Number = Convert.ToInt32(txtSupplierPhone.Text);
                    supplierContact.Supplier_Contact_Name = txtSupplierContactName.Text;
                    supplierAddress.City_Name = txtCity.Text;
                    supplierAddress.Street_Name = txtStreetName.Text;
                    supplierAddress.Province = txtProvince.Text;

                    supplierSuburb.Suburb_Name = txtSuburb.Text;
                    supplierSuburb.Zip_Code = txtCode.Text;

                    bank.Bank_Name = txtBankName.Text;
                    bank.Bank_Acc_No = Convert.ToInt32(txtAccNumber.Text);
                    bank.Branch_Code = Convert.ToInt32(txtBranchCode.Text);
                    newSupplier.Supplier_Type_ID = cbxSupplierType.SelectedIndex;

                    supplierAddress.Supplier_ID = newSupplier.Supplier_ID;
                    supplierContact.Supplier_ID = newSupplier.Supplier_ID;
                    supplierAddress.Suburb_ID = supplierSuburb.Suburb_ID;
                  //  supplierSuburb.City_ID = supplierCity.City_ID;
                    bank.Supplier_ID = newSupplier.Supplier_ID;
                    newSupplier.Supplier_Type_ID = sp.Supplier_Type_ID;
                    

                    //db.Cities.Add(supplierCity);
                    db.Suburbs.Add(supplierSuburb);
                    db.Suppliers.Add(newSupplier);
                    db.Addresses.Add(supplierAddress);
                    db.Supplier_Contact_Details.Add(supplierContact);
                    db.Banking_Details.Add(bank);

                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            f.loadSuppliers();
            MessageBox.Show("Supplier details successfully added");
            Globals.refresher = true;
        }
        public void View(int index)
        {
            this.index = index;
            //this.sb = sb;
        }
        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {

            SupplierType sp = new SupplierType();
            //// int index = supplierCity.City_ID;
            foreach (var item in db.Supplier_Type.Where(a => a.Supplier_Type_Description != null).ToList())
            {
                cbxSupplierType.Items.Add(item.Supplier_Type_Description);
            }

            //if(cbxSupplierType.SelectedText =="Ingredient Supplier")
            //{
            //    cbxSupplierType.SelectedIndex = 1;
            //}
            //else
            //{
            //    cbxSupplierType.SelectedIndex = 2;
            //}
            if (index!=-1)
            {

                Supplier newSupplier = new Supplier();
                Supplier_Contact_Details supplierContact = new Supplier_Contact_Details();
                Address supplierAddress = new Address();
              //  City supplierCity = new City();
                Suburb supplierSuburb = new Suburb();
                Banking_Details bank = new Banking_Details();
                Adress_Type addressType = new Adress_Type();


                newSupplier = db.Suppliers.Single(x => x.Supplier_ID == index);
                supplierContact= db.Supplier_Contact_Details.Single(x => x.Supplier_ID == index);
                supplierAddress = db.Addresses.Single(x => x.Supplier_ID == index);
                bank = db.Banking_Details.Single(x => x.Supplier_ID == index);
                //supplierCity = db.Cities.FirstOrDefault(x => x.City_ID == index);
              //  supplierAddress = db.Addresses.Single(x=>x.Suburb_ID==index);
                supplierSuburb = db.Suburbs.Single(x=>x.Suburb_ID==supplierAddress.Suburb_ID);

                txtSupplierName.Text= newSupplier.Supplier_Name;
                txtSupplierEmail.Text= supplierContact.Supplier_Email_Adress;
                txtSupplierPhone.Text = supplierContact.Supplier_Contact_Number.ToString();


                txtSupplierContactP.Text = supplierContact.Supplier_Contact_Name;
                txtStreetName.Text = supplierAddress.Street_Name;
                txtProvince.Text= supplierAddress.Province;
                txtCity.Text=supplierAddress.City_Name;//supplierCity.City_Name;
                txtSuburb.Text = supplierSuburb.Suburb_Name;
                txtCode.Text = supplierSuburb.Zip_Code;

                txtBankName.Text= bank.Bank_Name;
                txtAccNumber.Text = bank.Bank_Acc_No.ToString();
                txtBranchCode.Text = bank.Branch_Code.ToString();

                supplierAddress.Supplier_ID = newSupplier.Supplier_ID;
                supplierContact.Supplier_ID = newSupplier.Supplier_ID;
                supplierAddress.Suburb_ID = supplierSuburb.Suburb_ID;
                //supplierSuburb.City_ID = supplierCity.City_ID;
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    Supplier newSupplier = new Supplier();
                    Supplier_Contact_Details supplierContact = new Supplier_Contact_Details();
                    Address supplierAddress = new Address();
                    City supplierCity = new City();
                    Suburb supplierSuburb = new Suburb();
                    Banking_Details bank = new Banking_Details();
                    Adress_Type addressType = new Adress_Type();

                    newSupplier.Supplier_Name = txtSupplierName.Text;

                    supplierContact.Supplier_Email_Adress = txtSupplierEmail.Text;
                    supplierContact.Supplier_Contact_Number = Convert.ToInt32(txtSupplierPhone.Text);
                    supplierContact.Supplier_Contact_Name = txtSupplierContactName.Text;

                    supplierAddress.Street_Name = txtStreetName.Text;
                    supplierAddress.Province = txtProvince.Text;
                    //
                    //supplierCity.City_Name = txtCity.Text;
                    supplierSuburb.Suburb_Name = txtSuburb.Text;
                    supplierSuburb.Zip_Code = txtCode.Text;

                    bank.Bank_Name = txtBankName.Text;
                    bank.Bank_Acc_No = Convert.ToInt32(txtAccNumber.Text);
                    bank.Branch_Code = Convert.ToInt32(txtBranchCode.Text);

                    supplierAddress.Supplier_ID = newSupplier.Supplier_ID;
                    supplierContact.Supplier_ID = newSupplier.Supplier_ID;
                    supplierAddress.Suburb_ID = supplierSuburb.Suburb_ID;
                    //supplierSuburb.City_ID = supplierCity.City_ID;
                    bank.Supplier_ID = newSupplier.Supplier_ID;
                    //newSupplier.Supplier_Type_ID = sp


                   // db.Cities.Add(supplierCity);
                    db.Suburbs.Add(supplierSuburb);
                    db.Suppliers.Add(newSupplier);
                    db.Addresses.Add(supplierAddress);
                    db.Supplier_Contact_Details.Add(supplierContact);
                    db.Banking_Details.Add(bank);

                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
            f.loadSuppliers();
            MessageBox.Show("Supplier details successfully updated");
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
        private void txtSupplierName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierName, "Please enter supplier name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSupplierName, null);
            }
        }

        private void txtSupplierContactPerson_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierContactName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierContactName, "Please enter supplier contact name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSupplierContactName, null);
            }
        }

        private void txtSupplierEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(txtSupplierEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierEmail, "Please enter valid email");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSupplierEmail, null);
            }
        }

        private void txtSupplierPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNumber(txtSupplierPhone.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierPhone, "Please enter valid phone number");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSupplierPhone, null);
            }
        }
        
        private void txtBankName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBankName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBankName, "Please enter bank name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBankName, null);
            }
        }

        private void txtBankAccNo_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNumber(txtAccNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAccNumber, "Please enter valid account number");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtAccNumber, null);
            }
        }

        private void txtBranchCode_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNumber(txtBranchCode.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBranchCode, "Please enter valid branch code");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBranchCode, null);
            }
        }

        private void txtStreetName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStreetName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtStreetName, "Please enter street name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtStreetName, null);
            }
        }

        //private void txtSuburb_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtSuburb.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(txtSuburb, "Please enter Suburb");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(txtSuburb, null);
        //    }
        //}

        //private void txtCity_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtCity.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(txtCity, "Please enter city");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(txtCity, null);
        //    }
        //}

        //private void txtProvince_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtProvince.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(txtProvince, "Please enter province");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(txtProvince, null);
        //    }
        //}

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNumber(txtCode.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCode, "Please enter code");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCode, null);
            }
        }
    }
}
