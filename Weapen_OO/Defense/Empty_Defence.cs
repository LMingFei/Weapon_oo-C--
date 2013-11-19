using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO.Defense
{
    public class Empty_Defence:Shield
    {
        public Empty_Defence()
        {
            this.Shiled_name = "未装备";
            this.Shiled_defense = 0;
        }
    }
}
