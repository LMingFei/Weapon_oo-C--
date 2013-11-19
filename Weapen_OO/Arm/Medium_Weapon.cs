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
            this.Weapon_name = "骑士剑";
            this.Weapon_attack = 7;
        }
    }

    public class SilverSword : Medium_Weapon
    {
        public SilverSword()
        {
            this.Weapon_name = "银质长剑";
            this.Weapon_attack = 6;
        }
    }

    public class WindSword : Medium_Weapon
    {
        public WindSword()
        {
            this.Weapon_attack = 14;
            this.Weapon_name = "逐风者的祝福之剑";
        }
    }

    public class ArcaniteReaper:Medium_Weapon
    {
        public ArcaniteReaper()
        {
            this.Weapon_name = "奥金斧";
            this.Weapon_attack = 18;
        }

    }
}
