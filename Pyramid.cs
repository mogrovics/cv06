using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Pyramid : Object3D, Object3D.IObject3D, Object3D.IDraw
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

        public double Area()
        {
            double widthBaseHeight = Math.Sqrt(height * height + (width / 2));
            double lengthBaseHeight = Math.Sqrt(height * height + (length / 2));


            return width * length + 2 * (width * widthBaseHeight / 2 + length * lengthBaseHeight / 2);
        }

        public double Volume()
        {
            return (height * width * length) / 3;
        }

        public void Draw()
        {
            Console.WriteLine("Pyramid:     a = {0}, b = {1}, h = {2}       S = {3:0.00}, V = {4:0.00}", width, length, height, Area(), Volume());
        }

    }
}
