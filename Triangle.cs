using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Triangle : Object2D, Object2D.IObject2D, Object2D.IDraw
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
        
        public double Area()
        {
            double s = (edgeA + edgeB + edgeC) / 2;
            return Math.Sqrt(s * (s - edgeA) * (s - edgeB) * (s - edgeC));
        }

        public void Draw()
        {
            Console.WriteLine("Triangle: a = {0}, b = {1}, c = {2}    area = {3}", edgeA, edgeB, edgeC, Area());
        }
    }
}
