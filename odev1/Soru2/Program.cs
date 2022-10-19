using System;

namespace Soru2
{
    class Program
    {

        /*
        Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        */
        
        static void Main(string[] args)
        {

   
            int n=0;
            int m=0;

            while(true)
            {   
                Console.WriteLine("Lutfen pozitif iki adet sayi giriniz: ");
                n = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
                if(n>0 && m>0)
                    break;
                else
                    Console.WriteLine("Sifir veya negatif bir sayi girdiniz. Tekrar deneyiniz.");

            }

            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.Sayiyi giriniz: ",i+1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(sayiDizisi[i]%m==0)
                    Console.Write(sayiDizisi[i] + " ");
            }
        }
    }
}
