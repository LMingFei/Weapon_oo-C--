using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{

    public class WeaponProto
    {
        public virtual void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {

        }
    }

    public class WeaponProtoList
    {
        public WeaponProto[] protolist = new WeaponProto[6];

        public WeaponProto[] GetAllProtoList()
        {
            protolist[0] = new NormalHeat();
            protolist[1] = new Deadly();
            protolist[2] = new Dizziness();
            protolist[3] = new Flame();
            protolist[4] = new Venom();
            protolist[5] = new Freeze();
            return protolist;
        }

    }
}
