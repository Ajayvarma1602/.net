using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nov10_Assignments
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int n;
            Write("Enter a Number = ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                if (n%2 == 0)
                {
                    WriteLine($"{n} is Even");
                }
                else
                {
                    WriteLine($"{n} is Odd");
                }
                ReadLine();
                WriteLine("Press Enter for terminate");
            }
        }
    }
}
