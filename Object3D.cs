using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public abstract class Object3D : GraphicalObject
    {
        public abstract double Area();
        public abstract double Volume();
    }
}
