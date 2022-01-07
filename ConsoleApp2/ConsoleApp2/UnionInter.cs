
//USING UNION  INTERSECTION  DISTINCT  EXCEPT

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    class UnionInter
    {
        static void Main(string[] args)
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Union(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Union(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}



//string[] employeesInDeptA = { "Asutosh", "Kapil", "Sumit", "Rajat" };
//string[] employeesInDeptB = { "Preeti", "Sumit", "Kanupriya", "Kapil" };

//var result = employeesInDeptA.Intersect(employeesInDeptB);

//Console.WriteLine("Common Employees in Department A and B:");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}



//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> intCollection = new List<int>()
//            {
//                1,2,3,2,3,4,4,5,6,3,4,5
//            };

//        //Using Method Syntax
//        var MS = intCollection.Distinct();

//        //Using Query Syntax
//        var QS = (from num in intCollection
//                  select num).Distinct();
//        foreach (var item in MS)
//        {
//            Console.WriteLine(item);
//        }

 //       Console.ReadKey();
  //  }



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
    //        List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

    //        //Method Syntax
    //        var MS = dataSource1.Except(dataSource2).ToList();

    //        //Query Syntax
    //        var QS = (from num in dataSource1
    //                  select num)
    //                  .Except(dataSource2).ToList();

    //        foreach (var item in QS)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        Console.ReadKey();
    //    }
   // }
