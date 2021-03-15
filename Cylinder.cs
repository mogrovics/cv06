using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Cylinder : Object3D, Object3D.IObject3D, Object3D.IDraw
    {
        private double radius;
        private double height;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public double Area()
        {
            return 2 * Math.PI * radius * radius + 2 * Math.PI * radius * height;
        }

        public double Volume()
        {
            return Math.PI * radius * radius * height;
        }

        public void Draw()
        {
            Console.WriteLine("Cylinder: r = {0}, h = {1}    area = {2}, volume = {3}", radius, height, Area(), Volume());
        }
    }
}
