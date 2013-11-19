using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Deadly : IWeaponProto
    {
        public void stunt(Object sender,Person.WeaponProtoEventArgs e, Person opponent)
        {
            Person user = (Person)sender;
            int heart = (user.Attack+user.get_weapon().Weapon_attack - opponent.Defence)*3;
            opponent.Life -= heart;
        }
    }
}