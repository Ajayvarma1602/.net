using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary;

namespace CustomerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.PID = 10;
            Console.WriteLine("helo= "+c1.PID);
            Console.ReadLine();
        }
    }
}
