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
        
        private double value;
        private string last_operator = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            do_math();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (last_operator == "")
            {
                value = Convert.ToDouble(textBox1.Text);
                last_operator = "+";
                textBox1.Text = "0";
            }
            else
            {
                do_math();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (last_operator == "")
            {
            value = Convert.ToDouble(textBox1.Text);
            last_operator = "/";
            textBox1.Text = "0";
            }
            else
            {
                do_math();
            }
}

        private void button17_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = textBox1.Text + "0";
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0")
                if (textBox1.Text.StartsWith("-"))
                    textBox1.Text = textBox1.Text.Substring(1);
                else
                    textBox1.Text = "-" + textBox1.Text;

                
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (last_operator == "")
            {
                value = Convert.ToDouble(textBox1.Text);
                last_operator = "-";
                textBox1.Text = "0";
            }
            else
            {
                do_math();
                
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (last_operator == "")
            {
                value = Convert.ToDouble(textBox1.Text);
                last_operator = "*";
                textBox1.Text = "0";
            }
            else
            {
                do_math();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            value = 0;
            last_operator = "";
        }

        private void do_math()
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (last_operator == "+")
            {
                Result = (value + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                value = Result;
            }
            if (last_operator == "-")
            {
                Result = (value - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                value = Result;
            }
            if (last_operator == "*")
            {
                Result = (value * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                value = Result;
            }
            if (last_operator == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (value / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    value = Result;
                }
            }
            last_operator = "";
        }

        private void tasta_apasata(object sender, KeyPressEventArgs e)
        {
            string numbers = "0123456789";
            Console.WriteLine(e.KeyChar.ToString());
            if (numbers.Contains(e.KeyChar.ToString()))
                textBox1.Text = textBox1.Text + e.KeyChar.ToString();
            
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            string numbers = "0123456789";
            Console.WriteLine(e.KeyCode.ToString());
            if (numbers.Contains(e.KeyCode.ToString()))
                textBox1.Text = textBox1.Text + e.KeyCode.ToString();
        }
    }
}
