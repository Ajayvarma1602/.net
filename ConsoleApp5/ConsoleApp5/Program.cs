using System;

namespace ConsoleApp5
{
    class Program
    {
        public int Add(int a, int b,int c)
        {
            return a + b + c;
        }
        public double Add(double a,double b,double c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           int A=p.Add(1, 2, 3);
          double  B=p.Add(1.1, 2.2, 3.3);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
