﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nov10_Assignments
{
    class EvenNumber
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Write(i + " ");
                }
            }
            ReadLine();
            WriteLine("Press Enter for Terminate");
        }
    }
}
