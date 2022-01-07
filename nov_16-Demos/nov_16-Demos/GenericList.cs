using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class GenericList
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();
            numbers.Add(5);
            numbers.Add(6);
            names.Add("ajay");
            names.Add("jayanth");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
