using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersLibrary
{
    public class Customers
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
    }

    public class CustomerCollection
    {
        Customers[] customerList = null;

        int size;
        static int i;
        public CustomerCollection(int s = 1)
        {
            customerList = new Customers[s];
            size = s;
        }

        public int Size
        {
            get { return size; }
        }

        public void Insert()
        {
            if (i >= size)
            {
                Console.WriteLine("no space to add new customer");
            }
            else
            {
                Customers c1 = new Customers();


                Console.WriteLine("enter customer Id = ");
                c1.CustomerID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter fname = ");
                c1.FirstName = Console.ReadLine();
                Console.WriteLine("enter lname = ");
                c1.LastName = Console.ReadLine();
                Console.WriteLine("enter location = ");
                c1.Location = Console.ReadLine();
                customerList[i] = c1;
                i++;
            }
        }
        void DisplayCustomer(Customers c1)
        {
            Console.WriteLine("customer id : "+ c1.CustomerID);
            Console.WriteLine("customer fname: "+c1.FirstName);
            Console.WriteLine("customer lname: "+c1.LastName);
            Console.WriteLine("customer location: "+c1.Location);
        }

        public void ShowCustomerById(int id)
        {
            Customers c1 = null;
            foreach (Customers customers in customerList)
            {
                if (customers.CustomerID == id)
                {
                    c1 = customers;
                    break;
                }
            }
            if (c1 == null)
            {
                Console.WriteLine("customer id not found");
            }
            else
            {
                DisplayCustomer(c1);
            }

        } 
        public void ShowAllCustomers()
        {
            Console.WriteLine("details of all customers:");
            foreach (Customers c1 in customerList)
            {

            }
        } 


        public void Update(int id)
        {

            Customers c1 = null;
            foreach (Customers customers in customerList)
            {
                if (customers.CustomerID == id)
                {
                    c1 = customers;
                    break;
                }
            }
            if (c1 == null)
            {
                Console.WriteLine("customer id not found");
            }
            else
            {
               
                Console.WriteLine("provide details for customer: ");
                DisplayCustomer(c1);
                c1.FirstName = Console.ReadLine();
                Console.WriteLine("enter lname = ");
                c1.LastName = Console.ReadLine();
                Console.WriteLine("enter location = ");
                c1.Location = Console.ReadLine();
                Console.WriteLine("changes updated");
            }

        }
        public void Delete(int id)
        {

            Customers c1 = null;
            foreach (Customers customers in customerList)
            {
                if (customers.CustomerID == id)
                {
                    c1 = customers;
                    break;
                }
            }
            if (c1 == null)
            {
                Console.WriteLine("customer id not found");
            }
            else
            {
                Console.WriteLine(  "customer existing details: ");
                DisplayCustomer(c1);

                Console.WriteLine("do you delete the record (y or n) : ");
                char answer = Convert.ToChar(Console.ReadLine());
                if(answer=='y' || answer == 'Y')
                {
                    c1 = null;
                    Console.WriteLine("record deleted:");
                }
            }
        }
    }
}
