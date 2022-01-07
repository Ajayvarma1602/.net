using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denominations
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            Console.WriteLine("Enter Amount: ");
            money = Convert.ToInt32(Console.ReadLine());
            int a, b, c;
            Console.WriteLine("Enter one rupee notes: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter five rupee notes: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ten rupee notes: ");
            c = Convert.ToInt32(Console.ReadLine());

            int x = a + b + c;
            

            Console.WriteLine("Total number of notes required is "+x);
            Console.ReadLine();
        }
    }
}
