using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Shapes.Bombs
{
    abstract class Bomb : Shape
    {
        public Bomb(Point location, Size size, Brush brush) : base(location, size, brush)
        {

        }
    }
}
