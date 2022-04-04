using PlayWithFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Services
{
    class AdvanceMapService : IMapService
    {
        public Shape[,] CreateMap(Size mapSize, Size shapeSize)
        {
            throw new NotImplementedException();
        }

        public Shape[,] CreateMap(int collCount, int rowCount, Size shapeSize)
        {
            return CreateMap(new Size(collCount, rowCount), shapeSize);
        }
    }
}
