using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UssuAl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi,us,sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            us = Convert.ToInt32(textBox2.Text);
            sonuc = Math.Pow(sayi,us);
            label4.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi, sonuc;
            sayi = Convert.ToInt32(textBox3.Text);
            sonuc = Math.Sqrt(sayi);
            label6.Text = sonuc.ToString();
        }

       
    }
}
