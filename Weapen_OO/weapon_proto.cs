using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Weapen_OO.Identity;
using Weapen_OO.Weapon_Proto;



namespace Weapen_OO
{
    class weapon_Proto
    {
        private static Hashtable weapon_pro = new Hashtable();

        public static Hashtable Weapon_pro
        {
            get { return weapon_pro; }
        }

        static weapon_Proto()
        {
            weapon_pro.Add(typeof(Deadly), 1);
            weapon_pro.Add(typeof(Dizziness), 2);
            weapon_pro.Add(typeof(Flame), 3);
            weapon_pro.Add(typeof(Freeze), 4);
            weapon_pro.Add(typeof(Venom), 5);
        }
    }
}
