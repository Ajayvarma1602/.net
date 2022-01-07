using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class QueueDemo
    {
        static void Main()
        {
            Queue countries = new Queue();
            countries.Enqueue("india");
            countries.Enqueue("us");
            countries.Enqueue("aus");
            Console.WriteLine(countries.Count);
            foreach (object obj in countries)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(countries.Count);
            while (countries.Count > 0)
            {
                Console.WriteLine(countries.Dequeue());
            }
            Console.WriteLine(countries.Count);
            Console.ReadLine();
        }
    }
}
