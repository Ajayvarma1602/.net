using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {

            int n,res=0,rem;

            Console.WriteLine("Enter a Number : ");

            n = Convert.ToInt32(Console.ReadLine());
             
            while (n > 0)
            {
                rem = n % 10;
                res = res * 10 + rem;
                n = n / 10;
            }
            while (res > 0)
            {
                rem = res % 10;
                Console.Write(rem + 2);
                res = res / 10;
            }  
            Console.ReadLine();
        }
    }
}
