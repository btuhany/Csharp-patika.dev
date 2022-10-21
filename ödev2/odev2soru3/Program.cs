using System;
using System.Collections;
namespace odev2soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen cümle içerisindeki sesli harfleri 
             bir dizi içerisinde saklayan
            ve dizinin elemanlarını sıralayan programı yazınız.*/
            
            Console.WriteLine("Bir cumle giriniz.");
            string s = Console.ReadLine();
            ArrayList letters=new ArrayList();
            foreach(char L in s.ToLower())
            {
                if(L=='a' || L=='e' || L=='i' || L=='u' || L=='ü' || L=='o'|| L=='ö'|| L=='ı')
                    letters.Add(L);
            }
            
            letters.Sort();
            foreach(var item in letters)
            {Console.WriteLine(item);}
        }
    }
}
