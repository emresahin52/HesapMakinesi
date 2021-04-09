using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{ 
    public partial class HesapMakinesi : Form
    {
        int sayi1, sayi2, sonuc;

        private void brncikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 - sayi2;
            lblcevap.Text = sonuc.ToString();
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 * sayi2;
            lblcevap.Text = sonuc.ToString();
        }

        private void btnbolum_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtsayi1.Text);
            sayi2 = Convert.ToDouble(txtsayi2.Text);
            sonuc = sayi1 / sayi2;
            lblcevap.Text = sonuc.ToString();
        }

        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void btntoplam_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 + sayi2;
            lblcevap.Text = sonuc.ToString();

        }
    }
}
