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

            // array of graphical objects
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

            /*
             * foreach cycle iterates through the 'graphics' array,
             * calls Draw() method of each element
             * and decides if an object is 2D or 3D to increment total area/volume values
             */
            foreach (GraphicalObject tmp in graphics)
            {
                Console.WriteLine("-------------------------------------------------------------");
                tmp.Draw();

                if (tmp is Object2D)
                {
                    totalArea2D += ((Object2D)tmp).Area();
                } 

                if (tmp is Object3D)
                {
                    totalArea3D += ((Object3D)tmp).Area();
                    totalVolume += ((Object3D)tmp).Volume();
                }
            }

            Console.WriteLine("-------------------------------------------------------------\n" + 
                              "\nTotal area of 2D objects: {0, 6:0.00}\n" +
                              "Total area of 3D objects: {1:0.00}\n" +
                              "Total volume: {2, 18:0.00}", totalArea2D, totalArea3D, totalVolume);

            Console.ReadLine();
        }
    }
}
