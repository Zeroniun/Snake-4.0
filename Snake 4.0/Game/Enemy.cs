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

        private int moveSpeed = 1;
        private int MoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }

        public Enemy(Point Location)
        {
            LocationX = Location.X;
            LocationY = Location.Y;
        }

        public void Move(int X, int Y)
        {
            // Left
            if (LocationX > X)
            {
                LocationX -= moveSpeed;
            }
            
            // Right
            if (LocationX < X)
            {
                LocationX += moveSpeed;
            }
            
            // UP
            if (LocationY > Y)
            {
                LocationY -= moveSpeed;
            }

            // Down
            if (LocationY < Y)
            {
                LocationY += moveSpeed;
            }
        }

        public void Draw_Enemy(Graphics g)
        {
            g.FillEllipse(Brushes.Green, LocationX - 10, LocationY - 10, 20, 20);
        }
    }
}
