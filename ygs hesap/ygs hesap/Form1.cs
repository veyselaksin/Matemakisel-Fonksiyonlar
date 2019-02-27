using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ygs_hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int turkce, mat, fen, sosyal;
            double ygs1, ygs2, ygs3, ygs4;
            turkce = Convert.ToInt32(textBox1.Text);
            mat = Convert.ToInt32(textBox2.Text);
            sosyal = Convert.ToInt32(textBox3.Text);
            fen = Convert.ToInt32(textBox4.Text);

            ygs1 = 100.160 + (turkce*1.999)+(mat*3.998)+(sosyal*1)+(fen*2.999);
            ygs2 = 100.160 + (turkce * 1.999) + (mat * 2.999) + (sosyal * 1) + (fen * 3.998);
            ygs3 = 100.160 + (turkce * 3.998) + (mat * 1.999) + (sosyal * 2.999) + (fen * 1);
            ygs4 = 100.160 + (turkce * 2.999) + (mat *1.999) + (sosyal * 3.998) + (fen * 1);

            label8.Text = ygs1.ToString();
            label9.Text = ygs2.ToString();
            label10.Text = ygs3.ToString();
            label11.Text = ygs4.ToString();
        }
    }
}
