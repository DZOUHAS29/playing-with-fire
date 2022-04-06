using PlayWithFire.Interfaces;
using PlayWithFire.Others;
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
    class BasicMapGeneratorService : IMapGeneratorService
    {
        public Shape[,] CreateMap(Size mapSize, Size shapeSize)
        {
            var shapes = new Shape[mapSize.Width, mapSize.Height];

            for (int i = 0; i < shapes.GetLength(0); i++)
            {

                for (int j = 0; j < shapes.GetLength(1); j++)
                {
                    var location = new Point(i * shapeSize.Width, j * shapeSize.Height);

                    BuildOuterWalls(i, j, shapes, location, shapeSize);
                    BuildInnerWalls(i, j, shapes, location, shapeSize);

                }
            }

            return shapes;
        }

        private void BuildInnerWalls(int i, int j, Shape[,] shapes, Point location, Size shapeSize)
        {
            if (!IsOuterWall(i,j,shapes) && i%2 == 0 && j%2 == 0)
            {
                shapes[i, j] = new UnbreakableWall(location, shapeSize,
                    ColorTranslatorService.ConvertHexToBrush(Settings.Wall.UbreakableColor));
            }
        }

        private void BuildOuterWalls(int i, int j, Shape[,] shapes, Point location, Size shapeSize)
        {
            if (IsOuterWall(i, j, shapes))
            {
                shapes[i, j] = new UnbreakableWall(location, shapeSize, 
                    ColorTranslatorService.ConvertHexToBrush(Settings.Wall.UbreakableColor));
            }
        }

        private bool IsOuterWall(int i, int j, Shape[,] shapes)
        {
            return i == 0 || j == 0 || i == shapes.GetLength(0) - 1 || j == shapes.GetLength(1) - 1;
        }

        public Shape[,] CreateMap(int collCount, int rowCount, Size shapeSize)
        {
            return CreateMap(new Size(collCount, rowCount), shapeSize);
        }
    }
}
