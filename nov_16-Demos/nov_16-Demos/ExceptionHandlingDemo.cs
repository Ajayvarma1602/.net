using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class ExceptionHandlingDemo
    {
        static void Main()
        {
            try
            {
                int n, d, q;
                Console.Write("Enter numerator = ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter denominator = ");
                d = Convert.ToInt32(Console.ReadLine());
                if (n < 0 || d < 0)
                {
                    throw new NegativeNumbersException();
                }
                else
                {


                    q = n / d;
                    Console.WriteLine($"Quotient = {q}");
                }
    }
            catch (DivideByZeroException)
            {
                Console.WriteLine("denominatoer not be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("try: "+ex.Message);
               
            }
            Console.WriteLine("Press enter to terminate.."); 
            Console.ReadLine();
        }
    }
}
