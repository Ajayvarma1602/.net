using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductDetails;

namespace ProductApplication
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Student s1 = new Student();


                {
                    string name;
                    int rollNo;
                    int marks;

                    Console.WriteLine("enter student name ");
                    name = Console.ReadLine();

                    Console.WriteLine("enter student rollno ");
                    rollNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter student marks ");
                    marks = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("student name=" + s1.SName);
                    Console.WriteLine("student rollno " + s1.RollNo);
                    Console.WriteLine("student marks " + s1.SMarks);


                }

            }
        }
    }
}
