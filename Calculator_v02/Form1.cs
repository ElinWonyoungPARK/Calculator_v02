using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v02
{
    public partial class Form1 : Form
    {
       // public int number1 = Convert.ToInt32(num1.Text);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void sumbtn_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);
            int sum = Sum(number1, number2);
            result.Text = sum.ToString();
        }
        public int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);
            int sub = Sub(number1, number2);
            result.Text = sub.ToString();
        }
        public int Sub(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }

    }
}
