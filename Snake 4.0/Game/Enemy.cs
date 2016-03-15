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
        public string Type { get; set; }
        public Rectangle Hitbox { get; private set; }
        private int moveSpeed = 3;
        int Gold;

        public Enemy(Point Location, string type)
        {
            LocationX = Location.X;
            LocationY = Location.Y;
            UpdateHitbox();
            Health = 2;
            Damage = 3;
            Gold = World.rnd.Next(2, 5);
            Type = type;

            if (type == "Medic")
            {
                Health = 5;
                Damage = -10;
                moveSpeed = 2;
                Gold = 0;
            }
        }

        public void Move(int X, int Y)
        {

            float DeltaX = X - LocationX;
            float DeltaY = Y - LocationY;
            float length = (float)Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY);
            if (length > moveSpeed)
            {
                LocationX += (int)(moveSpeed * DeltaX / length);
                LocationY += (int)(moveSpeed * DeltaY / length);
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

            if (Type == "Medic")
            {
                g.FillEllipse(Brushes.White, LocationX - 10, LocationY - 10, 20, 20);
                g.DrawLine(new Pen(Color.Red, 5), LocationX - 10, LocationY, LocationX + 10, LocationY);
                g.DrawLine(new Pen(Color.Red, 5), LocationX, LocationY - 10, LocationX, LocationY + 10);
            }
            else
            {
                g.FillEllipse(Brushes.Green, LocationX - 10, LocationY - 10, 20, 20);
            }

            g.DrawString(Health.ToString(), font, brush, LocationX - SWidth, LocationY - 10 - StringSize.Height);
        }

        public bool DamageCheck(int Damage)
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
                Point p = new Point(World.rnd.Next(LocationX - 20, LocationX + 20), World.rnd.Next(LocationY - 20, LocationY + 20));
                World.Instance.gold.Add(new Gold(p));
            }
        }
    }
}
