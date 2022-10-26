using System;

namespace Proje2_ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                        BoardManager.ListBoard();
                        break;
                    case "2":
                        ConsoleManager.Case2AddCardToBoard();
                        break;
                    case "3":
                        ConsoleManager.Case3RemoveCardFromBoard();
                        break;
                    case "4":
                        ConsoleManager.Case4MoveCardFromBoard();
                        break;   
                }
            }
        }
    }
}
