using System;

namespace for_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
/*             //Ekrandan girilen sayıya kadar olan tek sayilari ekrana yazdir.
            Console.Write("Bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= sayac; i++)
            {
                //komutlar
                if(i%2==1){
                Console.WriteLine(i);
                }

            }

            //1 ile 1000 arasındaki tek ve çift sayilarin kendi aralarındaki toplamını ekrana yazdir.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <=1000; i++)
            {
                if(i%2==1)
                    tekToplam += i; //tekToplam=tekToplam+1
                else
                    ciftToplam +=i; //ciftToplam=ciftToplam+1
            }
            Console.WriteLine("Tek Toplam:"+ tekToplam);
            Console.WriteLine("Cift Toplam:"+ ciftToplam);
 */
            // break, contuine
/*             for(int i=1; i<10; i++)
            {
                if(i==4)
                    break;
                
                Console.WriteLine(i);
            }
 */            
            for(int i=1; i<=5; i++)
            {
                if(i%2==0)
                    continue;
                Console.WriteLine("Dongu:" + i);
                    for (int j = 1; j < 6; j++)
                    {
                        Console.WriteLine(j);
                    }
                
            }

            
        }
    }
}
