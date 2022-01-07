using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Class2
    {
        public class Car
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car c = new Car();
                var str = System.Text.Json.JsonSerializer.Serialize(c);
                Console.WriteLine(str);
            }
        }
    }
}
