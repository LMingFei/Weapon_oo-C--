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

        public override void Heat(Person opponent)
        {
            int heart = this.Attack - opponent.Defence;
            opponent.Life -= heart;
        }
    }
}
