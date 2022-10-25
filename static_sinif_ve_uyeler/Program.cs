using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi:{0}", Calisan.CalisanSayisi);   
            //CAlisan sinifini erisildiği anda ilk olarak static constructor çalışır sonrasında çalışmaz
            Calisan calisan1 = new Calisan("Ayse","Yılmaz","IK");
            Console.WriteLine("Calisan Sayisi:{0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("fdse","Yıldsfmaz","IK");
            Calisan calisan3 = new Calisan("Ayse","Yılmaz","IK");
            Console.WriteLine("Calisan Sayisi:{0}", Calisan.CalisanSayisi);

            
            
            Console.WriteLine("Toplama işlemi sonucu {0}",Islemler.Topla(50,30));
            Console.WriteLine("Toplama işlemi sonucu {0}",Islemler.Cikar(50,30));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi=0;

        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return(sayi1+sayi2);
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return(sayi1-sayi2);
        }
    }
}
