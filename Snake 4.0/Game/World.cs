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
        int time = 0;
        int LastShot = 0;
        Random rnd = new Random();
        public bool Stop = false;

        int iframes = 200;
        public int Iframes { get { return iframes; } set { iframes = value; } }

        List<Enemy> Enemies = new List<Enemy>();
        public List<Gold> gold = new List<Gold>();

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
            if(Stop == false)
            {
                MoveAllEnemies();
                instance.Player.Move(WorldSize);
                Shooting_Check(form);
                EnemySpawning();
                CheckBullCollisions();
                CheckEnemyPlayerCollisions();
                PickUpGold();

                time++;
                LastShot++;
                Iframes++;
            }

        }

        private void Shooting_Check(Form1 form)
        {
            if (ShootClick && LastShot >= Gun.Firerate)
            {
                Instance.ShootLocation = form.PointToClient(Cursor.Position);
                instance.Gun.Shoot(ShootLocation, Player.LocationX, Player.LocationY);
                LastShot = 0;
            }
        }

        public void Draw(Graphics g)
        {
            DrawAllBullets(g);
            Player.Draw_Player(g);
            DrawAllEnemies(g);
            DrawAllGold(g);
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

        public Shop Shop { get; private set; }
        public void Create_Shop()
        {
            Shop = new Shop();
        }

        private Point RandomEnemyLocation()
        {

            int R = rnd.Next(1, 101);

            // Left
            if (R <= 25)
            {
                return new Point(-10, rnd.Next(0, WorldSize.Height)); 
            }

            // Right
            else if (R <= 50)
            {
                return new Point(WorldSize.Width + 10, rnd.Next(0, WorldSize.Height));
            }

            // Top
            else if (R <= 75)
            {
                return new Point(rnd.Next(0, WorldSize.Width), -10);
            }

            // Bottem
            else
            {
                return new Point(rnd.Next(0, WorldSize.Width), WorldSize.Height + 10);
            }
            
        }

        private void MoveAllEnemies()
        {
            if (Enemies.Count != 0)
            {
                foreach (Enemy Enemy in Enemies)
                {
                    Enemy.Move(Player.LocationX, Player.LocationY);
                }
            }
        }

        private void DrawAllBullets(Graphics g)
        {
            for (int i = 0; i < instance.Gun.Bullets.Count; i++)
            {
                instance.Gun.Bullets[i].Draw(g);
                instance.Gun.RemoveBullet(i);
            }
        }

        private void DrawAllEnemies(Graphics g)
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                Enemies[i].Draw_Enemy(g);
            }
        }

        private void EnemySpawning()
        {
            if (time >= 100)
            {
                Enemies.Add(new Enemy(RandomEnemyLocation(),rnd));
                time = 0;
            }

        }

        private void CheckBullCollisions()
        {
            for (int i = 0; i < Instance.Gun.Bullets.Count; i++)
            {
                if (Instance.Gun.Bullets[i].BullCollision(instance.Enemies))
                {
                    instance.Gun.Bullets.Remove(instance.Gun.Bullets[i]);
                }
            }
        }

        private void CheckEnemyPlayerCollisions()
        { if (Iframes >= 50)
            {
                for (int i = 0; i < Enemies.Count; i++)
                {
                    if (Player.CheckHitbox(Enemies[i]))
                    {
                        Iframes = 0;

                        if (Player.DeathCheck(Enemies[i].Damage))
                        {
                            Stop = true;
                            MessageBox.Show("Game Over");
                            break;
                        }
                        
                    }

                }
            }
        }

        private void PickUpGold()
        {
            for(int i = 0; i < gold.Count; i++)
            {
                if (Player.CheckGoldPickUp(gold[i]))
                {
                    Player.Money++;
                    gold.Remove(gold[i]);
                }
            }
        }

        private void DrawAllGold(Graphics g)
        {
            foreach(Gold G in gold)
            {
                G.Draw(g);
            }
        }
    }
}
