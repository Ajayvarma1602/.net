using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            m.AddNos(1,2);
            //string s = null;
            //int[] numbers = null;
            int? x = null;
            int y;
            if (x.HasValue)
            {
               y= x.Value;
            }
            else
            {
                y=0;
            }
            Console.WriteLine(y);
            x = 8;
            int z = x.GetValueOrDefault();
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
