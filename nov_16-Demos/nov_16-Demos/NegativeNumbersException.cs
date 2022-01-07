using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class NegativeNumbersException:ApplicationException
    {
        public NegativeNumbersException()
        {
            Console.WriteLine("error: negative number not allow");
        }   
    }
}
