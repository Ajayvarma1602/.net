
//SELECT MANY

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    public class Person
    {
        public int SerialNo { get; set; }
        public string Name { get; set; }
    }
    public class Emp
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public int TakeHomeSalary { get; set; }
        public int Detection { get; set; }
        public int Allownace { get; set; }
    }
    class Linq
    {
        static List<Emp> employees = new List<Emp>(); static void Main(string[] args)
        {
            employees.Add(
      new Emp { EmpNo = 1, Name = "A", Allownace = 1000, Detection = 50 }
      );
            employees.Add(
              new Emp { EmpNo = 1, Name = "B", Allownace = 1030, Detection = 30 }
              );
            var calEmps = from emp in employees select new Emp { EmpNo = emp.EmpNo, Name = emp.Name, TakeHomeSalary = emp.Allownace - emp.Detection }; 
            foreach (var item in calEmps)
            {
                Console.WriteLine(item.TakeHomeSalary);
            }
            Console.ReadLine();
        }
    }
}


//var procs = from process in System.Diagnostics.Process.GetProcesses() select process.Id;

//foreach (var p in procs)
//{
//    Console.WriteLine(p);
//}


//Console.ReadLine();

//public class Person
//{
//    public int SerialNo { get; set; }
//    public string Name { get; set; }
//}
//class Program
//{
//    static List<Person> people = new List<Person>(); static void Main(string[] args)
//    {

//        people.Add(new Person
//        {
//            Name = "A",
//            SerialNo = 1
//        });
//        people.Add(new Person
//        {
//            Name = "B",
//            SerialNo = 2
//        });
//        people.Add(new Person
//        {
//            Name = "C",
//            SerialNo = 3
//        });
//        people.Add(new Person
//        {
//            Name = "D",
//            SerialNo = 4
//        });
//        people.Add(new Person
//        {
//            Name = "E",
//            SerialNo = 5
//        }); List<string> selectPeople = (from person in people where person.SerialNo > 2 select person.Name).ToList(); for (int i = 0; i < selectPeople.Count(); i++)
//        {

//            Console.WriteLine(selectPeople[i]);

//        }
//        Console.WriteLine("******************************");
//        for (int i = 0; i < people.Count; i++)
//        {
//            if (people[i].SerialNo > 2)
//            {
//                Console.WriteLine(people[i].Name);
//            }
//        }

//        Console.ReadLine();
//    }




    //    public class PhoneNumber

    //{​​​​​

    //    public string Number {​​​​​ get; set; }​​​​​

    //}​    public class Person

    //{​​​​​

    //    public IEnumerable<PhoneNumber> PhoneNumbers {​​​​​ get; set; }​​​​​

    //    public string Name {​​​​​ get; set; }​​​​​

    //}​​​​​

    //class Program

    //{​​​​​         

    //    static IEnumerable<Person> people = new List<Person>();

    //    static void Main(string[] args)

    //    {​​​​​

    //        people = new List<Person>() {​​​​​

    //  new Person{​​​​​ Name="Ram", PhoneNumbers = new List<PhoneNumber>(){​​​​​ 

    //  new PhoneNumber{​​​​​ Number ="1234567" }​​​​​,

    //  new PhoneNumber{​​​​​ Number ="1234568" }​​​​​,

    //  new PhoneNumber{​​​​​ Number ="1234569" }​​​​​,

    //  new PhoneNumber{​​​​​ Number ="12345610" }​​​​​,

    //  }​​​​​

    //        }​​​​​,

    //  new Person{​​​​​ Name="Raja", PhoneNumbers= new List<PhoneNumber>(){​​​​​

    //         new PhoneNumber(){​​​​​ Number ="3445577" }​​​​​,

    //  new PhoneNumber(){​​​​​ Number ="3445578" }​​​​​,

    //  }​​​​​ 
    //        }​​​​​,

    //  new Person{​​​​​ Name="Suresh", PhoneNumbers=new List<PhoneNumber>(){​​​​​

    //        new PhoneNumber(){​​​​​ Number="44444444" }​​​​​

    //        }​​​​​
    //        }​​​​​

    //        }​​​​​;

          

    //        IEnumerable<IEnumerable<PhoneNumber>> phoneLists = people.Select(p => p.PhoneNumbers);      

    //    IEnumerable<PhoneNumber> phoneNumbers = people.SelectMany(p => p.PhoneNumbers);     
       

   //     var directory = people.SelectMany(p => p.PhoneNumbers,(parent, child) => new {​​​​​ parent.Name, child.Number }​​​​​);

   //     Console.ReadLine();

   //     }​​​​​

   //}
 