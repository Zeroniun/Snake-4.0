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
        int X, Y;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public void Draw(Graphics g, int x, int y)
        {
            X = x;
            Y = y;
            g.DrawLine(Pens.Red, x, y, Aim.X, Aim.Y);
            time++;
        }

        public void BullCollision(List<Enemy> Enemies)
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                if (LineIntersectsRect(new Point(X, Y), new Point(Aim.X, Aim.Y), new Rectangle(Enemies[i].LocationX - 10, Enemies[i].LocationY - 10, 15, 15)))
                {
                    Enemies.Remove(Enemies[i]);
                }
            }
        }
        private bool LineIntersectsRect(Point p1, Point p2, Rectangle r)
        {
            return LineIntersectsLine(p1, p2, new Point(r.X, r.Y), new Point(r.X + r.Width, r.Y)) ||
                   LineIntersectsLine(p1, p2, new Point(r.X + r.Width, r.Y), new Point(r.X + r.Width, r.Y + r.Height)) ||
                   LineIntersectsLine(p1, p2, new Point(r.X + r.Width, r.Y + r.Height), new Point(r.X, r.Y + r.Height)) ||
                   LineIntersectsLine(p1, p2, new Point(r.X, r.Y + r.Height), new Point(r.X, r.Y)) ||
                   (r.Contains(p1) && r.Contains(p2));
        }

        private bool LineIntersectsLine(Point l1p1, Point l1p2, Point l2p1, Point l2p2)
        {
            float q = (l1p1.Y - l2p1.Y) * (l2p2.X - l2p1.X) - (l1p1.X - l2p1.X) * (l2p2.Y - l2p1.Y);
            float d = (l1p2.X - l1p1.X) * (l2p2.Y - l2p1.Y) - (l1p2.Y - l1p1.Y) * (l2p2.X - l2p1.X);

            if (d == 0)
            {
                return false;
            }

            float r = q / d;

            q = (l1p1.Y - l2p1.Y) * (l1p2.X - l1p1.X) - (l1p1.X - l2p1.X) * (l1p2.Y - l1p1.Y);
            float s = q / d;

            if (r < 0 || r > 1 || s < 0 || s > 1)
            {
                return false;
            }

            return true;
        }


    }
}
