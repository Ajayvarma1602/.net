using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12_Demos
{
    class OutParameterDemo
    {
        static void GetPiValue(out double p)
        {
            p = 3.14;
        }
         static void Main()
        {
            double r = 4, pi;
            GetPiValue(out pi);
            double area = pi * r * r;
            Console.WriteLine($"area of {r}={area}");
            Console.ReadLine();
        }
    }
}
