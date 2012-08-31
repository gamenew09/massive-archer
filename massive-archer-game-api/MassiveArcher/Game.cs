using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassiveArcher
{
    abstract class Game : Form
    {

        public Graphics graphics;

        public Game()
        {
            graphics = MassiveArcher.createGraphicsObject(this);
        }

        public void drawAndUpdate()
        {
            Update();
            Draw();
        }

        public abstract void Update();

        public abstract void Draw();
    }
}
