using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApplication
{
enum GenderType { Male,Female,Others}
    class EnumDemo
    {
        static void Main()
        {
            DayOfWeek day = DayOfWeek.Monday;

            Console.WriteLine("day = "+day);
            Console.WriteLine("integer value for = "+Convert.ToInt32(day));

            //string name=ajay;
            GenderType gender = 0;
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            lblGender: // to use in goto
            Console.WriteLine("press 0 for male, 1 for female , 2 for others");
            Console.WriteLine("provide option");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 0:
                    gender = GenderType.Male;
                    break;
                case 1:
                    gender = GenderType.Female;
                    break;
                case 2:
                    gender = GenderType.Others;
                    break;
                default:
                    Console.WriteLine("invalid");
                    goto lblGender;
                   
            }
            switch (gender)
            {
                case GenderType.Male:
                    Console.WriteLine($"hello mr.{name}");
                    break;
                case GenderType.Female:
                    Console.WriteLine($"hello ms.{name}");
                    break;
                case GenderType.Others:
                    Console.WriteLine($"hello {name}");
                    break;
                default:
        
                    break;
            }
 
            Console.ReadLine();
        
        }
    }

}
