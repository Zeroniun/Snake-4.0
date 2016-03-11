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
