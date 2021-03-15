using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Circle : Object2D, Object2D.IObject2D, Object2D.IDraw
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle: r = {0},     area = {1}", radius, Area());
        }

    }
}
