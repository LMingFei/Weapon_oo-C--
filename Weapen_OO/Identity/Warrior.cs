using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Arm;
namespace Weapen_OO.Identity
{
    public class Warrior : Person
    {
        Weapon wp = new Medium_Weapon();
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
            string wp_name = wp.Weapon_name;
        }
        public override string Heat(Person opponent)
        {
            string heart = (this.Attack+wp.Weapon_attack - opponent.Defence).ToString();
            opponent.Life -= Convert.ToInt32(heart);
            string str = this.Identity + this.Name + "使用" + wp.Weapon_name + "攻击了" + opponent.Name + "," + opponent.Name + "受到了" + heart + "点伤害," + opponent.Name + "剩余生命:" + opponent.Life;
            if (opponent.Life == 0)
            {
                str += "\r\n" + opponent.Name + "被打败了";
            }
            return str;
        }
    }
}
