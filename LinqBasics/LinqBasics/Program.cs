
//using System.;
//using System.Collections.Generic;
//using System.Linq;

//namespace NovBatch1Linq

//       {​​​​​      


//        public class PhoneNumber

//    {​​​​​

//        public string Number {​​​​​ get; set; }​​​​​

//    }​    public class Person

//    {​​​​​

//        public IEnumerable<PhoneNumber> PhoneNumbers {​​​​​ get; set; }​​​​​

//        public string Name {​​​​​ get; set; }​​​​​

//    }​​​​​

//    class Program

//    {​​​​​         

//        static IEnumerable<Person> people = new List<Person>();

//        static void Main(string[] args)

//        {​​​​​

//            people = new List<Person>() {​​​​​

//      new Person{​​​​​ Name="Ram", PhoneNumbers = new List<PhoneNumber>(){​​​​​ 

//      new PhoneNumber{​​​​​ Number ="1234567" }​​​​​,

//      new PhoneNumber{​​​​​ Number ="1234568" }​​​​​,

//      new PhoneNumber{​​​​​ Number ="1234569" }​​​​​,

//      new PhoneNumber{​​​​​ Number ="12345610" }​​​​​,

//      }​​​​​

//            }​​​​​,

//      new Person{​​​​​ Name="Raja", PhoneNumbers= new List<PhoneNumber>(){​​​​​

//             new PhoneNumber(){​​​​​ Number ="3445577" }​​​​​,

//             new PhoneNumber(){​​​​​ Number ="3445578" }​​​​​,

//            }​​​​​ 
//            }​​​​​,

//            new Person{​​​​​ Name="Suresh", PhoneNumbers=new List<PhoneNumber>(){​​​​​

//            new PhoneNumber(){​​​​​ Number="44444444" }​​​​​

//            }​​​​​
//            }​​​​​

//            }​​​​​;

          

//            IEnumerable<IEnumerable<PhoneNumber>> phoneLists = people.Select(p => p.PhoneNumbers);      

//        IEnumerable<PhoneNumber> phoneNumbers = people.SelectMany(p => p.PhoneNumbers);     
       

//        var directory = people.SelectMany(p => p.PhoneNumbers,(parent, child) => new {​​​​​ parent.Name, child.Number }​​​​​);

//        Console.ReadLine();

//        }​​​​​

//   }
// }