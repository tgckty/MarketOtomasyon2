using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyon
{
    public partial class MerketYonetim : Form
    {
        public MerketYonetim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 urunForm = new Form2();
            urunForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frmUrunAl = new Form3();
            frmUrunAl.ShowDialog();
        }

        private void btnStokYonetim_Click(object sender, EventArgs e)
        {
            Form5 frmStok = new Form5();
            frmStok.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Market Yönetim Sayfasına Hoşgeldiniz";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 urunForm = new Form1();
            urunForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Form6 frmsip = new Form6();
            frmsip.Show();
        }
    }
}
