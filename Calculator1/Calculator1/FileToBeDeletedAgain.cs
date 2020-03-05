using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace Calculator1Deleted

{

    //public partial class Calculator1Deleted : Form

    public partial class Calculator1Deleted : Form

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

        } 


 



    }

}
