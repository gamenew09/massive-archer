using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassiveArcher
{
    public abstract class Game : Form
    {

        protected Graphics getGraphics()
        {
            return this.CreateGraphics();
        }

        public Game()
        {
            this.Size = new Size(640,390);
        }

        public abstract void drawAndUpdate();

        public abstract void GameUpdate();

        public abstract void GameDraw(Graphics graphics);
    }
}
