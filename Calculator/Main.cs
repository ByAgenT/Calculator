using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((sender as Button).Tag.ToString() == "=")
            {
                string expression = EnterBox.Text;
                /*string[] str = ReversePolishNotation.ConvertToReversePolishNotation(ReversePolishNotation.DeleteSpaces(smth));
                string outStr = " ";
                foreach (string s in str)
                {
                    outStr += s + " ";
                }*/
                Calculator calculator = new Calculator();
                EnterBox.Text = calculator.Calculate(expression).ToString();
            }
            else
            {
                EnterBox.Text += (sender as Button).Tag.ToString();
            }

        }

    }
}
