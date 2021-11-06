using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2___Object_Collisions
{
    class Point3D
    {
        internal double x, y, z;

        public Point3D()
        {
            x = y = 0;
        }
        public Point3D(double i, double j, double k)
        {
            this.x = i;
            this.y = j;
            this.z = k;
        }
    }
}
