using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    public interface IWeaponProto
    {
        void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent);
    }
}
