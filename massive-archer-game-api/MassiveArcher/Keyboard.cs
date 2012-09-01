using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassiveArcher
{
    public class Keyboard
    {
        public static bool IsKeyPressed(Keys key)
        {
            if (key != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsKeyReleased(Keys key)
        {
            if (key == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
