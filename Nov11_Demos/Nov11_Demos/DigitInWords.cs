using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov11_Demos
{
    class DigitInWords
    {
        public static void Main()
        {
            int n;
            char answer;
            do {
                Console.WriteLine("Enter a digit=");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        Console.WriteLine("enter a valid");
                        break;

                }
                Console.WriteLine("press y to continue");
                answer = Convert.ToChar(Console.ReadLine());
                } while(answer == 'y' || answer=='Y');
            
                Console.ReadLine();
            }
            
    }
}
