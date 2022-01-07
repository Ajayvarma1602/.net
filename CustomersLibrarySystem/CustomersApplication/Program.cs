using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomersLibrary;

namespace CustomersApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerCollection c2 = new CustomerCollection(5);
            int choice;
            int id;
            do
            {
                Console.WriteLine("*****Customer operation****");
                Console.WriteLine("1.show all customers");
                Console.WriteLine("2.show customer by id");
                Console.WriteLine("3.add new customer");
                Console.WriteLine("4.update customer");
                Console.WriteLine("5.delete customer");
                Console.WriteLine("0.exit");

                Console.WriteLine("enter operation to perform: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        customers.ShowAllCustomers();
                        break;
                    case 2:
                        Console.WriteLine("enter customer id= ");
                        id = Convert.ToInt32(Console.ReadLine());
                        customers.ShowCustomerById(id);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                    default:
                        if (choice != 0)
                        {
                            Console.WriteLine("invalid choice try again");
                        }
                        break;
                }
            } while (choice != 0);
            Console.ReadLine();
        }
    }
}
