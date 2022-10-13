using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
                ///komutlar;
            //}

            int a=2;
            int b=3;
            int sonuc = Topla(a,b);
            

            Metotlar ornek = new Metotlar();
            Console.Write("EkranaYazdir sonuc: ");
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            Console.Write("EkranaYazdir a+b: ");
            ornek.EkranaYazdir(Convert.ToString(a+b));
            Console.Write("EkranaYazdir BirArttirVeTopla(a,b): ");
            ornek.EkranaYazdir(Convert.ToString(ornek.BirArttirVeTopla(a,b)));
            Console.Write("EkranaYazdir a+b: ");
            //Referans ile
            ornek.EkranaYazdir(Convert.ToString(a+b));
            Console.Write("EkranaYazdir İkiArttirVeTopla(a,b): ");
            ornek.EkranaYazdir(Convert.ToString(ornek.IkiArttirVeTopla(ref a,ref b)));
            Console.Write("EkranaYazdir a+b: ");
            ornek.EkranaYazdir(Convert.ToString(a+b));
            
            
        }

        static int Topla(int deger1, int deger2)
        {
            return(deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int BirArttirVeTopla(int deger1,int deger2)
        {
            deger1+=1;
            deger2+=1;
            return (deger1+deger2);
        }
        public int IkiArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=2;
            deger2+=2;
            return (deger1+deger2);
        }

       
    }
}
