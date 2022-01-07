using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nov10_Demos
{
    struct Student
    {
        public int r;
        public int m;
    }
    class DatatypeDemo
    {
        static void Main()
        {
            Student s1;
            s1 = new Student();
            s1.r = 20;
            s1.m = 450;
            Student s2;
            s2 = s1;
            WriteLine($"roll number = {s1.r}");
            ReadLine();
            object
        }
    }
}
