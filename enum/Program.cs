using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
			Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
			
			if(sicaklik <= (int)havaDurumu.Normal){
				Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin.");
			}
			else if(sicaklik >= (int)havaDurumu.Sıcak){
				Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
			}
			else if(sicaklik >= (int)havaDurumu.Normal && sicaklik < (int)havaDurumu.CokSıcak){
				Console.WriteLine("Hadi dışarıya çıkalım!");
			}
        }

    }

    enum Gunler
    {
			Pazartesi,
			Salı,
			Çarşamba,
			Perşembe,
			Cuma=23,
			Cumartesi,
			Pazar
	}
		
	enum havaDurumu
    {
            Soguk = 5,
            Normal = 20,
            Sıcak = 25,
            CokSıcak = 30,
	}
}

