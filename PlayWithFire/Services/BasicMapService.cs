using PlayWithFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Services
{
    /// <summary>
    /// 
    /// </summary>
    class BasicMapService : IMapService
    {
        public Shape[,] CreateMap(Size mapSize, Size shapeSize)
        {
            var shapes = new Shape[mapSize.Width, mapSize.Height];

            for (int i = 0; i < shapes.GetLength(0); i++)
            {

                for (int j = 0; j < shapes.GetLength(1); j++)
                {
                    if(i == 0)
                    {
                        //shapes[i,j] = new Wall()
                    }
                }
            }

            return shapes;
        }

        public Shape[,] CreateMap(int collCount, int rowCount, Size shapeSize)
        {
            return CreateMap(new Size(collCount, rowCount), shapeSize);
        }
    }
}
