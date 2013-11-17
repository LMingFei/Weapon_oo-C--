using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO
{
     public abstract class Weapon
    {
        private string weapon_name;

        public string Weapon_name
        {
            get { return weapon_name; }
            set { weapon_name = value; }
        }


        private int weapon_attack;

        public int Weapon_attack
        {
            get { return weapon_attack; }
            set { weapon_attack = value; }
        }
    }
}
