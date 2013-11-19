using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Arm;
using Weapen_OO.Defense;
using Weapen_OO.Weapon_Proto;
namespace Weapen_OO.Identity
{
    public class Warrior : Person
    {
        Weapon wp = new Medium_Weapon(new Deadly());
        Armor armor = new Armor();
        public override Weapon get_weapon()
        {
            return wp;
        }
        public Warrior(String name)
        {
            Random rm = new Random();
            this.Identity = "战士";
            this.Name = name;
            this.Attack = rm.Next(50, 80) + wp.Weapon_attack;
            this.Life = rm.Next(100, 300);
            this.Defence = armor.Shiled_defense;
            string wp_name = wp.Weapon_name;
            string armor_name = armor.Shiled_name;
        }
        public override void Heat(Person opponent)
        {
            string heart = (this.Attack+wp.Weapon_attack - opponent.Defence).ToString();
            opponent.Life -= Convert.ToInt32(heart);
        }
    }
}
