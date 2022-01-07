using System;
using System.Collections;


namespace nov_16_Demos
{
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList countries = new ArrayList();
            countries.Add("india");
            countries.Add("aus");
            countries.Add("us");
            countries.Add("africa");
            countries.Add(50);
            Console.WriteLine(countries.Count);
            foreach (object obj in countries)
            {
                Console.WriteLine(obj);
            }
            
            Console.ReadLine();
        }
    }
}
