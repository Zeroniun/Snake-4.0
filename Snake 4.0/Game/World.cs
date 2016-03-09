using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_4._0.Game
{
    class World
    {
        private static World instance;
        private Size WorldSize;
        int time = 10;
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

        public void Update(Form1 form)
        {
            
            instance.Player.Move(WorldSize);
            if (ShootClick && time >= 50)
            {
                World.Instance.ShootLocation = form.PointToClient(Cursor.Position);
                instance.Gun.Shoot(ShootLocation);
                time = 0;
            }
            time++;

        }

        public void Draw(Graphics g)
        {
            
            for (int i = 0; i < instance.Gun.Bullets.Count; i++)
            {
                instance.Gun.Bullets[i].Draw(g, Player.LocationX, Player.LocationY);
                instance.Gun.RemoveBullet(i);
            }
            Player.Draw_Player(g);
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
