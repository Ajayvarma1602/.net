using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12_Demos
{
    class PassArrayDemo
    {
        static int FindLargestNumber(int[] numArray)
        {
            int max = numArray[0];
            foreach (int n in numArray)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }
        static void Main()
        {
            int[] numbers = { 15, 3, 45, 17, 20 };
            Console.WriteLine($"largest number in given array is : {FindLargestNumber(numbers)} ");
            Console.ReadLine();
        }
    }
}
