using System;
using System.Collections.Generic;

namespace phoneBook
{
    class ConsoleManager
    {
        public static void Case1AddContact()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          : ");
            string surname = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz : ");
            string number = Console.ReadLine();
            Contacts contact = new Contacts(name,surname,number);
            ContactsManager.AddContact(contact);
        }

        public static void Case2DeleteContact()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string NameOrSurname = Console.ReadLine();
            if(ContactsManager.IfContactExist(NameOrSurname,NameOrSurname))
            {    
                Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) ",NameOrSurname);
                string answer = Console.ReadLine();
                if(answer=="y")
                    ContactsManager.DeleteContact(NameOrSurname);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.Write("* Yeniden denemek için      : (2)");
                string answer = Console.ReadLine();
                if(answer=="2")
                    Case2DeleteContact();
            }
        }
        public static void Case3UpdateContact()
        {
           Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
           string NameOrSurname = Console.ReadLine();
            if(ContactsManager.IfContactExist(NameOrSurname,NameOrSurname))
            {    
               Console.Write("Yeni numarayi giriniz: ");
               string number = Console.ReadLine();
               ContactsManager.UpdateContact(NameOrSurname,number);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.Write("* Yeniden denemek için              : (2)");
                string answer = Console.ReadLine();
                if(answer=="2")
                    Case3UpdateContact();
            }
        }
        public static void Case4SortAndDisplay()
        {   
            Console.WriteLine("Lütfen bir seçim yapınız.");
            Console.WriteLine("* İsme göre A'dan Z'ye: (1)");
            Console.WriteLine("* İsme göre Z'den A'ye: (2)");
            string answer = Console.ReadLine();
            if(answer=="2")
                ContactsManager.Sort_ZA();
            else
                ContactsManager.Sort_AZ();
            ContactsManager.DisplayContactsList();
        }
        public static void Case5Search()
        {   
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string answer = Console.ReadLine();
            if(answer=="1")
            {
                string NameOrSurname = Console.ReadLine();
                ContactsManager.WriteConsoleByNameOrSurname(NameOrSurname);
            }
            else if(answer=="2")
            {
                string PhoneNumber = Console.ReadLine();
                ContactsManager.WriteConsoleByPhoneNumber(PhoneNumber);
            }
                
           
            
            
        }
    }
}
