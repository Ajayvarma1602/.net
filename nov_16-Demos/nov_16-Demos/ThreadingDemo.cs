using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace nov_16_Demos
{
    class ThreadingDemo
    {
        static void ComputeSum()
        { 
            Console.WriteLine($"ComputeSum invoked by Thread {Thread.CurrentThread.ManagedThreadId}");
            double s = 0; 
            for (double i = 1; i <= 10000000000; i++) 
            {
                s = s + i; 
            } 
            Console.WriteLine("Sum = " + s); 
        }
        static void Display() 
        {
            Console.WriteLine($"Display invoked by Thread {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"i = {i}");
                Thread.Sleep(600); 
            }
        }
        static void Main()
        {
            Console.WriteLine($"Main invoked by Thread {Thread.CurrentThread.ManagedThreadId}");

            ComputeSum();
            Display();
            Console.WriteLine("Back in Main..");
            Console.WriteLine("Press enter to terminate.."); 
            Console.ReadLine();
        }
    }
}
