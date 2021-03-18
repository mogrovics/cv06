using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Ball : Object3D
    {
        private double radius;

        public Ball(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public override double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }

        public override void Draw()
        {
            Console.WriteLine("Ball:\nr = {0}                     S = {1:0.00}, V = {2:0.00}", radius, Area(), Volume());
        }
    }
}
