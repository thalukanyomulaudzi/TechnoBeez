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
    public partial class Setup_Employee_Shift_Schedule : Form
    {
        //public  void mInitializeComponent()
        //{



        //    dtp = new DateTimePicker();
        //    dtp.Location = new Point(12, 12);
        //    dtp.Format = DateTimePickerFormat.Time;

        //    dtp2 = new DateTimePicker();
        //    dtp2.Location = new Point(12, 12);
        //    dtp2.Format = DateTimePickerFormat.Time;
        //    Controls.Add(dtp2);


        //    Controls.Add(dtp);
        //    Text = "Time Picker";
        //}



        public Setup_Employee_Shift_Schedule()
        {
            InitializeComponent();


        }
        //DateTimePicker dtp;

        //DateTimePicker dtp2;

        MmasweEntities5 db = new MmasweEntities5();
        private void button1_Click(object sender, EventArgs e)
        {


            string phrase = txtMaxPeople.Text;

            double number;
            bool isNumeric = double.TryParse(phrase, out number);
            if ((phrase.Length <11) && (isNumeric == true))
            {
                if (Convert.ToInt32(txtMaxPeople.Text) > -1)
                {
                    try
                    {
                        Employee_Shifts shift = new Employee_Shifts();
                        shift.Employee_Shift_Start_Time = dtStartTime.Text;
                        shift.Employee_Shift_End_Time = dtEndTime.Text;
                        shift.MaximumCashiers = Convert.ToInt32(txtMaxPeople.Text);
                        shift.MaximumCooks = Convert.ToInt32(txtCashiers.Text);
                        db.Employee_Shifts.Add(shift);
                        db.SaveChanges();
                        MessageBox.Show("Shift created successfully");
                    }
                    catch(Exception i)
                    {
                        MessageBox.Show(i.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Error:Value invalid");
                }
         }

            else
            {
                MessageBox.Show("Error:value not numeric,enter a numeric value");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setup_Employee_Shift_Schedule_Load(object sender, EventArgs e)
        {
            dtStartTime.CustomFormat = "HH:mm";
            dtEndTime.CustomFormat = "HH:mm";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dtStartTime.CustomFormat = "HH:mm";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
            {

                dtStartTime.CustomFormat = " ";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtEndTime_MouseDown(object sender, MouseEventArgs e)
        {
            dtEndTime.CustomFormat = "HH:mm";
        }

        private void dtEndTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
            {

                dtEndTime.CustomFormat = " ";
            }

        }
    }
}
