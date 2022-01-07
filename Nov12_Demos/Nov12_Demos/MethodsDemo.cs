using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12_Demos
{
    class MethodsDemo
    {
      //  static int AddNos(int a, int b)
        //{
          //  a = 10;
            //b = 5;
            //return (a + b);
        //}

        static int AddNos(ref int a,ref int b)
        {
            a = 10;
            b = 5;
            return (a + b);
        }
        static void Main()
        {
            int x, y;
            Console.WriteLine("enter first number= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number= ");
            y = Convert.ToInt32(Console.ReadLine());
            // int res=AddNos(x, y);
            int res = AddNos(ref x, ref y);
            Console.WriteLine($"resultof {x} + {y} = {res}");
            Console.ReadLine();
        }
    }
}
