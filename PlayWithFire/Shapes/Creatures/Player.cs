using PlayWithFire.Others;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Move(List<Keys> pressedKeys)
        {
            pressedKeys.ForEach(key =>
            {
                if(_keyControls.MoveUp == key)
                {
                    MoveY(-1);
                }

                if (_keyControls.MoveDown == key)
                {
                    MoveY(1);
                }
            });
        }

        private void MoveX()
        {

        }

        private void MoveY(int direction)
        {
            Location = new Point(Location.X, Location.Y + (direction));
        }
    }
}
