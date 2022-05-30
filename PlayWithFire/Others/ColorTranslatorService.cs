using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFire.Others
{
    class ColorTranslatorService
    {
        public static Brush ConvertHexToBrush(string hex)
        {
            return new SolidBrush(ColorTranslator.FromHtml(hex));
        }
    }

}
