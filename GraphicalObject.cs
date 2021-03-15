using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    abstract class GraphicalObject
    {
        public interface IDraw
        {
            void Draw();
        }
    }
}
