using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Operation
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public char opr { get; set; }

        public Operation(double num1, double num2, char op)
        {
            Num1 = num1;
            Num2 = num2;
            opr = op;
        }
    }
    class Source
    {
        public string ExceptionHandle(Operation o)
        {

            try
            {
                if (o.opr == '/' && o.Num2 == 0)
                {
                    throw new ArithmeticException("Division by zero is not allowed");
                }
                else if (o.opr == '+' || o.opr == '-' || o.opr == '*' || o.opr == '/' || o.opr == '%')
                {
                    return "No Exception Found";
                }
                else
                {
                    throw new Exception("Operator Invalid");
                }

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Calculator(Operation o)
        {
            ExceptionHandle(o);
            switch (o.opr)
            {
                case '+': return $"{o.Num1 + o.Num2}";
  
                case '-': return $"{o.Num1 - o.Num2}";
                case '*': return $"{o.Num1 * o.Num2}";
                case '/':
                    if (o.Num2 == 0)
                    {
                        return "Divide by Exception";
                    }
                    else
                    {
                        return $"{o.Num1 / o.Num2}";
                    }

                case '%': return $"{o.Num1 % o.Num2}";
                default:
                    break;
            }
            return "";
        }
        public static void Main()
        {
            Operation o = new Operation(15, 0, '/');
            Source sc = new Source();
            Console.WriteLine(sc.Calculator(o));
            Console.ReadLine();
        }
    }
}