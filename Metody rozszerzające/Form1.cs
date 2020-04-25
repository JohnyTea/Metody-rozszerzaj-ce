using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody_rozszerzające
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            tekst = tekst.testMethod();
            textBox1.Text = tekst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            tekst = tekst.CreateTitle();
            textBox1.Text = tekst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            tekst = tekst.usunSamogloski();
            textBox1.Text = tekst;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            textBox1.Text = tekst.worldCounter().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            int[] tab = tekst.worldLetterCounter();
            textBox1.Text = "";
            for (int i = 0; i < tab.Length; i++)
            {
                textBox1.Text += tab[i].ToString() + ' ';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            textBox1.Text = tekst.isZdaniem().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            textBox1.Text = tekst.najczesciejUzywana().ToString();
        }
    }
}
