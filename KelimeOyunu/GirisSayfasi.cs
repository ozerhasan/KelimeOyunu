using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class GirisSayfasi : Form
    {

        public static string isim;
        public static string sifre;
        public GirisSayfasi()
        {
            InitializeComponent();
            baslaBtn.Enabled = false;
        }

        private void baslaBtn_Click(object sender, EventArgs e)
        {
            OyunSayfasi oyunSayfasi = new OyunSayfasi();
            oyunSayfasi.Show();
            isim = isimTxt.Text;
            this.Hide();
            
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            Veritabani.Baglan();
        }

        private void seBtn_Click(object sender, EventArgs e)
        {
            SoruEkle soruEkle = new SoruEkle();
            soruEkle.Show();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            isim = isimTxt.Text;
            sifre = sifreTxt.Text;
            Veritabani.Dogrula(isim,sifre);
            
            if (Veritabani.donusdegeri==1)
            {
                baslaBtn.Enabled = true;
            }
            
        }

        private void uyeolBtn_Click(object sender, EventArgs e)
        {            
            isim = isimTxt.Text;
            sifre = sifreTxt.Text;
            Veritabani.UyeOl(isim, sifre);
            MessageBox.Show("İşlem tamamlandı. Giriş butonuna basınız.");
        }

        private void sifirlaBtn_Click(object sender, EventArgs e)
        {
            string komutstr = "update sorucevap set durum=0 where durum=1";
            Veritabani.Sifirla(komutstr);
        }

        private void top3Lbl_Click(object sender, EventArgs e)
        {
            Top3Ekranı top3Ekranı = new Top3Ekranı();
            top3Ekranı.Show();
        }
    }
}
