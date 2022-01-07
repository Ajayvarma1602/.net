using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Car
    {
        public string Name { get; set; }
        public int Price { get; set; }

    }
    public class CarImplementation
    {
        public int TotalPriceOfAllCars(IList<Car> cars)
        //{
        //    var qry = from car in cars select car.Price;
        //    return qry.Sum();
        { 

            return cars.Sum(p => p.Price);
        }

        public string NameOfAllCars(IList<Car> cars)
        {
            var qry = from car in cars select car.Name;
            string name = string.Join(",", qry);
            return name;
            
           // string name="";
           //foreach(var item in qry)
           // {
           //     name += item;
                
           // }
           // return name;
        }
        
        public string PriceOfAllCars(IList<Car> cars)
        {
            var qry = from car in cars select car.Price;
            string price = string.Join(",", qry);
            return price;

        }

        public static void Main()
        {
            CarImplementation imp = new CarImplementation();
            IList<Car> cars = new List<Car>();
            cars.Add(new Car { Name="Jaguar",Price=5467831});
            cars.Add(new Car {Name="Jeep",Price=7689494 });
           //var a= imp.TotalPriceOfAllCars(cars);
           // var b=imp.NameOfAllCars(cars);
           // var c=imp.PriceOfAllCars(cars);
            Console.WriteLine(imp.TotalPriceOfAllCars(cars));
            Console.WriteLine(imp.NameOfAllCars(cars));
            Console.WriteLine(imp.PriceOfAllCars(cars));
            Console.ReadLine();
            
        }
    }
}
