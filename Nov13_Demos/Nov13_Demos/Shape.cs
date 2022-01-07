using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
   abstract class Shape
    {
        protected int side1;
        protected double area;

        public abstract void ComputeArea();

        public void Display()
        {
            Console.WriteLine(area);
        }
    }

    class Rectangle : Shape
    {
        int side2;
        public void AcceptSideValues()
        {
            Console.WriteLine("enter side 1 = ");
            side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter side2 = ");
            side2 = Convert.ToInt32(Console.ReadLine());
        }
        public override void ComputeArea()
        {
            area = side1 * side2;
        }
    }

    class Circle : Shape{
        public void AcceptSideValues()
        {
            Console.WriteLine("enter side 1 = ");
            side1 = Convert.ToInt32(Console.ReadLine());
        }
        public override void ComputeArea()
        {
            area = side1 * side1;
        }
    }
    }
