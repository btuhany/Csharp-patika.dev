using System;

namespace phoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            while(true)
            {
                
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                string userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        ConsoleManager.Case1AddContact();
                        break;
                    case "2":
                        ConsoleManager.Case2DeleteContact();
                        break;
                    case "3":
                        ConsoleManager.Case3UpdateContact();
                        break;
                    case "4":
                        ConsoleManager.Case4SortAndDisplay();
                        break;
                    case "5":
                        ConsoleManager.Case5Search();
                        break;

            
                }
            }
        }
    }
}
