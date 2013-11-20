using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Weapon_Proto;
namespace Weapen_OO.Arm
{
    public class Long_WeaponList
    {
        public static Long_Weapon[] Long_WeaponArrayList = new Long_Weapon[3];

        public Long_Weapon[] GetShort_WeaponList()
        {
            Long_WeaponArrayList[0] = new IceSpear();
            Long_WeaponArrayList[1] = new PoseidonTrident();
            Long_WeaponArrayList[2] = new HolySpear();
            return Long_WeaponArrayList;
        }
    }
    public class Long_Weapon : Weapon
    {

    }

    public class IceSpear : Long_Weapon
    {
        public IceSpear()
        {
            this.Weapon_name = "冰刺长矛";
            this.Weapon_attack = 15;
            protolist = new WeaponProto[6];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new Freeze();
            protolist[5] = new Drived();

        }
    }

    public class HolySpear : Long_Weapon
    {
        public HolySpear()
        {
            this.Weapon_name = "圣光战矛";
            this.Weapon_attack = 14;
            protolist = new WeaponProto[6];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new Dizziness();
            protolist[5] = new Drived();
        }
    }

    public class PoseidonTrident : Long_Weapon
    {
        public PoseidonTrident()
        {
            this.Weapon_attack = 16;
            this.Weapon_name = "海神三叉戟";
            protolist = new WeaponProto[8];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new NormalHeat();
            protolist[5] = new Freeze();
            protolist[6] = new Deadly();
            protolist[7] = new Drived();
        }

    }

}
