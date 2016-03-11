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
        public int Firerate { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }

        public Gun()
        {
            Firerate = 30;
            Damage = 1;
            Speed = 4;
        }

        public void Shoot(Point Aim, int X, int Y)
        {
            Random rnd = new Random();
            Aim = new Point(Aim.X + rnd.Next(-30, 30), Aim.Y + rnd.Next(-30, 30));
            Bullets.Add(new Bullet(Aim, X, Y, Damage, Speed));
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
