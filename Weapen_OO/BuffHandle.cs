using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Weapon_Proto;
using System.Threading;
namespace Weapen_OO
{
    static class BuffHandle
    {
        public static void IsBuff(Person user,Person opponent)
        {
            int heart;
            string str;
            switch (user.Buff)
            {
                case "Dizziness":
                    user.BuffCount--;
                    str = user.Name + "眩晕了," + RemainCount(user);
                    PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
                    break;
                case "Flame":
                    user.BuffCount--;
                    heart = 50;
                    opponent.Life -= heart;
                    str = user.Name + "受到"+heart+"点火焰灼伤," + RemainCount(user);
                    PanelArray.panel_array[0].Controls[0].Text = str + "...\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
                    if (!User.isDead)
                    {
                        user.Stunt += user.get_weapon().protolist[random_num.rm.Next(0, user.get_weapon().protolist.Length)].stunt;
                        user.HeatStunt(opponent);
                    }
                    else
                    {
                        PanelArray.panel_array[0].Controls[0].Text = user.Name + "被打败了" + "\r\n\r\n" + PanelArray.panel_array[0].Controls[0].Text;
                        User.timer1.Stop();
                        User.timer2.Stop();
                    }
                    break;
                case "Freeze":
                    user.BuffCount--;
                    str = user.Name + "被冻住了," + RemainCount(user);
                    PanelArray.panel_array[0].Controls[0].Text = str + "\r\n"+ "\r\n" + PanelArray.panel_array[0].Controls[0].Text ;
                    break;
                case "Venom":
                    user.BuffCount--;
                    heart = 40;
                    opponent.Life -= heart;
                    str = user.Name + "受到"+heart+"点毒液伤害," + RemainCount(user);
                    PanelArray.panel_array[0].Controls[0].Text = str + "..." + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
                    if (!User.isDead)
                    {
                        user.Stunt += user.get_weapon().protolist[random_num.rm.Next(0, user.get_weapon().protolist.Length)].stunt;
                        user.HeatStunt(opponent);
                    }
                    else
                    {
                        PanelArray.panel_array[0].Controls[0].Text += user.Name + "被打败了" + "\r\n\r\n" + PanelArray.panel_array[0].Controls[0].Text;
                        User.timer1.Stop();
                        User.timer2.Stop();
                    }
                    break;
                case "Drived":
                    user.Buff = "";
                    str = user.Name + "向前靠近了一步,下次就可以攻击" + opponent.Name+"了";
                    PanelArray.panel_array[0].Controls[0].Text = str + "\r\n" + "\r\n" + PanelArray.panel_array[0].Controls[0].Text;
                    break;
                default:
                    user.Stunt += user.get_weapon().protolist[random_num.rm.Next(0, user.get_weapon().protolist.Length)].stunt;
                    user.HeatStunt(opponent);
                    break;
            }
        }


        private static string RemainCount(Person person)
        {
            switch (person.BuffCount)
            {
                case 3: return "剩余3回合";
                case 2: return "剩余2回合";
                case 1: return "剩余1回合";
                case 0:
                    person.Buff = "";
                    return person.Name+"身体恢复了！";
                default: return "纳尼？出错了？";
            }
        }
    }
}
