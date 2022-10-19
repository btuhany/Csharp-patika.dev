using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            */

            int n=0;

            Console.WriteLine("Kac adet sayi girmek istiyorsunuz?");
            
            while(true)
            {   
                Console.Write("Lutfen pozitif bir sayi giriniz: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(n>0)
                    break;
                else
                    Console.WriteLine("Sifir veya negatif bir sayi girdiniz.");

            }
            
            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.Sayiyi giriniz: ",i+1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Girdiğiniz cift sayilar: ");
            for (int i = 0; i < n; i++)
            {
                if(sayiDizisi[i]%2==0)
                    Console.Write(sayiDizisi[i] + " ");
            }

        }
    }
}
