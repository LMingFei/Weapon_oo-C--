using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO
{
    public abstract class Person
    {
        private int attack;
        private String name;
        private int life;
        private string identity;
        public abstract Weapon get_weapon();
        public string Identity
        {
            get { return identity; }
            set { identity = value; }
        }
        private int defence = 0;
        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }
        public int Life
        {
            get { return life; }
            set 
            {
                if (value > 0) { life = value; }
                else { life = 0; User.isDead=true;}

            }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract string Heat(Person opponent);
    }
}
