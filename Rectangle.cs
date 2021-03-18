using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Rectangle : Object2D 
    { 
        private double height;
        private double width;

        public Rectangle(double a, double b)
        {
            height = Math.Abs(a);
            width = Math.Abs(b);
        }

        public override double Area()
        {
            return height * width;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle:   a = {0}, b = {1}              S = {2:0.00}", height, width, Area());
        }
    }
}
