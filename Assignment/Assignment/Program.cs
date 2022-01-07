using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment{
    class Operation
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public char opr { get; set; }

        public Operation(double num1, double num2, char op)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.opr = op;
        }
        static void Main(string[] args)
        {


            double Result = 0.00;
            Operation o = new Operation(15, 0, '/');
            //  Result = Calculator(Num1, Num2, opr);
            o.Calculator(Result);
        }
    }
    class Source { 
        public string ExceptionHandling(Operation o) {
            try
            {
        
                if (o.opr != '+' && o.opr != '-' &&
                    o.opr != '*' && o.opr != '/')
                    throw new Exception(o.opr.ToString());
    
                if (o.opr == '/')
                    if (o.Num2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed");
         
            }
            catch (DivideByZeroException ex)
            {
                return(ex.Message);
            }

        }

        public string Calculator(Operation o)
        {
            double Result = 0.00;

            switch (o.opr)
            {
                case '+':
                    Result = o.Num1 + o.Num2;
                    break;
                case '-':
                    Result = o.Num1 - o.Num2;
                    break;
                case '*':
                    Result = o.Num1 * o.Num2;
                    break;
                case '/':
                    Result = o.Num1 / o.Num2;
                    break;
            }
            return Result.ToString();
        }


    }



    }
     

