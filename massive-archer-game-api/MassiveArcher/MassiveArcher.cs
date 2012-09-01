using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MassiveArcher
{
    public class MassiveArcher
    {

        public static MassiveArcher getInstance()
        {
            return new MassiveArcher();
        }

        public void drawLine(Graphics g, Pen p, Point p1, Point p2)
        {
            g.DrawLine(p, p1, p2);
        }

    }
}
