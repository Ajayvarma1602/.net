using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    public class Student
    {
        //fields
        int rollNo;
        string studentName;
        double studentMarks;
      
        //properties to get/set values for the fields
        //creating property for empNo

    

        public double SMarks
        {
            set { studentMarks = value; }
            get { return studentMarks; }
        }
        public int RollNo
        {
            set { rollNo = value; }
            get { return rollNo; }
        }

        public string SName
        {
            set
            {
                studentName = value;
            }
            get { return studentName; }
        }
    }
}
