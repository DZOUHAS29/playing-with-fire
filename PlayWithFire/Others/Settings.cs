using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Others
{
    static class Settings
    {
        public static readonly int ShapeGap = 1;

        public static class Wall
        {
            // 1 - 100, 100 = 100% wall 
            public static int BreakableWallSpawnChance = 70;

            public static readonly string UbreakableColor = "#a3986a";
            public static readonly string BreakableColor = "#b00b69";
        }


        public static class Player
        {
        }
    }
}
