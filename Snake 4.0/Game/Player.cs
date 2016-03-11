using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_4._0.Game
{
    public class Player
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
        public Rectangle PlayerHitbox { get; private set; }
        public Rectangle GoldPickUpHitbox { get; private set; }
        public int HBSize { get; set; }

        private int moveSpeed = 3;
        private int MoveSpeed { get { return moveSpeed;}
                                set { moveSpeed = value; } }

        public Player(Size WorldSize)
        {
            LocationX = WorldSize.Width / 2;
            LocationY = WorldSize.Height / 2;
            Health = 5;
            Money = 0;
            HBSize = 40;

            UpdateHitbox();
        }

        public bool Left, Right, Up, Down;

        public void Move(Size WorldSize)
        {
            if (Left && LocationX > 10)
            {
                LocationX -= moveSpeed;
            }

            if (Right && LocationX < WorldSize.Width - 10)
            {
                LocationX += moveSpeed;
            }

            if (Up && LocationY > 10)
            {
                LocationY -= moveSpeed;
            }

            if (Down && LocationY < WorldSize.Height - 10)
            {
                LocationY += moveSpeed;
            }

            UpdateHitbox();
        }

        public void Draw_Player(Graphics g)
        {
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            SizeF StringSize = new SizeF();
            StringSize = g.MeasureString(Health.ToString(), font);
            int SWidth = Convert.ToInt32(StringSize.Width * 0.5);

            g.DrawString(Health.ToString(), font, brush, LocationX - SWidth, LocationY - 10 - StringSize.Height);
            g.FillEllipse(Brushes.Black, LocationX - 10, LocationY - 10, 20, 20);
        }

        private void UpdateHitbox()
        {
            PlayerHitbox = new Rectangle(LocationX - 15, LocationY - 15, 30, 30);
            GoldPickUpHitbox = new Rectangle(LocationX - HBSize / 2, LocationY - HBSize / 2, HBSize, HBSize);
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

        public bool CheckHitbox(Enemy E)
        {
            if (PlayerHitbox.Contains(E.LocationX, E.LocationY))
            {
                return true;
            }
            return false;
        }

        public bool CheckGoldPickUp(Gold G)
        {
            if (GoldPickUpHitbox.Contains(G.LocationX, G.LocationY))
            {
                return true;
            }
            return false;
        }
    }
}
