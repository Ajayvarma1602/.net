﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nov10_Assignments
{
    class Votes
    {
        public static void Main()
        {
            string name;
            int age;
            char gender;
            Write("Enter your name =");
            name =ReadLine();
            Write("Enter your age =");
            age = Convert.ToInt32(ReadLine());
            Write("Enter your gender = ");
            gender = Convert.ToChar(ReadLine());
            if (age < 18)
            {
                WriteLine(gender == 'F' ? $"Ms.{name} is not eligible to vote" : $"Mr.{name} is not eligible to vote");
            }
            else
            {
                WriteLine(gender == 'M' ? $"Mr.{name} is eligible to vote" : $"Ms.{name} is eligible to vote");
            }
            ReadLine();
            WriteLine("Press Enter to terminate");
        }
    }
}
