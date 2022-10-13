using System;

namespace diziler_array_sinifi_methodlari
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
                        Console.WriteLine("***** Sirasiz Dizi ******");
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
                    Console.WriteLine("****** Sirali Dizi ********");
            Array.Sort(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //Clear  3.indexten itibaren 2 tane elemanı 0'lama.
            Console.WriteLine("***** Array Clear *****");
            Array.Clear(sayiDizisi,3,2);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //Reverse
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //IndexOf
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,72));

            //Resize
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 15);
            sayiDizisi[14]=99;
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

        
        
        }
    }
}
