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
    public partial class Form1 : Form
    {
        double result = 0, first = 0, second = 0;
        string operation = "", ms;
        bool ok = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_result(object sender, EventArgs e)
        {
            if (!ok)
            {
                first = double.Parse(textBox1.Text);
            }
            else {
                second = double.Parse(textBox1.Text);
            }
            switch (operation)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;

                    break;
                case "*":
                    result = first * second;
                    break;

                case "/":
                    result = first / second;
                    break;
                case "x^y":
                    result = Math.Pow(first, second);
                    break;
                default:
                    break;
            }
            textBox1.Text = result.ToString();
            if (ok)
                ok = false;
        }

        private void button_func(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "sqrt":
                    textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                    break;
                case "fact":
                    int a=1;
                    for (int i = 1; i <= int.Parse(textBox1.Text); i++)
                    {
                        a = a * i;
                    }
                    textBox1.Text = a.ToString();
                    break;
                case "1/x":
                    textBox1.Text = (1/(double.Parse(textBox1.Text))).ToString();
                    break;
                case "cos":
                    textBox1.Text = Math.Cos(double.Parse(textBox1.Text)*Math.PI / 180).ToString();
                    break;
                case "sin":
                    textBox1.Text = Math.Sin(double.Parse(textBox1.Text)*Math.PI / 180).ToString();
                    break;
                case "ln":
                    textBox1.Text = Math.Log(double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button_backspace(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text == "")
                    textBox1.Text = "0";
            }
        }

        private void button_zapyataya(object sender, EventArgs e)
        {

            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button_C(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            first = 0;
            second = 0;
        }

        private void button_CE(object sender, EventArgs e)
        {
            string str = Convert.ToString(second);
            textBox1.Text = str;
        }

        private void button_MR(object sender, EventArgs e)
        {
            textBox1.Text = ms;
        }

        private void button_MC(object sender, EventArgs e)
        {
            ms = "";
        }

        private void button_M(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "M+")
            {
                
                ms =( Convert.ToDouble(textBox1.Text) + Convert.ToDouble(ms)).ToString();
                
            }

            if (btn.Text == "M-")
            {
                
                ms =( Convert.ToDouble(textBox1.Text) - Convert.ToDouble(ms)).ToString();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_MS(object sender, EventArgs e)
        {
            ms = textBox1.Text;
        }

        private void button_click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
                textBox1.Clear();
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            first = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = btn.Text;
        }
    }
}
