using PlayWithFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayWithFire.Others;

namespace PlayWithFire
{
    abstract class Shape : IDrawable
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(Location, Size);
            }
            set
            {
                Location = value.Location;
                Size = value.Size;
            }
        }

        protected Rectangle DrawRectangle
        {
            get
            {
                return new Rectangle(new Point(Location.X + Settings.ShapeGap, Location.Y + Settings.ShapeGap),
                    new Size(Size.Width - 2 * Settings.ShapeGap, Size.Height - 2 * Settings.ShapeGap)); ;
            }
        }

        public Brush Brush { get; set; }

        public Shape(Point location, Size size, Brush brush)
        {
            Location = location;
            Size = size;
            Brush = brush;
        }
        public abstract void Draw(Graphics graphics);
    }
}
