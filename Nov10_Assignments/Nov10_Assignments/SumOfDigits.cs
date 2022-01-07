using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nov10_Assignments
{
    class SumOfDigits
    {
        public static void Main()
        {
            int n, sum = 0;
            WriteLine("Enter the given number = ");
            n = Convert.ToInt32(ReadLine());
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            WriteLine($"sum of the digits= {sum}");
            ReadLine();
            WriteLine("Press Enter to Terminate");
        }
    }
}
