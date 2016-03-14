using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_4._0.Game
{
    class Shop
    {

        GroupBox GB;
        int CDamage = 30, CFirerate = 50, CBSpeed = 25, CHealth = 15, CSpeed = 75, CRange = 20, CMultiplier = 200;

        public Shop(GroupBox _GB)
        {
            GB = _GB;
        }

        public void Open_Shop()
        {
            World.Instance.Stop = true;
            GB.Enabled = true;
            GB.Visible = true;

            Refresh();
            
        }
        public void Close_Shop(GroupBox GB)
        {
            World.Instance.Stop = false;
            GB.Enabled = false;
            GB.Visible = false;
        }
        public void Buy_Upgrade(string Upgrade)
        {
            switch (Upgrade)
            {
                case "Damage":
                    BuyDamage();
                    break;

                case "Firerate":
                    BuyFirerate();
                    break;

                case "BSpeed":
                    BuyBSpeed();
                    break;

                case "Health":
                    BuyHealth();
                    break;

                case "Speed":
                    BuySpeed();
                    break;

                case "Pickuprange":
                    BuyRange();
                    break;

                case "Multiplier":
                    BuyMultiplier();
                    break;

            }
        }

        private void Refresh()
        {
            GB.Controls["Lb_GoldNum"].Text = World.Instance.Player.Money.ToString();

            GB.Controls["Gb_GunUpgrades"].Controls["Lb_DamageNum"].Text = World.Instance.Gun.Damage.ToString();
            GB.Controls["Gb_GunUpgrades"].Controls["Lb_FirerateNum"].Text = World.Instance.Gun.Firerate.ToString();
            GB.Controls["Gb_GunUpgrades"].Controls["Lb_BSpeedNum"].Text = World.Instance.Gun.Speed.ToString();

            GB.Controls["Gb_GunUpgrades"].Controls["Bt_Damage"].Text = CDamage.ToString();
            GB.Controls["Gb_GunUpgrades"].Controls["Bt_Firerate"].Text = CFirerate.ToString();
            GB.Controls["Gb_GunUpgrades"].Controls["Bt_BSpeed"].Text = CBSpeed.ToString();

            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_HealthNum"].Text = World.Instance.Player.MaxHealth.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_SpeedNum"].Text = World.Instance.Player.MoveSpeed.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_PickUpRangeNum"].Text = World.Instance.Player.HBSize.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_GoldMultiplierNum"].Text = World.Instance.Player.Multiplier.ToString();

            GB.Controls["Gb_PlayerUpgrades"].Controls["Bt_Health"].Text = CHealth.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Bt_Speed"].Text = CSpeed.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Bt_PickUpRange"].Text = CRange.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Bt_GoldMultiplier"].Text = CMultiplier.ToString();
        }

        private void BuyDamage()
        {
            if (World.Instance.Player.Money >= CDamage)
            {
                World.Instance.Player.Money -= CDamage;
                World.Instance.Gun.Damage += 1;
                CDamage += 30;
                Refresh();
            }
        }

        private void BuyFirerate()
        {
            if (World.Instance.Player.Money >= CFirerate)
            {
                World.Instance.Player.Money -= CFirerate;
                World.Instance.Gun.Firerate -= 5;
                CFirerate *= 2;
                Refresh();

                if (World.Instance.Gun.Firerate == 5)
                {
                    GB.Controls["Gb_GunUpgrades"].Controls["Bt_Firerate"].Enabled = false;
                }
            }
        }

        private void BuyBSpeed()
        {
            if (World.Instance.Player.Money >= CBSpeed)
            {
                World.Instance.Player.Money -= CBSpeed;
                World.Instance.Gun.Speed += 1;
                CBSpeed *= 4;
                Refresh();

                if (World.Instance.Gun.Speed == 8)
                {
                    GB.Controls["Gb_GunUpgrades"].Controls["Bt_BSpeed"].Enabled = false;
                }
            }
        }

        private void BuyHealth()
        {
            if (World.Instance.Player.Money >= CHealth)
            {
                World.Instance.Player.Money -= CHealth;
                World.Instance.Player.MaxHealth += 1;
                CHealth += 15;
                Refresh();
            }
        }

        private void BuySpeed()
        {
            if (World.Instance.Player.Money >= CSpeed)
            {
                World.Instance.Player.Money -= CSpeed;
                World.Instance.Player.MoveSpeed += 1;
                CSpeed *= 4;
                Refresh();

                if (World.Instance.Player.MoveSpeed == 6)
                {
                    GB.Controls["Gb_PlayerUpgrades"].Controls["Bt_Speed"].Enabled = false;
                }
            }
        }

        private void BuyRange()
        {
            if (World.Instance.Player.Money >= CRange)
            {
                World.Instance.Player.Money -= CRange;
                World.Instance.Player.HBSize += 20;
                CRange *= 4;
                Refresh();

                if (World.Instance.Player.HBSize == 120)
                {
                    GB.Controls["Gb_PlayerUpgrades"].Controls["Bt_PickUpRange"].Enabled = false;
                }
            }
        }

        private void BuyMultiplier()
        {
            if (World.Instance.Player.Money >= CMultiplier)
            {
                World.Instance.Player.Money -= CMultiplier;
                World.Instance.Player.Multiplier += 1;
                CMultiplier *= 5;
                Refresh();
            }
        }
    }
}
