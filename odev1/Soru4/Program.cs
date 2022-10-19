using System;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            */


            
            Console.Write("Lütfen cümlenizi giriniz:");
            string cumle = Console.ReadLine();

            
            char[] harfDizisi= cumle.ToCharArray();
            string[] kelimeDizisi=cumle.Split(" ");
            
            //bosluk karakterini harfDizisinden ayırmamız gerekiyor
            //HARF SAYACI
            int harfSayaci=0;
            for (int i = 0; i < harfDizisi.Length; i++)
            {
                harfSayaci++;
                if(harfDizisi[i]==' ')
                    harfSayaci--;
            }
            Console.WriteLine("Girdiğiniz cümledeki harf sayisi: " +harfSayaci);
            Console.WriteLine("Girdiğiniz cümledeki kelime sayisi: " +kelimeDizisi.Length);

           
        }
    }
}
