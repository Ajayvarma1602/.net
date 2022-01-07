using System;

namespace ConsoleApp3
{
    internal class Program
    {
       

        public static object Ans { get; private set; }
        public static object ClassLibrary1 { get; private set; }

        static void Main(string[] args)
        {
            Ans cal=new Ans(4,5);
            Console.WriteLine(cal.Add());

            Console.ReadLine();
        }
    }
}
