using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_4._0.Game
{
    class World
    {
        private static World instance;
        private Size WorldSize;
        public bool ShootClick { get; set; }

        public Point ShootLocation { get; set; }

        public static World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }
                return instance;
            }
        }
        
        private World()
        {

        }

        public void Update()
        {
            instance.Player.Move(WorldSize);
            if (ShootClick)
            {
                instance.Gun.Shoot(ShootLocation);
            }

        }

        public void Draw(Graphics g)
        {
            Player.Draw_Player(g);
            foreach (Bullet Bullet in Gun.Bullets)
            {
                Bullet.Draw(g, Player.LocationX,Player.LocationY);
            }
        }

        public Player Player { get; private set; }

        public void Create_Player(Size worldSize)
        {
            WorldSize = worldSize;
            Player = new Player(WorldSize);
        }

        public Gun Gun { get; private set; }

        public void Create_Gun()
        {
            Gun = new Gun();
        }
    }
}
