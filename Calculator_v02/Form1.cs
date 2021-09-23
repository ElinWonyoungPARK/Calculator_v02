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
        public int[] Conversion()
        {
            int[] num = new int[2];
            num[0] = int.Parse(num1.Text);
            num[1] = int.Parse(num2.Text);
            return num;
        }
        private void sumbtn_Click(object sender, EventArgs e)
        {
            //int number1 = Convert.ToInt32(num1.Text);
            //int number2 = Convert.ToInt32(num2.Text);
            int sum = Sum(Conversion());
            result.Text = sum.ToString();
        }
        public int Sum(int[] num)
        {
            int sum = num[0] + num[1];
            return sum;
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            //int number1 = Convert.ToInt32(num1.Text);
            //int number2 = Convert.ToInt32(num2.Text);
            int sub = Sub(Conversion());
            result.Text = sub.ToString();
        }
        public int Sub(int[] num)
        {
            int sub = num[0] - num[1];
            return sub;
        }

    }
}
