using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire
{
    abstract class Wall: Shape
    {
        public Wall(Point location, Size size, Brush brush) :base(location, size, brush)
        {

        }
    }
}
