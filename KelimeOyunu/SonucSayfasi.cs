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
    public partial class SonucSayfasi : Form
    {
        public SonucSayfasi()
        {
            InitializeComponent();
        }
        
        

        private void SonucSayfasi_Load(object sender, EventArgs e)
        {
            sonucisimLbl.Text = GirisSayfasi.isim;
            puanLbl.Text = Convert.ToString(OyunSayfasi.toppuan);
            string artandk = Convert.ToString(OyunSayfasi.dakika-1);
            string artansn = Convert.ToString(OyunSayfasi.saniye);
            artansureLbl.Text = (artandk) + ":" + artansn;
            oyunzamaniLbl.Text = Convert.ToString(OyunSayfasi.oyunzamani);
        }

        private void sonuckaydetBtn_Click(object sender, EventArgs e)
        {
            // SONUC HEM DB YE (TOP3 İÇİN) HEM DE TXT YE (HOCA ISTEDİ DIYE) KAYDEDİLSİN

            //db
            string isim = sonucisimLbl.Text;
            int puan = Convert.ToInt32(puanLbl.Text);            
            Veritabani.PuanKaydet(isim,puan);

            this.Close();
        }
    }
}
