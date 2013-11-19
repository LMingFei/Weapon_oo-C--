using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Weapon_Proto;
namespace Weapen_OO.Arm
{
    public class Medium_Weapon:Weapon
    {
        public Medium_Weapon(IWeaponProto weaponproto)
        {
            
            this.Weapon_name = "银质长剑";
            this.Weapon_attack = 9;
        }
    }
}
