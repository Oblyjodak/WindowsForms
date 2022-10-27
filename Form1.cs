using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Submitt_Click(object sender, EventArgs e)
        {
            string result = "\n Nazwisko: " + nazwisko.Text + "\n Imię: " + imie.Text + "\n Data urodzenia: " + data.Text + "\n Miejsce urodzenia: " + miejsceurodzenia.Text + "\n Adres: " + adres.Text + "\n Kod pocztowy: " + kodpocztowy.Text + "\n Telefon: " + telefon.Text;
            results.Text = result;
        }

        private void results_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
