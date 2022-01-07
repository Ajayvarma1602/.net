using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
    class OnlineApp
    {
        public void Login()
        {
            Console.WriteLine("login with email");
        }
        public void Register()
        {
            Console.WriteLine("login with email");
        }
    }
    class SwiggyApp : OnlineApp,IPayTM
    {
        public void Pay()
        {
            Console.WriteLine("swiggy paytm using paytm ");
        }
    }
    class FlipkartApp : OnlineApp, IPayTM
    {
        public void Pay()
        {
            Console.WriteLine("flipkart using paytm");
        }
    }
}
