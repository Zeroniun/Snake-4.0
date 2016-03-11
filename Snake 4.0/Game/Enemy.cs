using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_4._0.Game
{
    public class Enemy
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int KillReward { get; set; }
        public Rectangle Hitbox { get; private set; }
        private int moveSpeed = 2;
        private int MoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }
        Random rnd;
        int Gold;

        public Enemy(Point Location, Random _rnd)
        {
            LocationX = Location.X;
            LocationY = Location.Y;
            UpdateHitbox();
            Health = 2;
            Damage = 3;
            rnd = _rnd;
            Gold = rnd.Next(2, 5);
        }

        public void Move(int X, int Y)
        {
            // Left
            if (LocationX > X - 13)
            {
                LocationX -= moveSpeed;
            }
            
            // Right
            if (LocationX < X + 13)
            {
                LocationX += moveSpeed;
            }
            
            // UP
            if (LocationY > Y - 13)
            {
                LocationY -= moveSpeed;
            }

            // Down
            if (LocationY < Y + 13)
            {
                LocationY += moveSpeed;
            }

            UpdateHitbox();
        }

        public void Draw_Enemy(Graphics g)
        {
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            SizeF StringSize = new SizeF();
            StringSize = g.MeasureString(Health.ToString(), font);
            int SWidth = Convert.ToInt32(StringSize.Width * 0.5);

            g.DrawString(Health.ToString(), font, brush, LocationX - SWidth, LocationY - 10 - StringSize.Height);
            g.FillEllipse(Brushes.Green, LocationX - 10, LocationY - 10, 20, 20);
        }

        public bool DeathCheck(int Damage)
        {
            if (Calculate_Damage(Damage) <= 0)
            {
                return true;
            }
            return false;
        }

        private int Calculate_Damage(int Damage)
        {
            Health -= Damage;
            return Health;
        }

        private void UpdateHitbox()
        {
            Hitbox = new Rectangle(LocationX - 10, LocationY - 10, 20, 20);
        }

        public void DropGold()
        {
            for (int i = 0; i < Gold; i++)
            {
                Point p = new Point(rnd.Next(LocationX - 20, LocationX + 20), rnd.Next(LocationY - 20, LocationY + 20));
                World.Instance.gold.Add(new Gold(p));
            }
        }
    }
}
