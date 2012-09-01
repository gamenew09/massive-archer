using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate
{
    class Program
    {

        static Game1 g;

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            g.running = false;
        }

        static void Main(string[] args)
        {
            Console.Title = "Game Console";

            Application.SetCompatibleTextRenderingDefault(false);
            g = new Game1();
            
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.EnableVisualStyles();
            g.running = true;
            Application.Run(g);

            while (g.running)
            {
                if (g.paused == false)
                {
                    g.drawAndUpdate();
                }
            }
            Console.WriteLine("Closing...");
        }
    }
}
