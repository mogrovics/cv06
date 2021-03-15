using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalArea2D = 0;
            double totalArea3D = 0;
            double totalVolume = 0;

            GraphicalObject[] graphics =
            {
                new Circle(3),
                new Rectangle(3, 2),
                new Ellipse(2, 3),
                new Triangle(4, 2, 5),
                new Cuboid(2, 3, 5),
                new Cylinder(3, 5),
                new Ball(3),
                new Pyramid(2, 2, 7)
            };

            foreach (GraphicalObject.IDraw obj in graphics)
            {
                obj.Draw();

                if (obj is Object2D)
                {
                    totalArea2D += ((Object2D.IObject2D)obj).Area();
                } 

                if (obj is Object3D)
                {
                    totalArea3D += ((Object3D.IObject3D)obj).Area();
                    totalVolume += ((Object3D.IObject3D)obj).Volume();
                }
            }

            Console.WriteLine("Total area of 2D objects: {0}\n" +
                              "Total area of 3D objects: {1}\n" +
                              "Total volume: {2}", totalArea2D, totalArea3D, totalVolume);

            Console.ReadLine();
        }
    }
}
