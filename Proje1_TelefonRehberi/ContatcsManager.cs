using System;
using System.Collections.Generic;

namespace phoneBook
{
    class ContactsManager
    {
        private static List<Contacts> _contatcs = new List<Contacts>();
        

        static ContactsManager(){
            Contacts defaultContact1 = new Contacts("Batuhan","Yigit","+90 123 123 234");
            Contacts defaultContact2 = new Contacts("Asli","Eren","+90 432 123 234");
            Contacts defaultContact3 = new Contacts("Cohn","Jena","+10 567 143 234");
            Contacts defaultContact4 = new Contacts("Ismail","YK","+90 876 675 567");
            Contacts defaultContact5 = new Contacts("Layne","Staley","+42 777 777 777");
            _contatcs.Add(defaultContact1);
            _contatcs.Add(defaultContact2);
            _contatcs.Add(defaultContact3);
            _contatcs.Add(defaultContact4);
            _contatcs.Add(defaultContact5);

        }
        public static void AddContact(Contacts contact) //Bu fonksiyon Contacts sınıfından bir parametre alıyor
        {
            
            _contatcs.Add(contact);
            
        } 

        public static void DeleteContact(string NameOrSurname)
        {
            foreach (var contact in _contatcs )
            {
                if(NameOrSurname==contact.Name || NameOrSurname == contact.Surname)
                {
                    _contatcs.Remove(contact);
                    break;
                }
            }
            
        }
        public static void UpdateContact(string NameOrSurname,string newNumber)
        {
            foreach (var contact in _contatcs )
            {
                if(NameOrSurname==contact.Name)
                {
                    contact.Number=newNumber;
                    break;
                }
                else if(NameOrSurname == contact.Surname)
                {
                    contact.Number=newNumber;
                    break;
                }
            }
        }
        public static bool IfContactExist(string name=null,string surname=null,string number=null)
        {
            foreach (var contact in _contatcs )
            {
                if(name == contact.Name || surname == contact.Surname || number == contact.Number)
                {
                    return true;
                }
            }
            return false;
            
        }
        public static void Sort_AZ()
        {
           _contatcs.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        public static void Sort_ZA()
        {
           _contatcs.Sort((y, x) => x.Name.CompareTo(y.Name));
        }

        public static void DisplayContactsList()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach(var contact in _contatcs)
            {
                Console.WriteLine("isim: {0}",contact.Name);
                Console.WriteLine("Soyisim: {0}",contact.Surname);
                Console.WriteLine("Telefon Numarası: {0}",contact.Number);
                Console.WriteLine("-");
            }
        }
        public static void WriteConsoleByNameOrSurname(string NameOrSurname)
        {
            foreach (var contact in _contatcs )
            {
                if(NameOrSurname==contact.Name)
                {
                    Console.WriteLine("isim: {0}",contact.Name);
                    Console.WriteLine("Soyisim: {0}",contact.Surname);
                    Console.WriteLine("Telefon Numarası: {0}",contact.Number);
                    Console.WriteLine("-");
                }
                else if(NameOrSurname == contact.Surname)
                {
                    Console.WriteLine("isim: {0}",contact.Name);
                    Console.WriteLine("Soyisim: {0}",contact.Surname);
                    Console.WriteLine("Telefon Numarası: {0}",contact.Number);
                    Console.WriteLine("-");
                }
            }
            
        }
        public static void WriteConsoleByPhoneNumber(string PhoneNumber)
        {
            foreach (var contact in _contatcs )
            {
                if(PhoneNumber==contact.Number)
                {
                    Console.WriteLine("isim: {0}",contact.Name);
                    Console.WriteLine("Soyisim: {0}",contact.Surname);
                    Console.WriteLine("Telefon Numarası: {0}",contact.Number);
                    Console.WriteLine("-");
                }
            }
            
        }
    }
}
