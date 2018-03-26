using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare a variables for;
            double miles;
            double gallons;
            double mpg;

            //Using IF statement to convert the numberOfMilesDrivenTextBox.Text to a double and assign the value 
            //to a miles variable.
            if (double.TryParse(numberOfMilesDrivenTextBox.Text, out miles))
            {
                //Using IF statement to convert the gallonGasUsedTexBox.Text to a double and assign the value 
                //to a gallons variable.
                if (double.TryParse(gallonOfGasUsedTextBox.Text, out gallons))
                {
                    //Calculate MPG.
                    mpg = miles / gallons;

                    //Display the result in the mpgOutputLabel control.
                    carsMPGOutputLabel.Text = mpg.ToString("n1");
                }
                else
                {
                    //Display an error message for numberOfMilesDrivenTextBox.
                    MessageBox.Show("invalid input for gallons.");
                }
            }
            else
            {
                //Dispaly an error message for gallonGasUsedTextBox.
                MessageBox.Show("invalid input for miles.");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
