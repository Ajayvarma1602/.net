using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
    class ConstructorChainingDemo
    {
       static void Main()
        {
            Console.WriteLine("* Saving Account *");
            SavingsAccount s = new SavingsAccount();
            s.ShowBalance();
            Console.WriteLine("* Current Account *");
            CurrentAccount c = new CurrentAccount(); 
            c.ShowBalance();
            Console.WriteLine("Press enter to terminate");
            Console.ReadLine();
        }
    }

}
