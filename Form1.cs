using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double wartosc;
        char znak;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            wartosc = double.Parse(textBox1.Text);
            znak = '+';

            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (znak)
            {

                case '+':

                    textBox1.Text = (wartosc + double.Parse(textBox1.Text)).ToString();

                    break;

                case '-':

                    textBox1.Text = (wartosc - double.Parse(textBox1.Text)).ToString();

                    break;

                case '/':

                    if (textBox1.TextLength == 1 && textBox1.Text[0].Equals('0'))

                    {

                        textBox1.Text = "Błąd! Dzielenie przez 0!";

                    }

                    else

                    {

                        textBox1.Text = ((double)wartosc / double.Parse(textBox1.Text)).ToString();

                    }

                    break;

                case '*':

                    textBox1.Text = (wartosc * double.Parse(textBox1.Text)).ToString();

                    break;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            wartosc = double.Parse(textBox1.Text);
            znak = '-';

            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            wartosc = double.Parse(textBox1.Text);
            znak = '*';

            textBox1.Text = "";
        }
    }
}
