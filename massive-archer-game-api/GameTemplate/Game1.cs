using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassiveArcher;
using System.Drawing;
using System.Windows.Forms;

namespace GameTemplate
{
    class Game1 : Game
    {

        #region Leave Alone
        public bool running;
        public bool paused;

        private Panel drawingPanel;

        public Game1() : base()
        {
            drawingPanel = new Panel();
            drawingPanel.BackColor = Color.SlateBlue;
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Dock = DockStyle.Fill;
            drawingPanel.Paint += drawingPanel_Paint;
            Controls.Add(drawingPanel);
            running = true;
            paused = false;
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            GameDraw(e.Graphics);
        }

        public override void drawAndUpdate()
        {
            drawingPanel.Invalidate();
            GameUpdate();
        }

        #endregion

        public override void GameDraw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color.Aqua, 10), new Point(1,1), new Point(100,100));
        }

        public override void GameUpdate()
        {
            if (Keyboard.IsKeyPressed(Keys.Escape))
            {
                this.Close();
            }
        }

    }
}
