using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class HashtableDemo
    {
        static void Main()
        {
            Hashtable currencies = new Hashtable();
            currencies.Add("in", "rupee");
            currencies.Add("us", "dollar");
            currencies.Add("gb", "pound");

            Console.WriteLine("currencies of us "+currencies["us"]);
            foreach (object obj in currencies.Keys)
            {
                Console.WriteLine( obj);
            }

            foreach (object obj in currencies.Values)
            {
                Console.WriteLine(obj);
            }

            foreach (DictionaryEntry item  in currencies)
            {
                Console.WriteLine($"{item.Key}    {item.Value}  {item.Value.GetHashCode()}");
            }
           
            Console.ReadLine();

        }
    }
}
