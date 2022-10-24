using System;

namespace sinif_kavrami
{
    class Program
    {

        /*
        Söz Dizimi
        class SinifAdi
        {
             [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
             [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi[Parametre Listesi]
             {
                 //Metot Komutları
             }
        }



        //Erisim Belirleyiciler
        *Public   her yerden erişilebilir
        *Private   sadece taımlandığı sınıf içersinden erişelibir
        *Internal   kendi proje içerisinde erişleblilir Program.cs
        *Protected   kendi sınıfında veya kalıtım alan diğer sınıflarda
        */






        public static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Batuhan", "Yigit", 234535, "ARGE");  //örneğini yarattik
            
            Calisan calisan3 = new Calisan("Bruce","Wayne");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Asli";
            calisan2.Soyad = "Eren";
            calisan2.No = 346547457;
            calisan2.Departman = "Yonetim";

            calisan1.CalisanBilgileri();
            Console.WriteLine("**************");
            calisan2.CalisanBilgileri();
           
            Console.WriteLine("**************");
            calisan3.CalisanBilgileri();
        }





    }



    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(){}

        public Calisan(string Ad, string soyad, int no, string departman)
        {
            this.Ad = Ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string Ad, string soyad)
        {
            this.Ad = Ad;
            this.Soyad = soyad;
  
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
            Console.WriteLine("Çalışan Numarası: {0}", No);

        }
    }



}