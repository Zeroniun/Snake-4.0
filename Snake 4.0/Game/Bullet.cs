using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_4._0.Game
{
    public class Bullet
    {
        Point Aim;
        int Time = 0;

        public Bullet(Point aim)
        {
            Aim = aim;
        }

        public void Draw(Graphics g, int X, int Y)
        {
            g.DrawLine(Pens.Red, X, Y, Aim.X, Aim.Y);
            Time++;
        }
    }
}
