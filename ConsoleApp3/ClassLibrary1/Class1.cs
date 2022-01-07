using System;

namespace ClassLibrary1
{
    public class Ans
    {
        public int Num1;
            public int Num2;
        public Ans(int num1, int num2)
        {
            Num1= num1;
            Num2 = num2;
        }
        public  int Add ()
        {
            return Num1 + Num2;
        }
        public  int Sub()
        {
           
            return Num1-Num2;
        }
    }
}
