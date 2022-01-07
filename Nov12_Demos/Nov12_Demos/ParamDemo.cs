using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12_Demos
{
    class ParamDemo
    {
        static int AddNos(params int[] numArray)
        {
            int s = 0;
            foreach (int n in numArray)
            {
                s = s + n;
            }
            return s;
        }

        static void Main()
        {
            int[] numbers = { 6, 3, 4 };
            Console.WriteLine("sum= "+AddNos(numbers));
            Console.WriteLine(AddNos(10,12,10));
            Console.ReadLine();
        }
    }
}
