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
    public partial class MyCalculator : Form
    {
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void number0_Click(object sender, EventArgs e)
        {
            screen.Text += (sender as Button).Text;
        }

        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(screen.Text);
            znak = (sender as Button).Text[0];
            screen.Clear();
        }

        public double Arithmetic(double a, double b, char znak)
        {
            switch (znak)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
            }

            return c;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(screen.Text);

            MyCalculator calc = new MyCalculator();

            double c = calc.Arithmetic(a, b, znak);

            screen.Text = c.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }

        private void otric_Click(object sender, EventArgs e)
        {
            if (screen.Text != "")
                if (screen.Text[0] == '-')
                    screen.Text = screen.Text.Remove(0, 1);
                else screen.Text = '-' + screen.Text;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (screen.Text != "")
                screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
        }
    }
}
