using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class StackDemo
    {
        static void Main()
        {
            Stack countries = new Stack();
            countries.Push("india");
            countries.Push("us");
            countries.Push("aus");
            Console.WriteLine(countries.Count);
            foreach ( object obj in countries)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(countries.Count);
            while (countries.Count > 0)
            {
                Console.WriteLine(countries.Pop());
            }
            Console.WriteLine(countries.Count);
            Console.ReadLine();
        }
    }
}
