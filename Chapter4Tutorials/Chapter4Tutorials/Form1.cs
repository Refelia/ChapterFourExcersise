using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4Tutorials
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
                // Declare a constant field.
                const double HIGH_SCORE = 95.0;

                //Declare a variables for;
                double test1;
                double test2;
                double test3;
                double average;

                //Get the test score and converts the textbox property to a double and assign the value to a test1 variable.
                test1 = double.Parse(testScore1textBox.Text);
                test2 = double.Parse(testScore2TextBox.Text);
                test3 = double.Parse(testScore3TextBox.Text);

                //Calculate the average of the three test score.
                average = (test1 + test2 + test3) / 3.0;

                //converts the average variable to a string, rounded to 1 decimal places and display the result to the 
                //averageOutputLabel
                averageOutputlabel.Text = average.ToString("n1");

                //Using IF statement, if the high score is greater than constant field HIGH_SCORE, then display
                //then display the message to congratulate the user.
                if(average > HIGH_SCORE)
                {
                    MessageBox.Show("CONGRATULATIONS!");
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all the inputs and output.
            testScore1textBox.Text = "";
            testScore2TextBox.Text = "";
            testScore3TextBox.Text = "";
            averageOutputlabel.Text = "";

            //Reset the focus to test1.
            testScore1textBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
