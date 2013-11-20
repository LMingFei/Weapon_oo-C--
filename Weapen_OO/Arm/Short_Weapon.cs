using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Weapon_Proto;
namespace Weapen_OO.Arm
{
    public class Short_WeaponList
    {
        public static Short_Weapon[] Short_WeaponArrayList = new Short_Weapon[3];

        public Short_Weapon[] GetShort_WeaponList()
        {
            Short_WeaponArrayList[0]=new HeartBroken();
            Short_WeaponArrayList[1] = new MoltenCanines();
            Short_WeaponArrayList[2] = new DevilsAttack();
            return Short_WeaponArrayList;
        }
    }

    public class Short_Weapon:Weapon
    {

    }


    public class HeartBroken : Short_Weapon
    {
        public HeartBroken()
        {
            this.Weapon_name = "断肠";
            this.Weapon_attack = 11;
            protolist = new WeaponProto[8];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new NormalHeat();
            protolist[5] = new Freeze();
            protolist[6] = new Deadly();
            protolist[7] = new Battered();
        }
    }

    public class MoltenCanines : Short_Weapon
    {
        public MoltenCanines()
        {
            this.Weapon_attack = 15;
            this.Weapon_name = "熔火犬牙";
            protolist = new WeaponProto[8];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new NormalHeat();
            protolist[5] = new Flame();
            protolist[6] = new Deadly();
            protolist[7] = new Battered();
        }

    }

    public class DevilsAttack : Short_Weapon
    {
        public DevilsAttack()
        {
            this.Weapon_name = "恶魔之击";
            this.Weapon_attack = 19;
            protolist = new WeaponProto[9];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new NormalHeat();
            protolist[5] = new NormalHeat();
            protolist[6] = new Venom();
            protolist[7] = new Deadly();
            protolist[8] = new Battered();
        }
    }
}
