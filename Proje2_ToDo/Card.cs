using System;
using System.Collections.Generic;

namespace Proje2_ToDo
{
    class Card
    {
        private string header;
        private string content;
        private string member;
        private string size;

        private static Dictionary<string, string> team = new Dictionary<string, string>();
                                    //İsim,ID
        public string Header { get => header; set => header = value; }
        public string Content { get => content; set => content = value; }
        public string Member { get => member; set => member = value; }
        public string Size { get => size; set => size = value; }
        public static Dictionary<string, string> Team { get => team; set => team = value; }


        static Card()
        {
            Team.Add("156","Ayşe");
            Team.Add("157","Mehmet");
            Team.Add("158","Sude");
            Team.Add("159","Kazım");
            Team.Add("160","Nur");
        }
        public Card(string header,string content,string teamMember,string size)
        {
            Header=header;
            Content=content;
            Member=teamMember;
            Size=size;
        }
        
        public enum Sizes
        {
            XS=1,
            S,
            M,
            L,
            XL
        }
        public static string GetSizeFromEnum(int input)
        {                
            if(input==(int)Sizes.S)
                return Convert.ToString(Sizes.S);
            else if(input==(int)Sizes.M)
                return Convert.ToString(Sizes.M);
            else if(input==(int)Sizes.L)
                return Convert.ToString(Sizes.L);
            else if(input==(int)Sizes.XL)
                return Convert.ToString(Sizes.XL);
            else
                return Convert.ToString(Sizes.XS);

        }
       
    }
}