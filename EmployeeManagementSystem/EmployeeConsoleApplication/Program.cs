using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace EmployeeConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(75000);
            Employee emp2 = new Employee();

//emp1.EmployeeNumber = 15;
            emp1.EmployeeName = "ajay";
//emp1.EmployeeSalary = 25000;
            emp1.DateOfJoining = Convert.ToDateTime("10/11/2021");
            emp1.EmployeeGender=EmployeeLibrary.GenderType.Male;
            Console.WriteLine("Employee number= "+emp1.EmployeeNumber);

            Console.WriteLine("Employee name= "+emp1.EmployeeName);

            Console.WriteLine("Employee salary= "+emp1.EmployeeSalary);
            Console.WriteLine("Date of joining= "+emp1.DateOfJoining.ToLongDateString());
            Console.WriteLine("employee gender= "+emp1.EmployeeGender);
            Console.ReadLine();
        }
    }
}
