using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{



    public class Car1
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
    }
    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class Program1
    {
        static void Main()
        {
            SampleCollection<Car1> stringCollection = new SampleCollection<Car1>();
            stringCollection[0] = new Car1() { CarId = 1, CarName = "Maruthi" };
            stringCollection[1] = new Car1() { CarId = 2, CarName = "Maruthi" };
            stringCollection[2] = new Car1() { CarId = 3, CarName = "Maruthi" };
            stringCollection[3] = new Car1() { CarId = 4, CarName = "Maruthi" };
            stringCollection[4] = new Car1() { CarId = 5, CarName = "Maruthi" };



            Console.WriteLine(stringCollection[0].CarId);
            Console.WriteLine(stringCollection[1].CarId);
            Console.WriteLine(stringCollection[2].CarId);
            Console.WriteLine(stringCollection[3].CarId);
            Console.WriteLine(stringCollection[4].CarId);

            Console.ReadLine();
        }
    }
}