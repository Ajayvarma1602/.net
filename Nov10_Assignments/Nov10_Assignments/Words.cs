﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nov10_Assignments
{
    class Words
    {
        public static void Main()
        {
            int n;
            Write("Enter the number between 0 to 9 = ");
            n = Convert.ToInt32(ReadLine());
            switch (n)
            {
                case 0:
                    WriteLine("Zero");
                    break;
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    break;
                case 3:
                    WriteLine("Three");
                    break;
                case 4:
                    WriteLine("Four");
                    break;
                case 5:
                    WriteLine("Five");
                    break;
                case 6:
                    WriteLine("Six");
                    break;
                case 7:
                    WriteLine("Seven");
                    break;
                case 8:
                    WriteLine("Eight");
                    break;
                case 9:
                    WriteLine("Nine");
                    break;
                default:
                    WriteLine("Enter Valid Number");
                    break;
            }
            ReadLine();
            WriteLine("Press Enter to terminate");
        }

        }
    }
