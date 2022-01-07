using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
    class Account
    {
        int balance;
        public Account()
        {
            balance = 1000;
            Console.WriteLine("default constructor is invoked");
        }
        public Account(int b)
        {
            balance = b;
            Console.WriteLine("parameterized constructor is invoked");
        }
        public void ShowBalance()
        {
            Console.WriteLine("existing balance = "+balance);
        }
    }
    class SavingsAccount : Account
    {
        public SavingsAccount()
        {
            Console.WriteLine("Default constructor of SavingsAccount invoked");
        }
        public SavingsAccount(int sb)
        {
            Console.WriteLine("Parameterized constructor of SavingsAccount invoked");
        }
    }
    class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            Console.WriteLine("Default constructor of CurrentAccount invoked");
        }
        public CurrentAccount(int cb):base(cb)
        {
            Console.WriteLine("Parameterized constructor of CurrentAccount invoked");
        }
    }
}
