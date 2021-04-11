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
    public partial class OyunSayfasi : Form
    {
        public static int toppuan=0;
    
        public static int sorukac = 0;
        public static string komutn;
        public static string komutm;
        public static string komut1;
        public static string komut2;
        public static string komut3;
        public static string komut4;
        public static string komut5;
        public static int id;
        public static string guncellekomutu;

        public static int kacharfli;

        public static string cevap;
        //public static string kelime;
        //public static char[] ayir;

        
        public static int harfal;
        public static List<int> oncekiler = new List<int>();
        public static int sayac = 0;

        public static int puan;
        public static DateTime oyunzamani;
        public OyunSayfasi()
        {
            InitializeComponent();
            oyunzamani = DateTime.Now;
            gonderBtn.Enabled = false; // DUR a basmadan GONDER e basamasın diye. (bunu DUR kısmında enabled yapıyoruz)
        }


        public static int saniye = 60;
        public static int dakika = 4;

       
        int saniye2 = 30;

        
        

        public void Getir(int sorukac)
        {
            switch (sorukac)
            {
                //NOT: case2 den itibaren, yorum satırlarını açarsan aynı soruyu iki kere verme hatası düzelir.

                case 1:
                    komutn = "select soruid from sorucevap where harf=4 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);


                    break;
                case 2:
                    //4
                    //komutn = "select soruid from sorucevap where harf=4 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=4 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 3:
                    //5
                    //komutn = "select soruid from sorucevap where harf=5 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=5 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 4:
                    //5
                    //komutn = "select soruid from sorucevap where harf=5 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=5 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 5:
                    //6
                    //komutn = "select soruid from sorucevap where harf=6 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=6 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 6:
                    //6
                    //komutn = "select soruid from sorucevap where harf=6 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=6 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 7:
                    //7
                    //komutn = "select soruid from sorucevap where harf=7 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=7 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 8:
                    //7
                    //komutn = "select soruid from sorucevap where harf=7 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=7 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 9:
                    //8
                    //komutn = "select soruid from sorucevap where harf=8 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=8 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 10:
                    //8
                    //komutn = "select soruid from sorucevap where harf=8 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=8 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 11:
                    //9
                    //komutn = "select soruid from sorucevap where harf=9 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=9 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 12:
                    //9
                    //komutn = "select soruid from sorucevap where harf=9 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=9 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 13:
                    //10
                    //komutn = "select soruid from sorucevap where harf=10 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=10 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);
                    break;
                case 14:
                    //10
                    //komutn = "select soruid from sorucevap where harf=10 and durum=0 and soruid" + "<>'" + id + "'";
                    komutn = "select soruid from sorucevap where harf=10 and durum=0";
                    Veritabani.idcek(komutn);
                    id = Veritabani.soruid;
                    guncellekomutu = "update sorucevap set durum=1 where soruid" + "='" + id + "'";
                    Veritabani.Guncelle(guncellekomutu);
                    komut1 = "select sorumetni from sorucevap where soruid" + "='" + id + "'";
                    komut2 = "select cevap from sorucevap where soruid" + "='" + id + "'";
                    komut3 = "select durum from sorucevap where soruid" + "='" + id + "'";
                    komut4 = "select puan from sorucevap where soruid" + "='" + id + "'";
                    komut5 = "select harf from sorucevap where soruid" + "='" + id + "'";
                    Veritabani.Cek(komut1, komut2, komut3, komut4, komut5);

                    string komutson = "select max(soruid) from sorucevap";
                    Veritabani.KomutIslet(komutson);
                    int max = Veritabani.maxid;
                    if (id==max)
                    {
                        //id si 42 olan soruya gelindiğinde tabloyu sıfırlar ki sıradaki yarışmacı tekrardan 1. soruya dönsün
                        string komutstr = "update sorucevap set durum=0 where harf=4 or harf=5 or harf=6 or harf=7 or harf=8 or harf=9 or harf=10";
                        Veritabani.Sifirla(komutstr);
                        
                    }
                    break;

            }

            //Veritabani.Cek(komut1,komut2,komut3,komut4,komut5);
            string metin = Veritabani.sorumetni;
            //string cevap = Veritabani.cevap;
            cevap = Veritabani.cevap;
            bool durum = Veritabani.durum;
            puan = Veritabani.puan;
            int harf = Veritabani.harfsayisi;

            sorunoTxt.Text = "Soru:" + Convert.ToString(sorukac);
            sorumetniRtxt.Text = metin;
            sorupuaniTxt.Text = Convert.ToString(puan) + " puan";
            //toppuanTxt.Text = Convert.ToString(toppuan) + " puan";

            kacharfli = cevap.Length; //harf alma için kullanılır.

            //cevap kaç harfliyse o kadar kutucuğu görünür yapar.
            if (cevap.Length==4)
            {
                harf5.Visible = false;
                harf6.Visible = false;
                harf7.Visible = false;
                harf8.Visible = false;
                harf9.Visible = false;
                harf10.Visible = false;
            }
            else if (cevap.Length==5)
            {
                harf5.Visible = true;
            }
            else if (cevap.Length==6)
            {
                harf6.Visible = true;
            }
            else if (cevap.Length==7)
            {
                harf7.Visible = true;
            }
            else if (cevap.Length==8)
            {
                harf8.Visible = true;
            }
            else if (cevap.Length==9)
            {
                harf9.Visible = true;
            }
            else if (cevap.Length==10)
            {
                harf10.Visible = true;
            }

            
        }

        public void CevapGoster()
        {
            // DUR a bastın ve 30 sn bitti, bu fonk çalışır.

            string kelime = cevap; // eski hali -> string kelime = cevap;
            //MessageBox.Show(Convert.ToString(kelime));
            char[] ayir = kelime.ToCharArray(); // eski hali -> char[] ayir = kelime.ToCharArray();
            //string a = Convert.ToString(ayir[0]+ayir[1]+ayir[2]);
            //MessageBox.Show(a);
            
            if (kelime.Length == 4)
            {
                harf1.Text = Convert.ToString(ayir[0]);
                harf2.Text = Convert.ToString(ayir[1]);
                harf3.Text = Convert.ToString(ayir[2]);
                harf4.Text = Convert.ToString(ayir[3]);

                harf5.Visible = false;
                harf6.Visible = false;
                harf7.Visible = false; // BUNLARI SİLMEYİ DENE NE OLACAK GÖR
                harf8.Visible = false;
                harf9.Visible = false;
                harf10.Visible = false;

            }
            else if (kelime.Length == 5)
            {
                harf5.Visible = true;

                harf1.Text = Convert.ToString(ayir[0]);
                harf2.Text = Convert.ToString(ayir[1]);
                harf3.Text = Convert.ToString(ayir[2]);
                harf4.Text = Convert.ToString(ayir[3]);
                harf5.Text = Convert.ToString(ayir[4]);

            }
            else if (kelime.Length == 6)
            {
                harf6.Visible = true;

                harf1.Text = Convert.ToString(ayir[0]);
                harf2.Text = Convert.ToString(ayir[1]);
                harf3.Text = Convert.ToString(ayir[2]);
                harf4.Text = Convert.ToString(ayir[3]);
                harf5.Text = Convert.ToString(ayir[4]);
                harf6.Text = Convert.ToString(ayir[5]);
            }
            else if (kelime.Length == 7)
            {
                harf7.Visible = true;

                harf1.Text = Convert.ToString(ayir[0]);
                harf2.Text = Convert.ToString(ayir[1]);
                harf3.Text = Convert.ToString(ayir[2]);
                harf4.Text = Convert.ToString(ayir[3]);
                harf5.Text = Convert.ToString(ayir[4]);
                harf6.Text = Convert.ToString(ayir[5]);
                harf7.Text = Convert.ToString(ayir[6]);
            }
            else if (kelime.Length == 8)
            {
                harf8.Visible = true;

                harf1.Text = Convert.ToString(ayir[0]);
                harf2.Text = Convert.ToString(ayir[1]);
                harf3.Text = Convert.ToString(ayir[2]);
                harf4.Text = Convert.ToString(ayir[3]);
                harf5.Text = Convert.ToString(ayir[4]);
                harf6.Text = Convert.ToString(ayir[5]);
                harf7.Text = Convert.ToString(ayir[6]);
                harf8.Text = Convert.ToString(ayir[7]);
            }
            else if (kelime.Length == 9)
            {
                harf9.Visible = true;

                harf1.Text = Convert.ToString(ayir[0]);
                harf2.Text = Convert.ToString(ayir[1]);
                harf3.Text = Convert.ToString(ayir[2]);
                harf4.Text = Convert.ToString(ayir[3]);
                harf5.Text = Convert.ToString(ayir[4]);
                harf6.Text = Convert.ToString(ayir[5]);
                harf7.Text = Convert.ToString(ayir[6]);
                harf8.Text = Convert.ToString(ayir[7]);
                harf9.Text = Convert.ToString(ayir[8]);
            }
            else if (kelime.Length == 10)
            {
                harf10.Visible = true;
                harf1.Text = Convert.ToString(ayir[0]);
                harf2.Text = Convert.ToString(ayir[1]);
                harf3.Text = Convert.ToString(ayir[2]);
                harf4.Text = Convert.ToString(ayir[3]);  
                harf5.Text = Convert.ToString(ayir[4]);                
                harf6.Text = Convert.ToString(ayir[5]);
                harf7.Text = Convert.ToString(ayir[6]);
                harf8.Text = Convert.ToString(ayir[7]);
                harf9.Text = Convert.ToString(ayir[8]);
                harf10.Text = Convert.ToString(ayir[9]);
                
            }

            //SONUC SAYFASINA YONLENDIRME YAPILIYOR
            if (sorukac==14)
            {
                MessageBox.Show("BİTTİ");
                SonucSayfasi sonucSayfasi = new SonucSayfasi();
                this.Close();

                sonucSayfasi.Show();
            }
        }

        private void durBtn_Click(object sender, EventArgs e)
        {
            durBtn.Enabled = false;
            saniye2 = 30;
            timer1.Stop();
            timer2.Start();
            gonderBtn.Enabled = true;
            harfBtn.Enabled = false; //DUR a bastıktan sonra harf alamazsın
            sonrakiBtn.Enabled = false; // DUR a basınca sonraki soruya atlayamazsın
            sure2Lbl.Visible = true;
            saniye2Lbl.Visible = true;
        }

        private void sonrakiBtn_Click(object sender, EventArgs e)
        {
            harf1.Focus();//BU BURDA KALMASIIIIIIIIIIIIIIIIIIIIIIIN!!!!!
   
            sonrakiBtn.Enabled = false;
            if (harf1.BackColor==Color.SpringGreen || harf1.BackColor==Color.Red)
            {
                //tekrar eski renge döndür
                RengiWindowaCevir();
            }

            timer1.Start();
            //gonderBtn.Enabled = true;

            harf1.Text = "";
            harf2.Text = "";
            harf3.Text = "";
            harf4.Text = "";
            harf5.Text = "";
            harf6.Text = "";
            harf7.Text = "";
            harf8.Text = "";
            harf9.Text = "";
            harf10.Text = "";

            oncekiler.Clear();
            harfBtn.Enabled = true;

            sorukac++;
            Getir(sorukac);
            durBtn.Enabled = true;
            sure2Lbl.Visible = false;
            saniye2Lbl.Visible = false;
            

        }

        private void harfBtn_Click(object sender, EventArgs e)
        {
            puan= puan - 100;
            sorupuaniTxt.Text = Convert.ToString(puan) + " puan";
            string kelime2 = cevap; 
            char[] ayir2 = kelime2.ToCharArray();
            Random random = new Random();
            harfal = random.Next(1,(kacharfli+1));

            while (oncekiler.Contains(harfal))
            {
                harfal = random.Next(1, (kacharfli + 1));
            }
            oncekiler.Add(harfal);

            if (harfal==1)
            {
                harf1.Text = Convert.ToString(ayir2[0]);
            }
            else if (harfal==2)
            {
                harf2.Text = Convert.ToString(ayir2[1]);
            }
            else if (harfal == 3)
            {
                harf3.Text = Convert.ToString(ayir2[2]);
            }
            else if (harfal == 4)
            {
                harf4.Text = Convert.ToString(ayir2[3]);
            }
            else if (harfal == 5)
            {
                harf5.Text = Convert.ToString(ayir2[4]);
            }
            else if (harfal == 6)
            {
                harf6.Text = Convert.ToString(ayir2[5]);
            }
            else if (harfal == 7)
            {
                harf7.Text = Convert.ToString(ayir2[6]);
            }
            else if (harfal == 8)
            {
                harf8.Text = Convert.ToString(ayir2[7]);
            }
            else if (harfal == 9)
            {
                harf9.Text = Convert.ToString(ayir2[8]);
            }
            else if (harfal == 10)
            {
                harf10.Text = Convert.ToString(ayir2[9]);
            }

            //SONUC SAYFASINA YONLENDIRME
            if (oncekiler.Count >= cevap.Length)
            {              
                MessageBox.Show("Tüm harfleri aldınız.");

                //butun harfler gozuktu demektir.

                harfBtn.Enabled = false;
                durBtn.Enabled = false;
                timer1.Stop();
                sonrakiBtn.Enabled = true;
                if (sorukac == 14)
                {
                    MessageBox.Show("Bitti.");
                    SonucSayfasi sonucSayfasi = new SonucSayfasi();
                    this.Close();

                    sonucSayfasi.Show();
                }
            }
        }

        private void gonderBtn_Click(object sender, EventArgs e)
        {
            string kelime3 = cevap; // eski hali -> string kelime = cevap;
            char[] ayir3 = kelime3.ToCharArray();
            string birlestir = harf1.Text + harf2.Text + harf3.Text + harf4.Text + harf5.Text + harf6.Text + harf7.Text + harf8.Text + harf9.Text + harf10.Text;
            if (birlestir.Trim()==kelime3)
            {
                timer2.Stop();
   
                RengiYesileCevir();

                toppuan = toppuan + puan;
                toppuanTxt.Text = Convert.ToString(toppuan);

                gonderBtn.Enabled = false;
                sonrakiBtn.Enabled = true;

            }
            else if (birlestir.Trim() != kelime3)
            {
                RengiKirmiziyaCevir();
            }

            saniye2Lbl.Text = "";

            //SONUC SAYFASINA YONLENDIRME YAPILIYOR
            if (sorunoTxt.Text=="Soru:14")
            {
                sonrakiBtn.Enabled = false;
                if (birlestir.Trim() == kelime3)
                {
                    MessageBox.Show("Bitti");
                    SonucSayfasi sonucSayfasi = new SonucSayfasi();
                    this.Close();
                    sonucSayfasi.Show();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            //timer1.Interval = 1000;

            saniye = saniye - 1;
            saniyeLbl.Text = Convert.ToString(saniye + " saniye");
            if (dakikaLbl.Text == "0 dk" && saniyeLbl.Text== "0 saniye")
            {
                timer1.Stop();
                dakikaLbl.Text = "00";
                saniyeLbl.Text = "00";
                dakika = 1;
                saniye = 0;

                // 4dk lik süre bitince sonuc sayfasina gonder
                SonucSayfasi sonucsf = new SonucSayfasi();
                sonucsf.Show();
                Close();

            }
            dakikaLbl.Text = Convert.ToString((dakika - 1) + " dk");
            if (saniye == 0)
            {
                dakika = dakika - 1;
                dakikaLbl.Text = Convert.ToString(dakika + "dk");
                saniye = 60;
            }

            //if (dakikaLbl.Text == "-1")
            //{
            //    MessageBox.Show("girdi");
            //    timer1.Stop();
            //    dakikaLbl.Text = "00";
            //    saniyeLbl.Text = "00";
            //    SonucSayfasi sonucsf = new SonucSayfasi();
            //    sonucsf.Show();
            //    Close();
            //}



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer2.Interval = 1000;

            saniye2 = saniye2 - 1;
            saniye2Lbl.Text = Convert.ToString(saniye2);
            if (saniye2==0)
            {
                timer2.Stop();
                saniye2Lbl.Text = "00";
                gonderBtn.Enabled = false;
                toppuan = toppuan - puan;
                toppuanTxt.Text = Convert.ToString(toppuan);
                CevapGoster();
                sonrakiBtn.Enabled = true;                
            }
        }

        public void RengiWindowaCevir()
        {
            harf1.BackColor = SystemColors.Window;
            harf2.BackColor = SystemColors.Window;
            harf3.BackColor = SystemColors.Window;
            harf4.BackColor = SystemColors.Window;
            harf5.BackColor = SystemColors.Window;
            harf6.BackColor = SystemColors.Window;
            harf7.BackColor = SystemColors.Window;
            harf8.BackColor = SystemColors.Window;
            harf9.BackColor = SystemColors.Window;
            harf10.BackColor = SystemColors.Window;
        }

        public void RengiYesileCevir()
        {
            harf1.BackColor = Color.SpringGreen;
            harf2.BackColor = Color.SpringGreen;
            harf3.BackColor = Color.SpringGreen;
            harf4.BackColor = Color.SpringGreen;
            harf5.BackColor = Color.SpringGreen;
            harf6.BackColor = Color.SpringGreen;
            harf7.BackColor = Color.SpringGreen;
            harf8.BackColor = Color.SpringGreen;
            harf9.BackColor = Color.SpringGreen;
            harf10.BackColor = Color.SpringGreen;
        }

        public void RengiKirmiziyaCevir()
        {
            harf1.BackColor = Color.Red;
            harf2.BackColor = Color.Red;
            harf3.BackColor = Color.Red;
            harf4.BackColor = Color.Red;
            harf5.BackColor = Color.Red;
            harf6.BackColor = Color.Red;
            harf7.BackColor = Color.Red;
            harf8.BackColor = Color.Red;
            harf9.BackColor = Color.Red;
            harf10.BackColor = Color.Red;
        }


        //HERHANGİ BİR SIKINTI ÇIKARSA BURDAN OLABİLİR!!!!!
        private void OyunSayfasi_Load(object sender, EventArgs e)
        {
            sonrakiBtn.PerformClick();
            sonrakiBtn.Enabled = false;
        }

        private void OyunSayfasi_MouseClick(object sender, MouseEventArgs e)
        {
            if (harf1.BackColor==Color.Red)
            {                
                RengiWindowaCevir();
            }
        }

        private void OyunSayfasi_Shown(object sender, EventArgs e)
        {
            harf1.Focus();
        }

        private void harf1_TextChanged(object sender, EventArgs e)
        {
            harf2.Focus();
        }

        private void harf2_TextChanged(object sender, EventArgs e)
        {
            harf3.Focus();
        }

        private void harf3_TextChanged(object sender, EventArgs e)
        {
            harf4.Focus();
        }

        private void harf4_TextChanged(object sender, EventArgs e)
        {
            harf5.Focus();
        }

        private void harf5_TextChanged(object sender, EventArgs e)
        {
            harf6.Focus();
        }

        private void harf6_TextChanged(object sender, EventArgs e)
        {
            harf7.Focus();
        }

        private void harf7_TextChanged(object sender, EventArgs e)
        {
            harf8.Focus();
        }

        private void harf8_TextChanged(object sender, EventArgs e)
        {
            harf9.Focus();
        }

        private void harf9_TextChanged(object sender, EventArgs e)
        {
            harf10.Focus();
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            harf1.Text = "";
            harf2.Text = "";
            harf3.Text = "";
            harf4.Text = "";
            harf5.Text = "";
            harf6.Text = "";
            harf7.Text = "";
            harf8.Text = "";
            harf9.Text = "";
            harf10.Text = "";

            harf1.Focus();
        }
    }
}
