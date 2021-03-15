using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    abstract class Object2D : GraphicalObject
    {
        public interface IObject2D
        {
            double Area();
        }
    }
}
