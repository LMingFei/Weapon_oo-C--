using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Defense;
using Weapen_OO.Arm;
namespace Weapen_OO.Identity
{
    public class Knight:Person
    {
        Long_Weapon[] wp_list = new Long_WeaponList().GetShort_WeaponList();
        Weapon wp;
        Armor[] defence_list = new ArmorList().GetArmorList();
        Shield sd;
        public override Weapon get_weapon()
        {
            return wp;
        }
        public override Shield get_shield()
        {
            return sd;
        }
        public Knight(String name)
        {
            wp = wp_list[rm.Next(0, wp_list.Length)];
            sd = defence_list[rm.Next(0, defence_list.Length)];
            this.Identity = "骑士";
            this.Name = name;
            this.Attack = rm.Next(50,70 ) + wp.Weapon_attack;
            this.Life = rm.Next(400, 500);
            this.Defence = sd.Shiled_defense+6;
        }
    }
}
