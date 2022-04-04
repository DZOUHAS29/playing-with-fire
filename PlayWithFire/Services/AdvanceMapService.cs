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
        public Shape[,] CreateMap(Size size)
        {
            throw new NotImplementedException();
        }

        public Shape[,] CreateMap(int collCount, int rowCount)
        {
            return CreateMap(new Size(collCount, rowCount));
        }
    }
}
