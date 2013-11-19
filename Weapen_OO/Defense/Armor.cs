using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Defense
{
    public class ArmorList
    {
        public static Armor[] ArmorArrayList = new Armor[3];
        public Armor[] GetArmorList()
        {
            ArmorArrayList[0] = new IceArmor();
            ArmorArrayList[1] = new KeelArmor();
            ArmorArrayList[2] = new LeatherArmor();
            return ArmorArrayList;
        }
    }

    public class Armor:Shield
    {
        
    }

    public class IceArmor : Armor
    {
        public IceArmor()
        {
            this.Shiled_name = "寒冰甲";
            this.Shiled_defense = 9;
        }
    }

    public class KeelArmor : Armor
    {
        public KeelArmor()
        {
            this.Shiled_name = "龙骨甲";
            this.Shiled_defense = 14;
        }
    }

    public class LeatherArmor : Armor
    {
        public LeatherArmor()
        {
            this.Shiled_name = "皮甲";
            this.Shiled_defense = 3;
        }
    }
}
