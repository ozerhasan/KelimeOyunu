create database kelimeoyunu;
use kelimeoyunu;

create table sorucevap
(
	soruid int not null auto_increment,
    primary key (soruid),
    sorumetni varchar(200) not null,
    cevap varchar(15) not null,
    durum boolean not null,
    puan int not null,
    harf int not null
);
use kelimeoyunu;
create table oyuncular
(
	oyuncuid int not null auto_increment,
    primary key(oyuncuid),
    isim varchar(50) not null,
    sifre varchar(100) not null,
    puan int
);

-- insertler
use kelimeoyunu;
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("YÜRÜYÜŞE GEÇMEK İÇİN VERİLEN KOMUT","MARŞ",0,400,4);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("BRAHMACI EĞİTİMİN PİRİ","GURU",0,400,4);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("SİYAHA ÇALAN BUĞDAY RENGİ","ESMER",0,500,5);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("YETİŞİN, KURTARIN! ANLAMLARINDA BİR SESLENME SÖZÜ","İMDAT",0,500,5);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("KORUNMAK İÇİN BİRİNE VEYA BİR YERE BIRAKILAN ŞEY","EMANET",0,600,6);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("FİLEYLE OYNANAN OYUNLARDA OYUNA BAŞLAMA VURUŞU","SERVİS",0,600,6);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("BOŞUNA ANLAMINDA FARSÇA KÖKENLİ BİR SÖZ","BEYHUDE",0,700,7);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("BELİRLİ BİR İŞİ YAPMAK İÇİN KULLANILACAK OLAN TÜRLÜ MADDELER, GEREKSİNİMLER","MALZEME",0,700,7);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("KATILDIĞI SIVININ DONMA DERECESİNİ DÜŞÜREN KİMYASAL","ANTİFRİZ",0,800,8);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("KARŞILIKLI OLARAK GÖZ TEMASI KURMAK","BAKIŞMAK",0,800,8);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("KENDİNE ÇEKMEK, ETKİLEMEK ANLAMINDAKİ BİRLEŞİK KELİME","CEZBETMEK",0,900,9);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("ÖZLEM DUYULAN BİR GEÇMİŞE AİT, ONA ÖZGÜ ANLAMINDAKİ SÖZ","NOSTALJİK",0,900,9);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("SAVAŞTA DÜŞMANIN ELİNE GEÇMEK","ESİRDÜŞMEK",0,1000,10);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("AÇIK VE NET İFADELER KULLANMADAN ANLAMINDA BİR SÖZ DİZİSİ","ÜSTÜKAPALI",0,1000,10);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("MÜLKİYETE YATKIN HER TÜR NESNE","EŞYA",0,400,4);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("TANRIYA ŞÜKRETME","HAMD",0,400,4);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("BİR MÜZİK ALETİNİN, ESKİDEN BİR SİLAHIN ADI OLARAK DA KULLANILAN İSMİ","KEMAN",0,500,5);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("BİR ÇAĞ İÇİNDE BELLİ ÖZELLİKLERİ OLAN SINIRLI SÜRE","DÖNEM",0,500,5);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("EVREN ANLAMINDA ARAPÇA KÖKENLİ SÖZCÜK","KAİNAT",0,600,6);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("SAĞLAM, GÜÇLÜ VE İYİ GELİŞMİŞ ANLAMINDAKİ SÖZ","GÜRBÜZ",0,600,6);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("SÜZME YOĞURT, SARIMSAK, NANE, DEREOTU VE TEREYAĞI KARIŞIMIYLA HAZIRLANAN BİR MEZE","HAYDARİ",0,700,7);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("ALÇAK VE ANLAŞILMAZ SESLE YAPILAN KONUŞMA","MIRILTI",0,700,7);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("HOŞNUTSUZLUK BELİRTEN SÖZLER SÖYLEMEK","YAKINMAK",0,800,8);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("MADDİ ZORLUK ÇEKEREK, ÖDÜNÇ PARA ALARAK ANLAMINDAKİ SÖZ DİZİSİ","BORÇHARÇ",0,800,8);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("KABA, İLKEL, GENELLİKLE ŞİDDET İÇEREN, ÇAĞDAŞLIKLA ÇELİŞEN HER TÜRLÜ EYLEM","BARBARLIK",0,900,9);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("BİR YERDE AYAKTA DURARAK ÇOKÇA BEKLEMEK","AĞAÇOLMAK",0,900,9);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("ŞAŞKINLIKTAN DOLAYI HAREKET EDEMEYECEK DURUMA GELMEK","KALAKALMAK",0,1000,10);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("MAKAM ARACI, STATÜ GÖSTERGESİ OLARAK DA KULLANILAN BİR HAVA TAŞITI TÜRÜ","HELİKOPTER",0,1000,10);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("OLMASI BAŞKA DURUMLARIN GERÇEKLEŞMESİNİ GEREKTİREN ŞEY, KOŞUL","ŞART",0,400,4);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("YUKARI, ÜST ANLAMLARINDA ESKİ BİR SÖZCÜK","FEVK",0,400,4);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("YÜK EYERİ","SEMER",0,500,5);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("TANRININ TÜM YARATTIKLARINA VERDİĞİ NİMET","RIZIK",0,500,5);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("HEKİMİN HASTANEDEKİ HASTALARI DOLAŞIP YOKLAMASI","VİZİTE",0,600,6);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("ARGODA KAÇMAK, ORTADAN KAYBOLMAK","TÜYMEK",0,600,6);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("İKİLİ ÖĞRETİM YAPAN OKULLARDA ÖĞLEDEN ÖNCE DERS GÖREN ÖĞRENCİ","SABAHÇI",0,700,7);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("KARŞILIK BEKLEMEDEN, İYİLİK OLSUN DİYE ANLAMINDAKİ SÖZ","HAYRINA",0,700,7);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("BİR İLACIN BİR GÜNDE ALINMASI GEREKEN MİKTARININ FAZLASINI KULLANMAK","DOZAŞIMI",0,800,8);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("EĞLENCE AMAÇLI, FİZİKSEL TEMAS İÇEREN, GENELDE HOŞ KARŞILANMAYAN HER TÜRLÜ HAREKET","ELŞAKASI",0,800,8);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("MATEME BÜRÜNMEK","YASTUTMAK",0,900,9);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("HAYATİ TEHLİKE İÇEREN BİR DURUMDAN KURTULUP YAŞAMINI SÜRDÜRMEK","SAĞKALMAK",0,900,9);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("AŞKMERDİVENİ DE DENİLEN BİTKİNİN DİĞER ADI","EĞRELTİOTU",0,1000,10);
insert into sorucevap (sorumetni,cevap,durum,puan,harf) values ("AKTARMASIZ YAPILAN HAVA YOLCULUĞU","DİREKTUÇUŞ",0,1000,10);









