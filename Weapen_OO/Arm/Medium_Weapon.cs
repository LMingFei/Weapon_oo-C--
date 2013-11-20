using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Weapon_Proto;
using System.Collections;
namespace Weapen_OO.Arm
{
    public class Medium_WeaponList
    {
        public static Medium_Weapon[] Medium_Weapon_ArrayList = new Medium_Weapon[4];
        public Medium_Weapon[] GetMedium_WeaponList()
        {
            Medium_Weapon_ArrayList[0] = new KnightSword();
            Medium_Weapon_ArrayList[1] = new SilverSword();
            Medium_Weapon_ArrayList[2] = new WindSword();
            Medium_Weapon_ArrayList[3] = new ArcaniteReaper();
            return Medium_Weapon_ArrayList;
        }
    }

    public class Medium_Weapon:Weapon
    {

    }


    public class KnightSword : Medium_Weapon
    {

        public KnightSword()
        {
            this.Weapon_name = "骑士剑(寒冰)";
            this.Weapon_attack = 7;
            protolist = new WeaponProto[7];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new NormalHeat();
            protolist[5] = new Freeze();
            protolist[6] = new Countered();
        }
    }

    public class SilverSword : Medium_Weapon
    {
        public SilverSword()
        {
            this.Weapon_name = "毒剑";
            this.Weapon_attack = 6;
            protolist = new WeaponProto[6];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new Venom();
            protolist[5] = new Countered();
        }
    }

    public class WindSword : Medium_Weapon
    {
        public WindSword()
        {
            this.Weapon_attack = 14;
            this.Weapon_name = "逐风者的祝福之剑";
            protolist = new WeaponProto[8];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new NormalHeat();
            protolist[5] = new Flame();
            protolist[6] = new Freeze();
            protolist[7] = new Countered();
        }
    }

    public class ArcaniteReaper:Medium_Weapon
    {
        public ArcaniteReaper()
        {
            this.Weapon_name = "奥金斧";
            this.Weapon_attack = 18;
            protolist = new WeaponProto[8];
            protolist[0] = new NormalHeat();
            protolist[1] = new NormalHeat();
            protolist[2] = new NormalHeat();
            protolist[3] = new NormalHeat();
            protolist[4] = new NormalHeat();
            protolist[5] = new Dizziness();
            protolist[6] = new Deadly();
            protolist[7] = new Countered();
        }

    }
}
