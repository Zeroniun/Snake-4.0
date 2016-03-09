using Snake_4._0.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            World.Instance.Create_Player(PB_Game.Size);
            World.Instance.Create_Gun();
        }

        private void TM_Update_Tick(object sender, EventArgs e)
        {
            World.Instance.Update(this);
            PB_Game.Refresh();
        }

        private void PB_Game_Paint(object sender, PaintEventArgs e)
        {
            World.Instance.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                World.Instance.Player.Left = true;
            }

            if (e.KeyCode == Keys.D)
            {
                World.Instance.Player.Right = true;
            }

            if (e.KeyCode == Keys.S)
            {
                World.Instance.Player.Down = true;
            }

            if (e.KeyCode == Keys.W)
            {
                World.Instance.Player.Up = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                World.Instance.Player.Left = false;
            }

            if (e.KeyCode == Keys.D)
            {
                World.Instance.Player.Right = false;
            }

            if (e.KeyCode == Keys.S)
            {
                World.Instance.Player.Down = false;
            }

            if (e.KeyCode == Keys.W)
            {
                World.Instance.Player.Up = false;
            }
        }

        private void PB_Game_MouseDown(object sender, MouseEventArgs e)
        {
            World.Instance.ShootClick = true;
        }

        private void PB_Game_MouseUp(object sender, MouseEventArgs e)
        {
            World.Instance.ShootClick = false;
        }
    }
}
