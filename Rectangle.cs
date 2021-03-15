using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Rectangle : Object2D, Object2D.IObject2D, Object2D.IDraw
    {
        private double height;
        private double width;

        public Rectangle(double a, double b)
        {
            height = a;
            width = b;
        }

        public double Area()
        {
            return height * width;
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle: a = {0}, b = {1},     area = {2}", height, width, Area());
        }
    }
}
