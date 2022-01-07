using System;
using System.Collections.Generic;
using System.Linq;
namespace NovBatch1Linq
{

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
     class Program1
    {
        static void Main()
        {
            
            Customer[] customers = new Customer[5];
            for (int i = 0; i <customers.Length; i++)
            {
                customers[i]=new Customer();
                customers[i].CustomerId = i + 1;
                Console.WriteLine("Enter the customer name: ");
                customers[i].Name = Console.ReadLine();
                customers[i].Date = DateTime.Now;
                Console.WriteLine("Enter the Amount :");
                customers[i].Amount = Convert.ToInt32(Console.ReadLine());
            }
            var date = customers.OrderBy(c => c.Date);
            foreach (Customer customer in date)
            {
                Console.WriteLine("Id : " +customer.CustomerId+ ", Name : "+customer.Name+ ", Amount : "+customer.Amount +", Date :"+customer.Date);
            }
                    var amount = customers.OrderBy(c => c.Amount);
            foreach(Customer customer in amount)
            {
                Console.WriteLine("Id :{0},Name :{1},Date :{2},Amount :{3}",customer.CustomerId,customer.Name,customer.Date,customer.Amount);
            }
                    var avg = customers.Average(c => c.Amount);
          
                  Console.WriteLine("Average Amount is:"+avg);
                    Console.ReadLine();
                
            }
        }
    }



//            players.Add(
//      new 
//        static List<Player> players = new List<Player>(); 
//    static void Main(string[] args)
//        {
//Player { PlayerNo = 18, Name = "kohli", NoOfMatches=15,RunRate=90  }
//      );
//            players.Add(
//              new Player { PlayerNo = 7, Name = "Dhoni", NoOfMatches = 20, RunRate = 80 }
//              );
//            var calPlys = from p in players select new Player { PlayerNo = p.PlayerNo, Name = p.Name, Average=p.NoOfMatches/p.RunRate
//            }; foreach (var item in calPlys)
//            {
//                Console.WriteLine(item.Average);
//            }
//            Console.ReadLine();
//        }
//    }
//}


