using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Interfaces
{
    interface IMapService
    {
        Shape[,] CreateMap(Size size);
        Shape[,] CreateMap(int collCount, int rowCount);
    }
}
