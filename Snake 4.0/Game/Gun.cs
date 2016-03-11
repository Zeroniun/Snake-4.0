using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_4._0.Game
{
    public class Gun
    {
        public List<Bullet> Bullets = new List<Bullet>();

        public Gun()
        {

        }

        public void Shoot(Point Aim, int X, int Y)
        {
            Random rnd = new Random();
            Aim = new Point(Aim.X + rnd.Next(-20, 20), Aim.Y + rnd.Next(-20, 20));
            Bullets.Add(new Bullet(Aim, X, Y));
        }

        public void RemoveBullet(int i)
        {
            if (Bullets[i].Time >= 50)
                {
                    Bullets.Remove(Bullets[i]);
                }
        }
    }
}
