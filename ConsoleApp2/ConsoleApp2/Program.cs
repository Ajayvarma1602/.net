


//Single,single or default  and aggregate functions

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("The only element in oneElementList: {0}",
                         oneElementList.SingleOrDefault());

            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            Console.WriteLine("The only element which is less than 10 in intList: {0}",
                         intList.Single(i => i < 10));
        }
    }
}

//IList<int> oneElementList = new List<int>() { 7 };
//IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
//IList<string> emptyList = new List<string>();

////following throws error because list contains more than one element which is less than 100
//Console.WriteLine("Element less than 100 in intList: {0}", intList.Single(i => i < 100));

////following throws error because list contains more than one element which is less than 100
//Console.WriteLine("Element less than 100 in intList: {0}",
//                                    intList.SingleOrDefault(i => i < 100));

////following throws error because list contains more than one elements
//Console.WriteLine("The only Element in intList: {0}", intList.Single());

////following throws error because list contains more than one elements
//Console.WriteLine("The only Element in intList: {0}", intList.SingleOrDefault());

////following throws error because list does not contains any element
//Console.WriteLine("The only Element in emptyList: {0}", e



//List<Employee> Employee = new List<Employee>() {
//    new Employee() {
//            EmpID = 1, Name = "Gnanavel", Salary = 50000
//        },
//        new Employee() {
//            EmpID = 2, Name = "Sekar", Salary = 40000
//        },
//        new Employee() {
//            EmpID = 3, Name = "Subash", Salary = 20000
//        },
//};


//var CountValue = Employee.Count();
//Console.WriteLine("Count of Employee: {0}", CountValue);

//var maxSalary = Employee.Max(a => a.Salary);
//Console.WriteLine("Max salary: {0}", maxSalary);


//int[] Addition = { 1, 2, 3, 4 };
//var number = Addition.Max();
//Console.WriteLine("Max salary: {0}", number);


//int[] Addition = { 1, 2, 3, 4 };
//var Min = Addition.Min();
//Console.WriteLine("Min Number: {0}", Min);


//int[] Addition = { 1, 2, 3, 4 };
//var Sum = Addition.Sum();
//Console.WriteLine("Sum of Number: {0}", Sum);

//int[] A = { 1, 2, 3, 4 };
//var Avg = A.AVERAGE();
//Console.WriteLine("AVG of Number: {0}", Avg);

