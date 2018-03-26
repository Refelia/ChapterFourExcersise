using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a constant field.
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_CURRENT_JOB = 2;

                //Declare local variables for;
                decimal salary;
                int yearsOnJob;

                //Convert and ssigned a value to the salary and yearsOnJob variable.
                salary = decimal.Parse(annualSalaryTextBox.Text);
                yearsOnJob = int.Parse(yearsCurrentTextBox.Text);

                //If statement to evaluate if the expression is true, then the user is qualify
                if (salary >= MINIMUM_SALARY) 
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_CURRENT_JOB)
                    {
                        //The user qualifies
                        loanDecissionOutputLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        //The user's minmum years at current job does not qualify.
                        loanDecissionOutputLabel.Text = "Minimum years required not met.";
                    }
                }
                else
                {
                    //The user's minimum salary does not qualify.
                    loanDecissionOutputLabel.Text = "Minimum salary required does not met";
                }
               
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the inputs and output.
            annualSalaryTextBox.Text = "";
            yearsCurrentTextBox.Text = "";
            loanDecissionOutputLabel.Text = "";

            //Reset the focus.
            annualSalaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the program.
            this.Close();
        }
    }
}
