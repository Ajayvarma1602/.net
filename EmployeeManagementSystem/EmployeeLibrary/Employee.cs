using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public enum GenderType{Male,Female,Others}
    public class Employee
    {
        #region Fields
        int empNo;
        string empName;
        double empSalary;
        DateTime doj;
        GenderType empGender;
        static int count;
        #endregion

        #region Constructors
        public Employee()
        {
            count++;
           this.empNo = count;
            empSalary = 10000;
        }

        public Employee(double s)
        {
            count++;
            this.empNo = count;
            empSalary = s;
        }
        #endregion
        #region Properties

        public GenderType EmployeeGender
        {
            set { empGender = value; }
            get { return empGender; }
        }
        public int EmployeeNumber
        {
          //  set { empNo = value; }

            get { return empNo; }
        }

        public string EmployeeName
        {
            set { empName = value; }

            get { return empName; }
        }
        public double EmployeeSalary
        {
            set { empSalary = value; }

            get { return empSalary; }
        }
        public DateTime DateOfJoining
        {
            set{ doj = value; }
            get { return doj; }
        }
        #endregion 
    }
}
