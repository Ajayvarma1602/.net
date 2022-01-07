using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Friend
    {
        private string name;

        public Friend(string x) {
            name = x;
        }

        public string GetName()
        {
            return name;
        }
        public static void Main()
        {
            Friend friend = new Friend("Sarah");
            string a=friend.GetName();
            Console.WriteLine(a);

           
            Console.ReadLine();
        }
    }
}
