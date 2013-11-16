using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO
{
    public class Human : Person
    {
        
        public Human(String name)
        {
            Random rm = new Random();
            this.Attack = rm.Next(50, 80);
            this.Life = rm.Next(100, 300);
            this.Name = name;
        }


        public override string Heat(Person opponent)
        {
            opponent.Life -= this.Attack;
            string str = this.Name + "攻击了" + opponent.Name + "," + opponent.Name + "受到了" + this.Attack + "点伤害," + opponent.Name + "剩余生命:" + opponent.Life;
            if (opponent.Life == 0) 
            {
                str += "\r\n" + this.Name + "赢了";
            }
            return str;
        }
    }

    public class Warrior:Person
    {
        public Warrior(String name)
        {
            this.Name = name;
        }
        public override string Heat(Person opponent)
        {
            opponent.Life -= this.Attack;
            string str = this.Name + "攻击了" + opponent.Name + "," + opponent.Name + "受到了" + this.Attack + "点伤害," + opponent.Name + "剩余生命:" + opponent.Life;
            if (opponent.Life == 0)
            {
                str += "\r\n" + this.Name + "赢了";
            }
            return str;   
        }
    }
}
