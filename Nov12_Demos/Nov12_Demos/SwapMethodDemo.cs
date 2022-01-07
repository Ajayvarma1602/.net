using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12_Demos
{
    class SwapMethodDemo
    {
        static void Swap(ref int x,ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
            Console.WriteLine("in swap method");
            Console.WriteLine($"n1={x} and n2={y}");
        }
        static void Main()
        {
            int n1, n2;
            Console.WriteLine("enter number 1= ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2= ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"before swapmethod");
            Console.WriteLine($"n1={n1} and n2={n2}");
            Swap(ref n1,ref n2);
            Console.WriteLine($"After Swap");
            Console.WriteLine($"n1={n1} and n2={n2}");
            Console.ReadLine();
        }
    }
}
