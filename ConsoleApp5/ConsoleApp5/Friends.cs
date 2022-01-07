using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Friends
    {
        private string name;

        public Friends(string x)
        {
            name = x;
        }

        public string GetName()
        {
            return name;
        }
        public static void Main()
        {
            Friends friend = new Friends("Sarah");
            string a = friend.GetName();
            Console.WriteLine(a);


            Console.ReadLine();
        }
    }
}
  