using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Arm;
using Weapen_OO.Defense;
using Weapen_OO.Weapon_Proto;
using System.Collections;
namespace Weapen_OO.Identity
{
    public class Warrior : Person
    {
        Medium_Weapon[] wp_list = new Medium_WeaponList().GetMedium_WeaponList();
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
        public Warrior(String name)
        {
            wp = wp_list[rm.Next(0, wp_list.Length)];
            sd = defence_list[rm.Next(0, defence_list.Length)];
            this.Identity = "战士";
            this.Name = name;
            this.Attack = rm.Next(50, 80) + wp.Weapon_attack;
            this.Life = rm.Next(100, 300);
            this.Defence = sd.Shiled_defense;

        }
        public override void Heat(Person opponent)
        {
            string heart = (this.Attack+wp.Weapon_attack - opponent.Defence).ToString();
            opponent.Life -= Convert.ToInt32(heart);
        }
    }
}
