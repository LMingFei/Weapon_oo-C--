using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Arm
{
    public class Empty_Weapon:Weapon
    {
        public Empty_Weapon()
        {
            this.Weapon_name = "未装备";
            this.Weapon_attack = 0;
        }
    }
}
