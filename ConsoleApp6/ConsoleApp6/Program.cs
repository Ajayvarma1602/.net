using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public string SENTINAL = "~";
        public string JoinIt(string[] input)
        {
            string str = string.Join(SENTINAL, input);
            return str;
        }
        public string[] SplitIt(string input)
        {
            string[] str = input.Split('~');
            return str;
        }
        public StringBuilder Reverse(string input)
        {
            string[] str = input.Split(' ');
            StringBuilder sa = new StringBuilder();
            for (int i = str.Length - 1; i > 0; i--)
            {
                sa.Append(str[i]);
                sa.Append(" ");
            }
            return sa;
        }
        public string PadLeft(string input, int n, char a)
        {
            string str = input.PadLeft(n, a);
            return str;
        }
        static void Main(string[] args)
        {
            string[] arr = { "one", "two", "three" };
            string split = "one~two~three~four~five~six";
            string reverse = "Seven two three";
            string padleft = "OneTwoThree";
            Program p = new Program();
            Console.WriteLine(p.JoinIt(arr));
            string[] str = p.SplitIt(split);
            foreach (string item in str)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(p.Reverse(reverse));
            Console.WriteLine(p.PadLeft(padleft, 15, '~'));
            Console.ReadLine();
        }
    }
}