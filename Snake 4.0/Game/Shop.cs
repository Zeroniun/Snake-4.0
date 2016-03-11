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
        public void Open_Shop(GroupBox GB)
        {
            World.Instance.Stop = true;
            GB.Enabled = true;
            GB.Visible = true;

            GB.Controls["Lb_GoldNum"].Text = World.Instance.Player.Money.ToString();

            GB.Controls["Gb_GunUpgrades"].Controls["Lb_DamageNum"].Text = World.Instance.Gun.Damage.ToString();
            GB.Controls["Gb_GunUpgrades"].Controls["Lb_FirerateNum"].Text = World.Instance.Gun.Firerate.ToString();
            GB.Controls["Gb_GunUpgrades"].Controls["Lb_BSpeedNum"].Text = World.Instance.Gun.Speed.ToString();

            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_HealthNum"].Text = World.Instance.Player.Health.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_SpeedNum"].Text = World.Instance.Player.MoveSpeed.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_PickUpRangeNum"].Text = World.Instance.Player.HBSize.ToString();
            GB.Controls["Gb_PlayerUpgrades"].Controls["Lb_GoldMultiplierNum"].Text = World.Instance.Player.Multiplier.ToString();
        }
        public void Close_Shop(GroupBox GB)
        {
            World.Instance.Stop = false;
            GB.Enabled = false;
            GB.Visible = false;
        }
        public void Buy_Upgrade()
        {

        }
    }
}
