﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Dizziness : WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            opponent.Buff="Dizziness";
            opponent.BuffCount = 2;
            Person user = (Person)sender;
            user.Heat(opponent);
            string str = user.Identity + user.Name + "用尽全力砸晕了" + opponent.Identity + opponent.Name +","+ opponent.Identity + opponent.Name + "晕过去了,剩余" + opponent.Life + "点生命";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}
