﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_4._0.Game
{
    public class Gold
    {
        public int LocationX { get; private set; }
        public int LocationY { get; private set; }

        public Gold(Point P)
        {
            LocationX = P.X;
            LocationY = P.Y;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Gold, LocationX - 4, LocationY - 4, 8, 8);
            g.DrawEllipse(Pens.Black, LocationX - 4, LocationY - 4, 8, 8);
        }


    }
}
