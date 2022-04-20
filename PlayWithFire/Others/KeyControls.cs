using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayWithFire.Others
{
    class KeyControls
    {
        public KeyControls(Keys moveUp, Keys moveDown, Keys moveLeft, Keys moveRight, Keys placeBomb)
        {
            MoveUp = moveUp;
            MoveDown = moveDown;
            MoveLeft = moveLeft;
            MoveRight = moveRight;
            PlaceBomb = placeBomb;
        }

        public Keys MoveUp { get; set; }
        public Keys MoveDown { get; set; }
        public Keys MoveLeft { get; set; }
        public Keys MoveRight { get; set; }
        public Keys PlaceBomb { get; set; }

        public static KeyControls KeyControls1()
        {
            return new KeyControls(Keys.W, Keys.S, Keys.A, Keys.D, Keys.Space);
        }
    }
}
