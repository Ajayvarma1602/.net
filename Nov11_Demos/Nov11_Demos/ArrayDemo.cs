using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov11_Demos
{
    class ArrayDemo
    {
        static void Main()
        {
            int[] n = new int[5];
            for (int i = 0; i <n.Length; i++)
            {
                Console.WriteLine("enter number");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            //           Console.WriteLine("ele stored in array");
            //         for (int i = 0; i < n.Length; i++)
            //       {
            //         Console.WriteLine(n[i]);
            //   }
            foreach (int m in n)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("ascending order: ");
            Array.Sort(n);
            foreach(int m in n)
            {
                Console.WriteLine(m);
            }
            Array.Reverse(n);
            foreach(int m in n)
            {
                Console.WriteLine(m);
            }
                Console.Read();
        }
    }
}
