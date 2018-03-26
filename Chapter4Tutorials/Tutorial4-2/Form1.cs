using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a constant field.
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                //Declare local variables
                decimal hoursWorked;
                decimal houlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                //Get the hours worked and hourly pay rate.
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                houlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                //Determine if the expression is true or false;
                if (hoursWorked > BASE_HOURS)
                {
                    //Calculate the base pay (w/o overtime).
                    basePay = houlyPayRate * BASE_HOURS;

                    //Calculate the number of overtime hours.
                    overtimeHours = hoursWorked - BASE_HOURS;

                    //Calculate th eovertime pay.
                    overtimePay = overtimeHours * houlyPayRate * OT_MULTIPLIER;

                    //Calcute the gross pay.
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    //Calculte the gross pay.
                    grossPay = hoursWorked * houlyPayRate;
                }
                //Display the gross pay
                grossPayOutputLabel.Text = grossPay.ToString("c");
            }
           
            
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the inputs and outputs.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayOutputLabel.Text = "";

            //Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
