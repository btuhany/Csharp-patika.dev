using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
/*             //While
            //1 den başlayarak console dan girilen sayıya kadar (sayi dahil) ort hesaplayıp konsola yazdiran program
            Console.Write("Lütfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<= sayi)
            {
                toplam+= sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            //a'dan z'ye kadar tüm harfleri console a yazdir.
            Console.WriteLine("********A'dan Z'ye kadar tüm harfleri console a yazdir.********");
            char character = 'a';
            while (character<='z')
            {
                Console.WriteLine(character);
                character ++;
            } 
*/

            Console.WriteLine("****** Foreach ******");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
