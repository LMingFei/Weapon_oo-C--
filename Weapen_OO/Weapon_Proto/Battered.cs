using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Weapen_OO.Weapon_Proto
{
    class Battered : WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            Person user = (Person)sender;
            user.Heat(opponent);
            string str = user.Identity + user.Name + "抓住机会,攻击" + opponent.Identity + opponent.Name + ",";
            user.Heat(opponent);
            str += user.Identity + user.Name + "趁机连续攻击" + opponent.Identity + opponent.Name + "," + opponent.Identity + opponent.Name + "剩余" + opponent.Life + "点生命";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}
