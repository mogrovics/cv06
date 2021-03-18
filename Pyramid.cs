using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Pyramid : Object3D
    {
        private double height;
        private double width;
        private double length;

        public Pyramid(double a, double b, double h)
        {
            height = h;
            width = a;
            length = b;
        }

        public override double Area()
        {
            double widthBaseHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((width / 2), 2));
            double lengthBaseHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((length / 2), 2));


            return width * length + 2 * (width * widthBaseHeight / 2 + length * lengthBaseHeight / 2);
        }

        public override double Volume()
        {
            return (height * width * length) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine("Pyramid:\na = {0}, b = {1}, h = {2}       S = {3:0.00}, V = {4:0.00}", width, length, height, Area(), Volume());
        }

    }
}
