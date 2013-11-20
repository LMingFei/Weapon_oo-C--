    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Freeze : WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            Person user = (Person)sender;
            opponent.BuffCount = 2;
            opponent.Buff = "Freeze";
            string str = user.Identity + user.Name + "使用了冰冻奥义," + opponent.Identity + opponent.Name + "冻成了冰块... ...";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}
