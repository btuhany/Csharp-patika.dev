using System;

namespace _vscode
{
    class Program
    {
        /*
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        
        
        */


        static void Main(string[] args)
        {
            int n=0;

            Console.WriteLine("Kac adet kelime girmek istiyorsunuz?");
            
            while(true)
            {   
                Console.Write("Lutfen pozitif bir sayi giriniz: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(n>0)
                    break;
                else
                    Console.WriteLine("Sifir veya negatif bir sayi girdiniz.");

            }

            string[] kelimeDizisi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.Kelimeyi giriniz: ",i+1);
                kelimeDizisi[i] = Console.ReadLine();
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(kelimeDizisi[i]);
            }

        }
    }
}
