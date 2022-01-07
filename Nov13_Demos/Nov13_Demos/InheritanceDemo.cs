using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
    class InheritanceDemo
    {
        static void Main()
        {
            Console.WriteLine("rectanle");
            Rectangle r = new Rectangle();
            r.AcceptSideValues();
            r.ComputeArea();
            r.Display();

            Console.WriteLine("circle");
            Circle c = new Circle();
            c.AcceptSideValues();
            c.ComputeArea();
            c.Display();

            Console.ReadLine();
        }
    }
}
