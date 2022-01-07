using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12_Demos
{
    class Program
    {
        static void Display(int a)
        {
            Console.WriteLine("dispaly integer = "+a);
        }
        static void Display(string s)
        {
            Console.WriteLine("display display string = "+s);
        }
        static void Display(int a, int b)
        {
            Console.WriteLine($"sum of {a} and {b} = {a+b}");
        }
        static void Main(string[] args)
        {
            Display("hello");
            Display(6);
            Display(4, 5);
            Console.ReadLine();
        }
    }
}
