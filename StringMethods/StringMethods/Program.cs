﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;

            Console.WriteLine("Enter string1 = ");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter string2 = ");
            s2 = Console.ReadLine();

            //return a string in upper case
            Console.WriteLine($"{s1.ToUpper()}");
            Console.WriteLine($"{s2.ToUpper()}");

            //return a string in lower case
            Console.WriteLine($"{s1.ToLower()}");
            Console.WriteLine($"{s2.ToLower()}");

            //compare two strings returns the integer value.If both strings are equal it will return 0 .If first string is greater than second string, it returns 1 else it returns -1.
            Console.WriteLine($"Compare {s1} and {s2} is = {string.Compare(s1,s2)}");
            
            //concatation two strings
            Console.WriteLine($"Concatinate {s1} and {s2} = {string.Concat(s1,s2)}");
            
            //returns boolean value either true or false.
            Console.WriteLine($"{s1.Contains(s2)}");
           
            //returns boolean value either true or false.
            Console.WriteLine($" {s1.EndsWith(s2)}");
            
            //returns boolean value either true or false.
            Console.WriteLine($"{s1.StartsWith(s2)}");

            //returns boolean value either true or false.
            Console.WriteLine($"{s1.Equals(s2)}");

            //returns an integer value.If index of that character is not there then -1 will be return
            Console.WriteLine($"{s1.IndexOf('a')}");
            Console.WriteLine($"{s2.IndexOf('v')}");

            //It returns a new modified string.
            string s3 = s1.Insert(5,"-");
            Console.WriteLine($"{s3}");

            //It returns a string.
            Console.WriteLine($"{string.Join("+",s1)}");

            //It returns an integer value
            Console.WriteLine($"{s1.LastIndexOf('a')}");

            //It returns a string
            Console.WriteLine($"{s1.Substring(3)}");

            //It returns a character array
            char[] ch = s1.ToCharArray();
            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            //To remove all leading and trailing white-space characters from the current String object.It return a string.
            Console.WriteLine($"{s1.Trim()}");

            //It returns a string
            Console.WriteLine($"{s1.Replace('a','b')}");

            //It returns array of string
            string s4 = "Hello Everyone";
            string[] s5 = s4.Split(' ');
            foreach (string i in s5)
            {
                Console.WriteLine(i);
            }
 
            Console.ReadLine();
        }
    }
}
