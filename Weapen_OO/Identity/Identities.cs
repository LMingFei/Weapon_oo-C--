using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Weapen_OO.Identity
{
    class Identitys
    {
        private static Hashtable identities = new Hashtable();

        public static Hashtable Identities
        {
            get { return Identitys.identities; }
        }
        static Identitys()
        {
            identities.Add(typeof(Human),0);
            identities.Add(typeof(Warrior), 1);
        }
    }
}
