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
        private int _speed = 3;
        private readonly KeyControls _keyControls;
        public Player(Point location, Size size, Brush brush, KeyControls keyControls) : base(location, size, brush)
        {
            _keyControls = keyControls;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, Rectangle);
        }
        private Point GetFutureLocationAfterMove(List<Keys> pressedKeys)
        {
            var futureLocation = new Point(Location.X, Location.Y);
            // 50, 50
            pressedKeys.ForEach(key =>
            {
                // 50,53
                if (_keyControls.MoveUp == key)
                {
                    futureLocation.Y = MoveY(-1).Y;
                }

                if (_keyControls.MoveDown == key)
                {
                    futureLocation.Y = MoveY(1).Y;
                }

                // 50, 50 -> 47,50
                if (_keyControls.MoveLeft == key)
                {
                    futureLocation.X = MoveX(-1).X;
                }

                if (_keyControls.MoveRight == key)
                {
                    futureLocation.X = MoveX(1).X;
                }
            });

            return futureLocation;
        }

        private bool CanMoveToLocation(Point futureLocation, Shape[,] grid)
        {
            var futureRectangle = new Rectangle(futureLocation, Size);

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    var shape = grid[i, j];

                    if(shape != null && shape.Rectangle.IntersectsWith(futureRectangle))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public void Move(List<Keys> pressedKeys, Shape[,] grid)
        {
            var futureLocation = GetFutureLocationAfterMove(pressedKeys);

            if (CanMoveToLocation(futureLocation, grid))
            {
                Location = futureLocation;
            }

        }

        private Point MoveX(int direction)
        {
            return new Point(Location.X + (direction * _speed), Location.Y);
        }

        private Point MoveY(int direction)
        {
            return new Point(Location.X, Location.Y + (direction * _speed));
        }
    }
}
