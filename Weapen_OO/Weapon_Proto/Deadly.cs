﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Weapon_Proto
{
    class Deadly : WeaponProto
    {
        public override void stunt(Object sender, Person.WeaponProtoEventArgs e, Person opponent)
        {
            Person user = (Person)sender;
            int heart = (user.Attack+user.get_weapon().Weapon_attack - opponent.Defence)*3;
            opponent.Life -= heart;
            string str = user.Identity + user.Name + "发动了致命一击," + opponent.Identity + opponent.Name + "受到了"+heart+"点伤害," + opponent.Name + "剩余" + opponent.Life + "点生命";
            PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
        }
    }
}