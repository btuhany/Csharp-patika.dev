using System;
using System.Collections;
using System.Collections.Generic;
namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            // içersindeki verilere erişim
            foreach(var item in liste){
                Console.WriteLine(item);
            }

            // AddRange
            Console.WriteLine("****** Add Range *******");
            string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,9,6,10,15,23};

            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach(var item in liste){
                Console.WriteLine(item);
            }

            //Sort

            Console.WriteLine("****** Sort ******");
            //liste.Sort();  // aynı tip olmalı

            //Binary Search

            Console.WriteLine("***** Binary Search *****");
            //Console.WriteLine(liste.BinarySearch(9));

            //Reverse

            Console.WriteLine("******Reverse*******");
            liste.Reverse();
            foreach(var item in liste){
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("****** Clear *****");
            liste.Clear();
            foreach(var item in liste){
                Console.WriteLine(item);
            }
        }
    }
}
