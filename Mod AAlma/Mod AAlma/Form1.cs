using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_AAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi,mod,sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            mod = Convert.ToInt32(textBox2.Text);
            sonuc = sayi % mod;
            label3.Text = sonuc.ToString();
            this.groupBox1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }
    }
}
