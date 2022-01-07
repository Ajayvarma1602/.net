using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov10_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int r;
            double a;
            Console.WriteLine("enter radius= ");
            r = Convert.ToInt32(Console.ReadLine());
            a = 3.14 * r * r;
            Console.WriteLine($"area of radius {r} is {a} sqcm");
            Console.ReadLine();
        }
    }
}
