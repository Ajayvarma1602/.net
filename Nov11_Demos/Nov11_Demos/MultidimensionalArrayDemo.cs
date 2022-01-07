using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov11_Demos
{
    class MultidimensionalArrayDemo
    {
        static void Main()
        {
            int[,] n = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("* for array in row : "+i);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"enter number at index {j} = ");
                    n[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("elements stored in array: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"elements of array in row {i}: ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{n[i,j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
