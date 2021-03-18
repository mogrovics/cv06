using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Ellipse : Object2D
    {
        private double axisA;
        private double axisB;

        public Ellipse(double a, double b)
        {
            axisA = a;
            axisB = b;
        }

        public override double Area()
        {
            return Math.PI * axisA * axisB;
        }

        public override void Draw()
        {
            Console.WriteLine("Ellipse:     a = {0}, b = {1}              S = {2:0.00}", axisA, axisB, Area());
        }
    }
}
