using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public string N2;
        public bool r;
        public Form1()
        {
            r = false;
            n2 = false;
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e) // цифры
        {
            Button B = (Button)sender;
            if (textBox1.Text == "0")      
                textBox1.Clear();
            textBox1.Text = textBox1.Text + B.Text;
            if (n2)
            {
                n2 = false;
                textBox1.Clear();
                textBox1.Text = textBox1.Text + B.Text;
            }
        }

        private void button2_Click_1(object sender, EventArgs e) // C and CE
        {
            textBox1.Text = "0";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }
        private void button21_Click(object sender, EventArgs e) // + - * /
        {
            double d1 = Convert.ToDouble(N1);
            double d2 = Convert.ToDouble(textBox1.Text);
            switch (D)
            {
                case "+":
                    textBox1.Text = Convert.ToString(d1 + d2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(d1 - d2);
                    break;
                case "X":
                    textBox1.Text = Convert.ToString(d1 * d2);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(d1 / d2);
                    break;
            }
        }
        private void button4_Click(object sender, EventArgs e) // стереть
        {
            if ((textBox1.Text.Length == 1) && (textBox1.Text != "0"))
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text.Length != 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button22_Click(object sender, EventArgs e) // ,
        {
            r = true;
            int i = 0;
            foreach (var c in textBox1.Text)
            {
                if (c == ',')
                    i = 1;
            }
            if (i == 0)
                textBox1.Text = textBox1.Text + ",";
                
        }

        private void button24_Click(object sender, EventArgs e) // корень, x^2, +-, 1/x
        {
            Button B = (Button)sender;
            D = B.Text;
            double d = Convert.ToDouble(textBox1.Text);
            switch (D)
            {
                case "1/X":
                    if (textBox1.Text != "0")
                        textBox1.Text = Convert.ToString(1 / d);
                    break;
                case "X^2":
                    textBox1.Text = Convert.ToString(d*d);
                    break;
                case "√":
                    textBox1.Text = Convert.ToString(Math.Sqrt(d));
                    break;
                case "±":
                    textBox1.Text = Convert.ToString(-d);
                    break;

            }
        }
    }
}
