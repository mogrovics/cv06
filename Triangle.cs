using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Triangle : Object2D
    {
        private double edgeA;
        private double edgeB;
        private double edgeC;

        public Triangle(double a, double b, double c)
        {
            edgeA = a;
            edgeB = b;
            edgeC = c;
        }

        // Heron's formula (https://en.wikipedia.org/wiki/Heron%27s_formula)
        public override double Area()
        {
            double s = (edgeA + edgeB + edgeC) / 2;
            return Math.Sqrt(s * (s - edgeA) * (s - edgeB) * (s - edgeC));
        }

        public override void Draw()
        {
            Console.WriteLine("Triangle:    a = {0}, b = {1}, c = {2}       S = {3:0.00}", edgeA, edgeB, edgeC, Area());
        }
    }
}
