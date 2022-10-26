using System;


namespace Proje2_ToDo
{
    class ConsoleManager
    {
        public static void Case2AddCardToBoard()
        {
            Console.Write("Başlık Giriniz                                  : ");
            string Header =Console.ReadLine();
            Console.Write("İçerik Giriniz                                  : ");
            string Content =Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            string Size =Card.GetSizeFromEnum(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Kişi Seçiniz                                    : ");
            string ID =Console.ReadLine();
    
            if(Card.Team.ContainsKey(ID))
            {
                Card newCard = new Card(Header,Content,Card.Team[ID],Size);
                BoardManager.AddCardToBoard(newCard);
            }
            else
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }
        }
        public static void Case3RemoveCardFromBoard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string userInput=Console.ReadLine();
            if(BoardManager.IfCardExistInBoard(userInput))
            {
                BoardManager.SeekAndRemoveCard(userInput);
            }
            else
            {
                while(true)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    string answer=Console.ReadLine();
                    if(answer=="1")
                    {
                        break;
                    }
                    else if(answer=="2")
                    {
                        Case3RemoveCardFromBoard();
                        break;
                    }
                }
                
            }
        }
        public static void Case4MoveCardFromBoard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string userInput=Console.ReadLine();
            if(BoardManager.IfCardExistInBoard(userInput))
            {
                string[] newCard=BoardManager.SeekAndMoveCard(userInput);
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                string answer=Console.ReadLine();
                if(answer=="1")
                {
                    Card newCardObj = new Card(newCard[0],newCard[1],newCard[2],newCard[3]);
                    BoardManager.AddCardToBoard(newCardObj);
                }
                else if(answer=="2")
                {
                    Card newCardObj = new Card(newCard[0],newCard[1],newCard[2],newCard[3]);
                    BoardManager.AddCardToInProgressList(newCardObj);
                }
                else if(answer=="3")
                {
                    Card newCardObj = new Card(newCard[0],newCard[1],newCard[2],newCard[3]);
                    BoardManager.AddCardToDoneList(newCardObj);
                }

            }
            else
            {
                while(true)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    string answer2=Console.ReadLine();
                    if(answer2=="1")
                    {
                        break;
                    }
                    else if(answer2=="2")
                    {
                        Case4MoveCardFromBoard();
                        break;
                    }
                }
            }
        }
    }
}