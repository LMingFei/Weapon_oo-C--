using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Arm;
using Weapen_OO.Defense;

namespace Weapen_OO.Identity
{
    public class Assassin:Person
    {
        Short_Weapon[] wp_list = new Short_WeaponList().GetShort_WeaponList();
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
        public Assassin(String name)
        {
            wp = wp_list[rm.Next(0, wp_list.Length)];
            sd = defence_list[rm.Next(0, defence_list.Length)];
            this.Identity = "刺客";
            this.Name = name;
            this.Attack = rm.Next(60, 100) + wp.Weapon_attack;
            this.Life = rm.Next(350, 500);
            this.Defence = sd.Shiled_defense+5;
        }
        public override void Heat(Person opponent)
        {
            string heart = (this.Attack+wp.Weapon_attack - opponent.Defence).ToString();
            opponent.Life -= Convert.ToInt32(heart);
        }
    }
}
