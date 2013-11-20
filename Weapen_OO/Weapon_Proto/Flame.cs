using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    public class Flame : WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            Person user = (Person)sender;
            opponent.BuffCount = 2;
            opponent.Buff = "Flame";
            int heart = 50;
            opponent.Life -= heart;
            string str = user.Identity + user.Name + "使用了火焰魔法," + opponent.Identity + opponent.Name + "受到了"+heart+"点火焰灼伤!"+"," + opponent.Name + "剩余" + opponent.Life + "点生命";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}
