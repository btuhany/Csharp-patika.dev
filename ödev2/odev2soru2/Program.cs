using System;

namespace odev2soru2
{
    class Program
    {
        /*
        Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
        her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını
         console'a yazdıran programı yazınız.
         (Array sınıfını kullanarak yazınız.)
        */
        static void Main(string[] args)
        {   
            Console.WriteLine("20 adet sayi girisi yapiniz.");
            int[] arr = new int [20];
            
            for (int i = 0; i < 20; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
           
            for(int j=0;j<20;j++)
            {
                for(int i=0;i<19;i++)
                {
                    if(arr[i]>arr[i+1])
                    {
                        int temp=arr[i];
                        arr[i]=arr[i+1];
                        arr[i+1]=temp;
                    }
                }
            }
            int sum1=0,sum2=0;
            sum1=arr[0]+arr[1]+arr[2];
            sum2=arr[17]+arr[18]+arr[19];

            Console.WriteLine("En büyük üç eleman: {0} {1} {2}",arr[17], arr[18] ,arr[19]);
            Console.WriteLine("En küçük üç eleman: {0} {1} {2}",arr[0],arr[1],arr[2]);
            Console.WriteLine("************************");
            Console.WriteLine("En küçük 3 sayinin ortalaması: "+sum1/3);
            
            Console.WriteLine("En büyük 3 sayinin ortalaması: "+sum2/3);
            
            Console.WriteLine("Ortalama toplamları: "+(sum1+sum2)/3);
            
        }
    }
}
