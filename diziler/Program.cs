using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string [] renkler = new string [5];

            string[] hayvanlar = {"Kedy","Köpke","Kuş","Fil"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] ="Mavi";
            
            dizi[3]=10;


            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[3]); //NULL?
            Console.WriteLine(renkler[0]);

            /****************Döngülerle dizi kullanımı*****************/
            // Klavyeden girilen N tane sayının ortalaması

            Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            int toplam = 0;
            int toplam2 = 0;
            for(int i=0;i<diziUzunlugu;i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz:", i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
                
                toplam2 +=sayiDizisi[i];
            }

            
            foreach (var sayi in sayiDizisi)
            {
                toplam +=sayi;

            }

            Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);
            Console.WriteLine("Ortalama :" + toplam2/diziUzunlugu);
        }
    }
}
