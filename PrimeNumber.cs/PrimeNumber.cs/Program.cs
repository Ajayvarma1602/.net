using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumber.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1(); //calling method 1 but it is not having async and await
            Method2();//callling method 2 but it is having async and await
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}
