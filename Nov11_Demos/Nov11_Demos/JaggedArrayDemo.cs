using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov11_Demos
{
    class JaggedArrayDemo
    {
        static void Main()
        {
            int[][] n = new int[3][];
            n[0] = new int[4];
            n[1] = new int[2];
            n[2] = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"For Array {i + 1} ");
                Console.WriteLine("--------------------------");
                for (int j = 0; j < n[i].Length; j++)
                {
                    Console.WriteLine($"Enter number {j + 1} = ");
                    n[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Elements stored :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"For Array {i + 1} ");
                Console.WriteLine("--------------------------");
                for (int j = 0; j < n[i].Length; j++)
                {
                    Console.Write($"\t {n[i][j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
