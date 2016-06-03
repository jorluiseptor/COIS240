using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        double firstNumber, secondNumber, total;
        string command; //if its multiplication, division, etc. 

        public Calculator()
        {
            InitializeComponent();
        }
        #region buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "2";
        }
        #endregion

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblDesplegar.Text);
            lblDesplegar.Text = "";
            command = "multiply";
        }
        /// <summary>
        /// calcula 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //si el tipo de calculo, command, es multiply
            if (command == "multiply")
            {
                secondNumber = Convert.ToDouble(lblDesplegar.Text);
                total = firstNumber * secondNumber;
                lblDesplegar.Text = total.ToString(); 
            }
        }


    }
}
