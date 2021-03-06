using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Cylinder : Object3D
    {
        private double radius;
        private double height;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public override double Area()
        {
            return 2 * Math.PI * (Math.Pow(radius, 2) + radius * height);
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Cylinder:\nr = {0}, h = {1}              S = {2:0.00}, V = {3:0.00}", radius, height, Area(), Volume());
        }
    }
}
