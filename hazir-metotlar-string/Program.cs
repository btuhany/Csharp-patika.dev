using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken ="Dersimiz Csharp, Hosgeldiniz!";
            string denemeSplit ="kelime1Akelime2Akelime3Akelime4";
            string degisken2 ="Dersimiz Csharp";
            string degisken3 ="dersimiz Csharp, Hosgeldiniz!";
            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper-ToLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat  
            Console.WriteLine(String.Concat(degisken," Merhaba!!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));   //0,1,-1 döndürür
            Console.WriteLine(String.Compare(degisken,degisken3,true));//büyük küçük harf duyarsız ignore
            Console.WriteLine(String.Compare(degisken,degisken3,false));//büyük küçük harf duyarlı

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            //EndsWith-StartsWith
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("Csha"));  //ilk index, burada C'nin indexi
            Console.WriteLine(degisken.IndexOf("Bat"));
            Console.WriteLine(degisken.LastIndexOf("i"));
        
            //Insert
            Console.WriteLine(degisken.Insert(5,"Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'[') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10.indexten sonuna kadar siliyor
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("Csharp","JAVA"));
            Console.WriteLine(degisken.Replace(" ","(bosluk)"));
            
            //Split
            Console.WriteLine(degisken.Split(' ')[1]);
            Console.WriteLine(denemeSplit.Split('A')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

            

        }
    }
}
