using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Circle : Object2D
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        // S = PI * r^2
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override void Draw()
        {
            Console.WriteLine("Circle:\nr = {0}                     S = {1:0.00}", radius, Area());
        }

    }
}
