using System;
using System.Collections.Generic;

namespace koleksiyonlar_ve_list
{
    class Program
    {
        static void Main(string[] args)
        {
           //List<T> class

//T --> Object türündedir.

        List<int> sayiListesi = new List<int>{};

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>{};
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        // Count 

        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        //foreach ve List.Foreach ile elemanlara erişim
        foreach(var sayi in sayiListesi)
            Console.WriteLine(sayi);

        foreach(var renk in renkListesi)
            Console.WriteLine(renk);
        

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));


        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");
        
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));
        
        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);
        
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));
        
        
        // Liste içerisinde arama
        if(sayiListesi.Contains(10))
            Console.WriteLine("10 liste içerisinde bulundu!");

        // Eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        // Diziyi List'e çevirme
        string[] hayvanlar = {"Kedi,Köpek,Kuş"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        // Listeyi nasıl temizleriz
        hayvanListesi.Clear();

        // List içerisinde nesne tutmak
        List<Kullanicilar> kullanıcıListesi = new List<Kullanicilar>();
        Kullanicilar kullanıcı1 = new Kullanicilar();
        Kullanicilar kullanıcı2 = new Kullanicilar();

        kullanıcı1.Isim ="Ayşe";
        kullanıcı1.Soyisim ="Yılmaz";
        kullanıcı1.Yas = 25;

        kullanıcı2.Isim ="Özcan";
        kullanıcı2.Soyisim ="Çalışkan";
        kullanıcı2.Yas = 29;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);

        List<Kullanicilar> yeniliste = new List<Kullanicilar>();

        yeniliste.Add(new Kullanicilar(){
            Isim = "Deniz",
            Soyisim = "Arda",
            Yas = 24,
        });

        foreach(var kullanıcı in kullanıcıListesi){
            Console.WriteLine("Kullanıcı Adı: "+ kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı: "+ kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yaş: "+ kullanıcı.Yas);
        }

        yeniliste.Clear();

       

        }
    }

        public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
        }



}
