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

        private int moveSpeed = 4;
        private int MoveSpeed { get { return moveSpeed;}
                                set { moveSpeed = value; } }

        public Player(Size WorldSize)
        {
            LocationX = WorldSize.Width / 2 - 10;
            LocationY = WorldSize.Height / 2 - 10;
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
        }

        public void Draw_Player(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(Color.Black);
            g.FillEllipse(myBrush, LocationX - 10, LocationY - 10, 20, 20);
        }
    }
}
