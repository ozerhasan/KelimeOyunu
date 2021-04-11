using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KelimeOyunu
{
    class Veritabani
    {
        private static string baglantiString = "server=127.0.0.1;uid=root;pwd=.zahid746.;database=kelimeoyunu";
        private static MySqlConnection baglanti;
        private static MySqlCommand komut;
        private static MySqlDataAdapter adaptor;
        private static MySqlDataReader dataReader;
        private static DataSet dataSet;

        public static int soruid = 0;
        public static string sorumetni;
        public static string cevap;
        public static bool durum;
        public static int puan;
        public static int harfsayisi;

        public static bool durum2;

        public static int maxid;

        private static string[] ekleDizi;

        public static int donusdegeri = 0;

        public static string isim1;
        public static string isim2;
        public static string isim3;
        public static int maxpuan;
        public static int maxpuan2;
        public static int maxpuan3;

        public static void Baglan()
        {
            try
            {
                baglanti = new MySqlConnection(baglantiString);
                baglanti.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            MessageBox.Show("Veritabanı Bağlantı Durumu: " + baglanti.State);

        }

        public static void Cek(string komutstring1, string komutstring2, string komutstring3, string komutstring4, string komutstring5)
        {
            try
            {
                komut = new MySqlCommand(komutstring1, baglanti);
                sorumetni = Convert.ToString(komut.ExecuteScalar());

                komut = new MySqlCommand(komutstring2, baglanti);
                cevap = Convert.ToString(komut.ExecuteScalar());

                komut = new MySqlCommand(komutstring3, baglanti);
                durum = Convert.ToBoolean(komut.ExecuteScalar());

                komut = new MySqlCommand(komutstring4, baglanti);
                puan = Convert.ToInt32(komut.ExecuteScalar());

                komut = new MySqlCommand(komutstring5, baglanti);
                harfsayisi = Convert.ToInt32(komut.ExecuteScalar());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        public static void idcek(string komuts)
        {
            komut = new MySqlCommand(komuts, baglanti);
            soruid = Convert.ToInt32(komut.ExecuteScalar());
            
        }

        public static void Guncelle(string komutguncelle)
        {
            komut = new MySqlCommand(komutguncelle,baglanti);
            komut.ExecuteNonQuery();
        }

        public static void Sifirla(string sifirlakomutu)
        {
            komut = new MySqlCommand(sifirlakomutu, baglanti);
            komut.ExecuteNonQuery();
        }

        public static void SoruEkle(string sorueklekomut, string soruekleparametreler)
        {
            komut = new MySqlCommand(sorueklekomut,baglanti);
            ekleDizi = soruekleparametreler.Split('+');
            komut.Parameters.Add("@sorumetni", MySqlDbType.VarChar).Value = ekleDizi[0];
            komut.Parameters.Add("@cevap", MySqlDbType.VarChar).Value = ekleDizi[1];
            komut.Parameters.Add("@durum", MySqlDbType.TinyBlob).Value = 0;
            komut.Parameters.Add("@puan", MySqlDbType.Int32).Value = ekleDizi[2];
            komut.Parameters.Add("@harf", MySqlDbType.Int32).Value = ekleDizi[3];      
            komut.ExecuteNonQuery();            
        }

        public static void UyeOl(string isim, string sifre)
        {
            string kontrolkomut= "select isim from oyuncular where isim" + "='" + isim + "'";
            komut = new MySqlCommand(kontrolkomut, baglanti);
            string isimkontrol = Convert.ToString(komut.ExecuteScalar());
            if (isim==isimkontrol)
            {
                MessageBox.Show("Bu isimde bir hesap mevcut! Başka bir isim giriniz.");
            }
            else if (isim!=isimkontrol)
            {
                string uyeolkomut = "insert into oyuncular (isim, sifre) values (@isim, @sifre);";
                komut = new MySqlCommand(uyeolkomut, baglanti);
                komut.Parameters.Add("@isim", MySqlDbType.VarChar).Value = isim;
                komut.Parameters.Add("@sifre", MySqlDbType.VarChar).Value = sifre;
                komut.ExecuteNonQuery();
            }
            
            
        }

        public static int Dogrula(string disim, string dsifre)
        {
            string dogrulakomut = "select sifre from oyuncular where isim" + "='" + disim + "'";
            komut = new MySqlCommand(dogrulakomut, baglanti);
            string sifre = Convert.ToString(komut.ExecuteScalar());
            
            if (sifre==dsifre)
            {
                MessageBox.Show("Doğrulama Başarılı!");
                donusdegeri = 1;
            }
            else if (sifre!=dsifre)
            {
                MessageBox.Show("DOğrulama Başarısız! Yanlış şifre girdiniz.");
                donusdegeri = 0;
            }
            return donusdegeri;
        }

        public static void PuanKaydet(string pisim, int ppuan)
        {
            komut.CommandText = "update oyuncular set puan=@ppuan where isim=@pisim";
            komut.Parameters.Add("@ppuan", MySqlDbType.Int32).Value=ppuan;
            komut.Parameters.Add("@pisim", MySqlDbType.VarChar).Value = pisim;
            komut.ExecuteNonQuery();
        }

        public static void Top3Cek()
        {
            string maxpuankomut = "select max(puan) from oyuncular";
            komut = new MySqlCommand(maxpuankomut, baglanti);
            maxpuan= Convert.ToInt32(komut.ExecuteScalar());

            string maxpuanisim ="select isim from oyuncular where puan" + "='" + maxpuan + "'";
            komut = new MySqlCommand(maxpuanisim, baglanti);
            isim1 = Convert.ToString(komut.ExecuteScalar());
            
            //top2
            string maxpuankomut2 = "select max(puan) from oyuncular where puan" + "<'" + maxpuan + "'";
            komut = new MySqlCommand(maxpuankomut2, baglanti);
            maxpuan2 = Convert.ToInt32(komut.ExecuteScalar());

            string maxpuanisim2 = "select isim from oyuncular where puan" + "='" + maxpuan2 + "'";
            komut = new MySqlCommand(maxpuanisim2, baglanti);
            isim2= Convert.ToString(komut.ExecuteScalar());

            //top3
            string maxpuankomut3 = "select max(puan) from oyuncular where puan" + "<'" + maxpuan2 + "'";
            komut = new MySqlCommand(maxpuankomut3, baglanti);
            maxpuan3 = Convert.ToInt32(komut.ExecuteScalar());

            string maxpuanisim3 = "select isim from oyuncular where puan" + "='" + maxpuan3 + "'";
            komut = new MySqlCommand(maxpuanisim3, baglanti);
            isim3 = Convert.ToString(komut.ExecuteScalar());


        }


        //sadece tek bir select komutu çalıştıracaksam kullanabilriim. 
        //dinamik bir fonksiyon.
        public static void KomutIslet(string isletkomut)
        {
            komut = new MySqlCommand(isletkomut, baglanti);
            maxid = Convert.ToInt32(komut.ExecuteScalar());
        }


        // bu kapatılan fonksiyonlar alternatif yoldu. yani tek tek çekiyordum değişkenleri.
        //public static string MetinGetir(string komut1)
        //{
        //    string metin;
        //    try
        //    {
        //        komut = new MySqlCommand(komut1, baglanti);
        //        metin = Convert.ToString(komut.ExecuteScalar());
        //        return metin;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        throw;
        //    }
        //}
        //public static string CevapGetir(string komut2)
        //{
        //    string cevap;
        //    try
        //    {
        //        komut = new MySqlCommand(komut2, baglanti);
        //        cevap = Convert.ToString(komut.ExecuteScalar());
        //        return cevap;

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        throw;
        //    }
        //}

        //public static bool DurumGetir(string komut3)
        //{
        //    try
        //    {
        //        komut = new MySqlCommand(komut3, baglanti);
        //        bool durum = Convert.ToBoolean(komut.ExecuteScalar());
        //        return durum;

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        throw;
        //    }

        //}

        //public static int PuanGetir(string komut4)
        //{
        //    int puan;
        //    try
        //    {
        //        komut = new MySqlCommand(komut4, baglanti);
        //        puan = Convert.ToInt32(komut.ExecuteScalar());
        //        return puan;

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        throw;
        //    }
        //}

        //public static int HarfGetir(string komut5)
        //{
        //    int harf;
        //    try
        //    {
        //        komut = new MySqlCommand(komut5, baglanti);
        //        harf = Convert.ToInt32(komut.ExecuteScalar());
        //        return harf;

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        throw;
        //    }
        //}
    }
}
