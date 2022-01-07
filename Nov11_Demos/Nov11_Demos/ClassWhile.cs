using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov11_Demos
{
    class ClassWhile
    {
        public static void Main()
        {
            int i = 1, f = 1;
            Console.WriteLine("enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                f = f * i;
                i = i + 1;
            }
            Console.WriteLine($"factorial of {n} is {f}");
            Console.ReadLine();
        }
    }
}
