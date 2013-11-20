using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Drived:WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            opponent.Buff = "Drived";
            Person user = (Person)sender;
            user.Heat(opponent);
            string str = user.Identity + user.Name + "击退了" + opponent.Identity + opponent.Name + "," + opponent.Identity + opponent.Name + "被打退了,剩余" + opponent.Life + "点生命";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}
