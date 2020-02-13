using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    //public partial class Calculator1 : Form
    public partial class Calculator1 : Form
    {
    
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        string currentValue = string.Empty;       
        string operand1 = string.Empty;     
        string operand2 = string.Empty;     
        char operation;                    
        double result = 0.0;              

        public Calculator1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "0";
            textBox.Text += currentValue;
            List<TextLine> missingLinesInSource = PreviousLines.Where(p => !CurrentLines.Any(p2 => p2.ToString().Trim() == p.ToString().Trim())).ToList();
        }
      

        private void num2_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "2";
            currentValue += "3";
            textBox.Text += currentValue;
        }

        /*private void num3_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "3";
            textBox.Text += currentValue;
        }*/
        
        private void num3_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "3";
            textBox.Text += currentValue;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox.Text = "1";
            currentValue += "4";
            textBox.Text += currentValue;
        }

        private void num5num6_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "5";
            textBox.Text += currentValue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "6";
            textBox.Text += currentValue;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "7";
            textBox.Text += currentValue;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "8";
            textBox.Text += currentValue;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue += "9";
            textBox.Text += currentValue;
        }

        private void decml_Click(object sender, EventArgs e)
        {
            currentValue += ".";
        }

        private void add_Click(object sender, EventArgs e)
        {
            operand1 = currentValue;
            operation = '+';
            currentValue = string.Empty;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            operand1 = currentValue;
            operation = '-';
            currentValue = string.Empty;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            operand1 = currentValue;
            operation = '*';
            currentValue = string.Empty;
        }

        private void division_Click(object sender, EventArgs e)
        {
            operand1 = currentValue;
            operation = '/';
            currentValue = string.Empty;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            operand2 = currentValue;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox.Text = result.ToString();
                }
                else
                {
                    textBox.Text = "Can't be divided by 0";
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentValue = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(textBox.Text);
            textBox.Text = Math.Sqrt(v).ToString();
        }

        private void recp_Click(object sender, EventArgs e)
        {
            operand1 = currentValue;
            double n1;
            double.TryParse(operand1, out n1);           
            if (n1 != 0)
            {
                result = 1 / n1;
                textBox.Text = result.ToString();

            }
            else
            {
                textBox.Text = "Can't be divided by 0";
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
          
        
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }       

    }
}
