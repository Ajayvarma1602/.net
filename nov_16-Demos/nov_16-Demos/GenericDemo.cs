using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class GenericDemo
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
      //  static void Swap(ref string a,ref string b)
    //    {
            //string t = a;
            //a = b;
          //  b = t;
        //}
        static void Main()
        {
            int x = 6, y = 8;
            string s1 = "abc", s2 = "khg";

            Console.WriteLine($"x = {x} and y = {y}");
            Console.WriteLine($"s1 = {s1} and s2 = {s2}");
            Swap<int>(ref x, ref y);
            Swap<string>(ref s1, ref s2);

            Console.WriteLine($"x={x} and y={y}");
            Console.WriteLine($"s1 = {s1} and s2 = {s2}");

            Console.ReadLine();
        }
    }
}
