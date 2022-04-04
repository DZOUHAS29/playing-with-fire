using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire
{
    class BreakableWall: Wall
    {
        public BreakableWall(Point location, Size size, Brush brush) : base(location, size, brush)
        {

        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brush, Rectangle);
        }

    }
}
