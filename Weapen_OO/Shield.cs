using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO
{
    public abstract class Shield
    {
        string shiled_name;

        public string Shiled_name
        {
            get { return shiled_name; }
            set { shiled_name = value; }
        }
        int shiled_defense;

        public int Shiled_defense
        {
            get { return shiled_defense; }
            set { shiled_defense = value; }
        }
    }
}
