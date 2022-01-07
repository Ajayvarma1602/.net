using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Friend
    {
        private string name;

        public Friend(string x)
        {
            this.name = x;
        }
        public string GetName()
        {
            return name;
        }
        public static void Main()
        {
            Friend friend = new Friend("Sarah");

            string a = friend.GetName();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}