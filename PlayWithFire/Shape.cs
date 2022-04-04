using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire
{
    abstract class Shape
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
        public Brush Brush { get; set; }

        public Shape()
        {
            this.Rectangle = new Rectangle();
        }
    }
}
