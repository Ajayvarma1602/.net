using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
    class PayTMApp
    {
        public void MakePayment(IPayTM app)
        {
            app.Pay();
        }
    }
    class InterfaceDemo
    {
        static void Main()
        {
            SwiggyApp s = new SwiggyApp();
            s.Login();
            FlipkartApp f = new FlipkartApp();
            f.Login();
            PayTMApp p = new PayTMApp();
            p.MakePayment(s);
            p.MakePayment(f);
           
            Console.ReadLine()
;        }
    }
}
