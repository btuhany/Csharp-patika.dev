using System;

namespace phoneBook
{
    class Contacts
    {
        
        private string name;
        private string surname;
        private string number;
        
        public Contacts(string name, string surname, string number)
        {
            Name=name;
            Surname=surname;
            Number=number;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Number { get => number; set => number = value; }
    }
}
