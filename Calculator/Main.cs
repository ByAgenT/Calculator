using System;
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
                var calculator = new Calculator();
                EnterBox.Text = calculator.Calculate(expression).ToString();
            }
            else
            {
                EnterBox.Text += (sender as Button).Tag.ToString();
            }

        }

    }
}
