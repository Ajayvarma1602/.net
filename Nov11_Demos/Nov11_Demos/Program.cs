using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov11_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter number1= ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2= ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine($"{n1} is larger than {n2}");
            }
            else if (n2 > n1)
            {
                Console.WriteLine($"{n2} is larger than {n1}");
            }
            else
            {
                Console.WriteLine($"both equal");
            }
            Console.ReadLine();
        }
    }
}
