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
        float xpos;
        float ypos;
        double angleInDegrees;
        int speed = 5;
        int deltaY;
        int deltaX;

        public Bullet(Point aim, int x, int y)
        {
            Aim = aim;
            xpos = x;
            ypos = y;
            deltaY = Aim.Y - y;
            deltaX = Aim.X - x;
        }

        int time = 0;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public void Draw(Graphics g)
        {

            angleInDegrees = Math.Atan2(deltaY, deltaX) * 180 / Math.PI;
            xpos += (float)Math.Cos(angleInDegrees / 360.0 * 2 * Math.PI) * speed;
            ypos += (float) Math.Sin(angleInDegrees / 360.0 * 2 * Math.PI) * speed;
            g.FillEllipse(Brushes.Red, xpos, ypos, 5, 5);
            time++;
        }

        public void BullCollision(List<Enemy> Enemies)
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                if (Enemies[i].Hitbox.Contains(new Point(Convert.ToInt32(xpos), Convert.ToInt32(ypos))))
                {
                    Enemies.Remove(Enemies[i]);
                }
            }
        }
    }
}
