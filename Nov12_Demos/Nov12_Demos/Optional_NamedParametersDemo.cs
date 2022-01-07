using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12_Demos
{
    class Optional_NamedParametersDemo
    {
        static double ComputeSI(double p=5000,double r=4,double n=2)
        {
            Console.WriteLine($"p={p}, r={r}, n={n}");
            return (p * r * n) / 100;
        }
        static void Main()
        {
            Console.WriteLine($" {ComputeSI()}");
            Console.WriteLine($"{ComputeSI(r:3,p:10000,n:3)}");
            Console.ReadLine();
        }
    }
}
