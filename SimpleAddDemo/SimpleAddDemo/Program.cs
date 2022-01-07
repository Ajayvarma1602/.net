using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAddDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("hello");
            // Console.ReadLine();
            int n1, n2, s;
            // for printing we use console.writeline
            Console.WriteLine("enter number1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            //for converting into integer and reading input from user
            s = n1 + n2;
            Console.Write("sum is: " + s);
            //for not coming out from console we are writing
            Console.ReadLine();
        }
    }
}
