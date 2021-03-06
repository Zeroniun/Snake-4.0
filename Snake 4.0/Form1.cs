﻿using Snake_4._0.Game;
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
            CreateAll();
        }

        private void TM_Update_Tick(object sender, EventArgs e)
        {
            World.Instance.Update(this);
            PB_Game.Refresh();
        }

        private void PB_Game_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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

            if (e.KeyCode == Keys.Space)
            {
                World.Instance.Shop.Open_Shop();
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

        private void CreateAll()
        {
            World.Instance.Create_Player(PB_Game.Size);
            World.Instance.Create_Gun();
            World.Instance.Create_Shop(this.Gb_Shop);
        }

        private void Bt_CloseShop_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Close_Shop(this.Gb_Shop);
        }

        private void Bt_Damage_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Buy_Upgrade("Damage");
        }

        private void Bt_BSpeed_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Buy_Upgrade("BSpeed");
        }

        private void Bt_Firerate_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Buy_Upgrade("Firerate");
        }

        private void Bt_Health_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Buy_Upgrade("Health");
        }

        private void Bt_Speed_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Buy_Upgrade("Speed");
        }

        private void Bt_PickUpRange_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Buy_Upgrade("Pickuprange");
        }

        private void Bt_GoldMultiplier_Click(object sender, EventArgs e)
        {
            World.Instance.Shop.Buy_Upgrade("Multiplier");
        }
    }
}
