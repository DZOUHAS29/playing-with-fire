using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Shapes.Environment
{
    abstract class Environment : Shape
    {
        public Environment(Point location, Size size, Brush brush) : base(location, size, brush)
        {

        }
    }
}
