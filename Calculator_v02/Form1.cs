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
        Class1 temp = new Class1();
        public Form1()
        {
            InitializeComponent();
            // Class1 class = new Class1();
        }

        public void sumBtn_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);
           // temp.Sum(number1, number2).ToString();
            int sum = temp.Sum(number1, number2);
            result.Text = sum.ToString();
        }

        public void subBtn_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);
            int sub = temp.Sub(number1,number2);
            result.Text = sub.ToString();
        }

    }
}
