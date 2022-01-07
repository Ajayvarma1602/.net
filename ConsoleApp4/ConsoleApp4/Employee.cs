using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    interface IEmployee
    {
        void AddEmp(string name, int id);
        void EmpDetails(string deatils);
    }

    public class Employees : IEmployee
    {
        public string name="ajay";
        public int id=101;

        public void AddEmp(string name, int id)
        {
            Console.WriteLine("student name is {0} and id is{1}", name, id);
        }

        public void EmpDetails(string deatils)
        {
            throw new NotImplementedException();
        }

       

        internal void AddEmp()
        {
            Console.WriteLine("student name is {0} and id is{1}", name, id);

        }
    }
}
