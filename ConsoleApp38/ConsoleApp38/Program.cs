//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp38
//{
 
//              class Person
//        {
//            public string Name { get; set; }
//            public string Address { get; set; }
//            public int Age { get; set; }
//        }
//    class PersonImplementation
//    {
//        public string GetNamesa(IList<Person> person)
//        {
//            //var qry = from n in person select n.Name;
//            //   foreach(var item in qry)
//            // {
//            //   return item.Name+item.Address ;
//            //     }
//            // string name = string.Join("", qry);
//            //return name;

//            string name = "";
//            foreach (var item in person)
//            {
//                name += item.Name + " " + item.Address + " ";

//            }
//            return name;

//        }
//        public double Average(IList<Person> person)
//        {
//            var qry = from b in person select b.Age;
//            return qry.Average();
//        }

//        public int Max(IList<Person> person)
//        {
//            var qry = from a in person select a.Age;
//            return qry.Max();
//        }
//    }

//            class Program
//            {
//                static void Main()
//                {
//                    PersonImplementation imp = new PersonImplementation();
//                    IList<Person> person = new List<Person>();
//                    person.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
//                    person.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
//                    person.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
//                    per

using System;
            using System.Linq;
            using System.Collections.Generic;
namespace ConsoleApp38
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
    class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            //var qry = from name in person select name.Name;
            //string names=string.join(",",qry);
            string name = "";
            foreach (var item in person)
            {
                name += item.Name + " " + item.Address + " ";
            }
            return name;
        }
        public double Average(IList<Person> person)
        {
            var qry = from b in person select b.Age;
            return qry.Average();
        }

        public int Max(IList<Person> person)
        {
            var qry = from a in person select a.Age;
            return qry.Max();
        }

        class Source
        {

            static void Main()
            {
                // var line1 = System.Console.ReadLine().Trim();
                // var num = Int32.Parse(line1);
                PersonImplementation imp = new PersonImplementation();
                IList<Person> person = new List<Person>();
                person.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
                person.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
                person.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
                person.Add(new Person { Name = "Jennifer", Address = "I1704", Age = 33 });
                imp.Max(person);
                imp.Average(person);
                imp.GetName(person);
                 Console.ReadLine();
                //System.Console.WriteLine(num);
            }
        }
    }
}