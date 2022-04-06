using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Interfaces
{
    interface IMapGeneratorService
    {
        Shape[,] CreateMap(Size mapSize, Size shapeSize);
        Shape[,] CreateMap(int collCount, int rowCount, Size shapeSize);
    }
}
