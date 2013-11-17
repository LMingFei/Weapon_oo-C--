using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Arm;

namespace Weapen_OO.Identity
{
    public class Human : Person
    {
        
        public Human(String name)
        {
            this.Identity = "普通青年";
            Random rm = new Random();
            this.Attack = rm.Next(50, 80);
            this.Life = rm.Next(100, 300);
            this.Name = name;
        }

        public override Weapon get_weapon()
        {
            return null;
        }

        public override string Heat(Person opponent)
        {
            opponent.Life -= this.Attack;
            string str = this.Identity+this.Name + "攻击了" + opponent.Name + "," + opponent.Name + "受到了" + this.Attack + "点伤害," + opponent.Name + "剩余生命:" + opponent.Life;
            if (opponent.Life == 0) 
            {
                str += "\r\n" + opponent.Name + "被打败了";
            }
            return str;
        }
    }
}
