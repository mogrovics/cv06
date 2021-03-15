using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Ellipse : Object2D, Object2D.IObject2D, Object2D.IDraw
    {
        private double axisA;
        private double axisB;

        public Ellipse(double a, double b)
        {
            axisA = a;
            axisB = b;
        }

        public double Area()
        {
            return Math.PI * axisA * axisB;
        }

        public void Draw()
        {
            Console.WriteLine("Ellipse: a = {0}, b = {1},     area = {2}", axisA, axisB, Area());
        }
    }
}
