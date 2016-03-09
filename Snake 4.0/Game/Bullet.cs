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


        public Bullet(Point aim)
        {
            Aim = aim;
        }

        int time = 0;
        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public void Draw(Graphics g, int x, int y)
        {
            g.DrawLine(Pens.Red, x, y, Aim.X, Aim.Y);
            time++;
        }

    }
}
