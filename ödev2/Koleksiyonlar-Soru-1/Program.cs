using System;
using System.Collections.Generic;
using System.Collections;
namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {

        /* 
        Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
        (ArrayList sınıfını kullanara yazınız.)
        Negatif ve numeric olmayan girişleri engelleyin.
        Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        */
            Console.WriteLine("20 adet pozitif sayi giriniz.");
            ArrayList prime_numberList = new ArrayList();
            ArrayList nonprime_numberList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {   
                int number=0;
                while(true)
                {
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        if(number > 0)
                        break;
                    else
                        Console.WriteLine("Negatif bir sayı ve sıfır girdiniz.");
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Numerik bir deger girmediniz.");
                    }
                
                }
                if(IsPrime(number))
                {
                    prime_numberList.Add(number);
                }
                else
                    nonprime_numberList.Add(number);

            }

                prime_numberList.Sort();
                prime_numberList.Reverse();

                nonprime_numberList.Sort();
                nonprime_numberList.Reverse();

                int primeSum=0,nonprimeSum=0;

                Console.Write("Girdiginiz asal sayılar: ");
                foreach(int item in prime_numberList)
                {
                Console.Write(item+" ");
                primeSum+=item;
                }
                Console.WriteLine("");
                Console.Write("Girdiginiz asal olmayan sayılar: ");
                foreach(int item in nonprime_numberList)
                {
                Console.Write(item+" ");
                nonprimeSum+=item;
                }
                Console.WriteLine("");
                Console.Write("Girdiginiz asal sayıların sayısı: ");
                Console.WriteLine(prime_numberList.Count);

                Console.Write("Girdiginiz asal olmayan sayıların sayısı: ");
                Console.WriteLine(nonprime_numberList.Count);
                
                Console.Write("Girdiginiz asal sayıların aritmetik ortalaması: ");
                Console.WriteLine(primeSum/prime_numberList.Count);

                Console.Write("Girdiginiz asal olmayan sayıların aritmetik ortalaması: ");
                Console.WriteLine(nonprimeSum/nonprime_numberList.Count);
            
        }


        public static bool IsPrime(int n)
        {
            if(n==1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if(n%i==0)
                    return false;       
            }
            return true;
        }
    }
}
