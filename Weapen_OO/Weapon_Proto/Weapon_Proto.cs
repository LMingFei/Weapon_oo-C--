using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Weapen_OO.Identity;

namespace Weapen_OO
{
    class Weapon_Proto
    {
        private static Hashtable weapon_pro = new Hashtable();

        public static Hashtable Weapon_pro
        {
            get { return Weapon_Proto.weapon_pro; }
        }

        static Weapon_Proto()
        {
            weapon_pro.Add(typeof(Human),0);
            weapon_pro.Add(typeof(Warrior), 1);
        }
    }
}
