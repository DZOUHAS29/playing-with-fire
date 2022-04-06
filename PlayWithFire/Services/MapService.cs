using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Services
{
    class MapService
    {
        private Shape[,] _map;

        public Shape[,] Map
        {
            get
            {
                return _map;
            }
            set
            {
                _map = value;
            }
        }

        public void DrawMap(Shape[,] map, Graphics graphics)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    var shape = map[i, j];

                    if(shape != null)
                    {
                        shape.Draw(graphics);
                    }
                }
            }
        }
    }
}
