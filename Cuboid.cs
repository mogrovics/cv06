using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Cuboid : Object3D
    {
        private double height;
        private double width;
        private double length;

        public Cuboid(double a, double b, double c)
        {
            height = Math.Abs(a);
            width = Math.Abs(b);
            length = Math.Abs(c);
        }
        public override double Area()
        {
            return 2 * (height * width + width * length + height * length);
        }

        public override double Volume()
        {
            return height * width * length;
        }

        public override void Draw()
        {
            Console.WriteLine("Cuboid:      a = {0}, b = {1}, c = {2}       S = {3:0.00}, V = {4:0.00}", height, width, length, Area(), Volume());
        }
    }
}
