using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Arm;
using Weapen_OO.Defense;

namespace Weapen_OO.Identity
{
    public class Human : Person
    {
        Weapon wp = new Empty_Weapon();
        Shield defence = new Empty_Defence();
        public Human(String name)
        {
            this.Identity = "普通青年";
            Random rm = new Random();
            this.Attack = rm.Next(50, 80);
            this.Life = rm.Next(100, 300);
            this.Name = name;
            this.Defence = defence.Shiled_defense;
        }

        public override Weapon get_weapon()
        {
            return wp;
        }

        public override Shield get_shield()
        {
            return defence;
        }

        public override void Heat(Person opponent)
        {
            int heart = this.Attack - opponent.Defence;
            opponent.Life -= heart;
        }
    }
}
