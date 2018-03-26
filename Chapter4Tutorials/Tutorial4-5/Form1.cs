using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Using IF statement to determine whether the yelloradioButton is checked.
            if(YellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Using IF statement to determine whether the redRadioButton is checked.
            if(RedRadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Using IF statement to determine whether the whiteRadioButton is checked.
            if(whiteRadioButton.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void backtoNormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Using IF statement to determine whether the backToNormalRadioButton is checked.
            if(backtoNormalRadioButton.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
