using PlayWithFire.Others;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Shapes.Creatures
{
    class Player : Shape
    {
        private readonly KeyControls _keyControls;
        public Player(Point location, Size size, Brush brush, KeyControls keyControls) : base(location, size, brush)
        {
            _keyControls = keyControls;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, Rectangle);
        }
    }
}
