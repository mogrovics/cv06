using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    abstract class Object3D : GraphicalObject
    {
        public interface IObject3D
        {
            double Area();
            double Volume();
        }
    }
}
