using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Countered : WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            Person user = (Person)sender;
            opponent.Heat(user);
            string str = user.Identity + user.Name + "攻击被" + opponent.Identity + opponent.Name + "看透了," + opponent.Identity + opponent.Name + "趁机反戈一击！" + user.Name + "剩余" + user.Life + "点生命";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}
