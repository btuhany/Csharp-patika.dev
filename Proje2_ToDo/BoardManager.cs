using System;
using System.Collections.Generic;

namespace Proje2_ToDo
{
    class BoardManager
    {

        private static List<Card> _toDoLine = new List<Card>();
        private static List<Card> _inProgressLine = new List<Card>();
        private static List<Card> _doneLine = new List<Card>();

        static BoardManager()
        {
            //defaults
            Card defaultCard = new Card("Görev1","Görev1 yapılacak","Ayşe","XS");
            Card defaultCard2 = new Card("Görev2","Görev2 tamamlanacak","Ayşe","M");
            Card defaultCard3 = new Card("Görev3","Görev3 bitecek","Mehmet","L");
            _toDoLine.Add(defaultCard);
            _toDoLine.Add(defaultCard2);
            _inProgressLine.Add(defaultCard3);
        }
        
        public static void ListBoard()
        {   
            
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************"); 
            foreach (var card in _toDoLine)
            {
                Console.Write("Başlık      : ");
                Console.WriteLine(card.Header);
                Console.Write("İçerik      : ");
                Console.WriteLine(card.Content);
                Console.Write("Atanan Kişi : ");
                Console.WriteLine(card.Member);
                Console.Write("Büyüklük    : ");
                Console.WriteLine(card.Size);
                Console.WriteLine("-");
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************"); 
            foreach (var card in _inProgressLine)
            {
                Console.Write("Başlık      : ");
                Console.WriteLine(card.Header);
                Console.Write("İçerik      : ");
                Console.WriteLine(card.Content);
                Console.Write("Atanan Kişi : ");
                Console.WriteLine(card.Member);
                Console.Write("Büyüklük    : ");
                Console.WriteLine(card.Size);
                Console.WriteLine("-");
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************"); 
            foreach (var card in _doneLine)
            {
                Console.Write("Başlık      : ");
                Console.WriteLine(card.Header);
                Console.Write("İçerik      : ");
                Console.WriteLine(card.Content);
                Console.Write("Atanan Kişi : ");
                Console.WriteLine(card.Member);
                Console.Write("Büyüklük    : ");
                Console.WriteLine(card.Size);
                Console.WriteLine("-");
            }

        }

        //adds to todo list
        public static void AddCardToBoard(Card card) 
        {
            _toDoLine.Add(card);
        }
        public static void AddCardToInProgressList(Card card)
        {
            _inProgressLine.Add(card);
        }
        public static void AddCardToDoneList(Card card)
        {
            _doneLine.Add(card);
        }
        public static bool IfCardExistInBoard(string headerInput)
        {
            foreach (var card in _toDoLine)
            {
                if(card.Header==headerInput)
                    return true;
            }
            foreach (var card in _inProgressLine)
            {
                if(card.Header==headerInput)
                    return true;
            }
            foreach (var card in _doneLine)
            {
                if(card.Header==headerInput)
                    return true;
            }
            return false;
        }
       
        //Collection was modified; enumeration operation may not execute.' error without breaks. 
        public static void SeekAndRemoveCard(string cardHeaderToRemove)
        {
            foreach(var card in _toDoLine)
            {
                if(cardHeaderToRemove==card.Header)
                {
                    _toDoLine.Remove(card);
                    break;
                }
            }
            foreach(var card in _inProgressLine)
            {
                if(cardHeaderToRemove==card.Header)
                {
                    _inProgressLine.Remove(card);
                    break;
                }
            }
            foreach(var card in _doneLine)
            {
                if(cardHeaderToRemove==card.Header)
                {
                    _doneLine.Remove(card);
                    break;
                }
            }
        }
        
        
        
        public static string[] SeekAndMoveCard(string headerInput)
        {
            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            
            foreach(var card in _toDoLine)
            {
                if(headerInput==card.Header)
                {
                    Console.WriteLine("Başlık      : {0}",card.Header);
                    Console.WriteLine("İçerik      : {0}",card.Content);
                    Console.WriteLine("Atanan Kişi : {0}",card.Member);
                    Console.WriteLine("Büyüklük    : {0}",card.Size);
                    Console.WriteLine("Line        : TODO");
                    string[] newCard={card.Header,card.Content,card.Member,card.Size};
                    _toDoLine.Remove(card);
                    return newCard;
                    
                }
            }
            foreach(var card in _inProgressLine)
            {
                if(headerInput==card.Header)
                {

                    Console.WriteLine("Başlık      : {0}",card.Header);
                    Console.WriteLine("İçerik      : {0}",card.Content);
                    Console.WriteLine("Atanan Kişi : {0}",card.Member);
                    Console.WriteLine("Büyüklük    : {0}",card.Size);
                    Console.WriteLine("Line        : IN PROGRESS");
                    string[] newCard={card.Header,card.Content,card.Member,card.Size};
                    _inProgressLine.Remove(card);
                    return newCard;
                }
            }
            foreach(var card in _doneLine)
            {
                if(headerInput==card.Header)
                {
                    Console.WriteLine("Başlık      : {0}",card.Header);
                    Console.WriteLine("İçerik      : {0}",card.Content);
                    Console.WriteLine("Atanan Kişi : {0}",card.Member);
                    Console.WriteLine("Büyüklük    : {0}",card.Size);
                    Console.WriteLine("Line        : DONE");
                    string[] newCard={card.Header,card.Content,card.Member,card.Size};
                    _doneLine.Remove(card);
                    return newCard;
                }
            }

            return null;
            
        }
        

    
        
    }
}