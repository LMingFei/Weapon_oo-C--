using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Venom : IWeaponProto
    {
        public void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            opponent.Buff = "Venom";
        }
    }
}
