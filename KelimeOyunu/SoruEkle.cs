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
    public partial class SoruEkle : Form
    {

        public static string sorueklekomutu;
        public static string soruekleparametreler;
        public static bool durum =false;
        
        public SoruEkle()
        {
            InitializeComponent();
        }

        private void soruekleBtn_Click(object sender, EventArgs e)
        {
            sorueklekomutu =
                "insert into sorucevap (sorumetni, cevap, durum, puan, harf) values (@sorumetni, @cevap, @durum, @puan, @harf);";
            soruekleparametreler = soruekleTxt.Text + "+" + cevapekleTxt.Text + "+" + kacpuanTxt.Text + "+" + kacharfTxt.Text;
            Veritabani.SoruEkle(sorueklekomutu, soruekleparametreler);
            soruekleTxt.Text = "";
            cevapekleTxt.Text = "";
            kacpuanTxt.Text = "";
            kacharfTxt.Text = "";
        }
    }
}
