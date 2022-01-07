using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov11_Demos
{
    class ForLoop
    {
        public static void Main()
        {
            int i;
            Console.WriteLine("enter number");
            for (i = 1; i <= 20; i++) ;
            {
                Console.WriteLine($"{i} \t {i*i}");
            }
            Console.WriteLine($"i is {i}");
            Console.ReadLine();
        }
    }
}
