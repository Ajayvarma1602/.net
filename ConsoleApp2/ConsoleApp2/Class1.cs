

//standard query operators

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }

        public static void Main()
        {
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
};

            var filteredResult = from s in studentList
                                 where s.Age > 12 && s.Age < 20
                                 select s.StudentName;


            var orderByResult = from s in studentList
                                orderby s.StudentName
                                select s;

            var orderByDescendingResult = from s in studentList
                                          orderby s.StudentName descending
                                          select s;

            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);


            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var reverse = (from s in studentList select s).Reverse();

            foreach (var item in orderByDescendingResult)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
        }
    }
}


//IList mixedList = new ArrayList();
//            mixedList.Add(0);
//            mixedList.Add("One");
//            mixedList.Add("Two");
//            mixedList.Add(3);
//            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

//            var stringResult = from s in mixedList.OfType<string>()
//                               select s;

//            var intResult = from s in mixedList.OfType<int>()
//                            select s;