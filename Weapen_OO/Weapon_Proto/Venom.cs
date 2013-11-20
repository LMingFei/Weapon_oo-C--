using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Venom : WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            opponent.Buff = "Venom";
            opponent.BuffCount = 3;
            int heart = 40;
            opponent.Life -= heart;
            Person user = (Person)sender;
            string str = user.Identity + user.Name + "给对手下毒," + opponent.Identity + opponent.Name + "脸都紫了,受到" + heart+"点毒液伤害";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}
