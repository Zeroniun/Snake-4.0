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

        public void Shoot(Point Aim)
        {
            Bullets.Add(new Bullet(Aim));
        }

        public void RemoveBullet()
        {

        }
    }
}
