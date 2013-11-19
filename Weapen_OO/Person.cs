using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapen_OO
{
    public abstract class Person
    {
        //人物基本属性
        private int attack;
        private string name;
        private int life;
        private string identity;
        private int defence = 0;



        public string Identity
        {
            get { return identity; }
            set { identity = value; }
        }
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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Buff;




        public abstract Weapon get_weapon();


        public delegate void WeaponProtoEventHandler(Object sender, WeaponProtoEventArgs e,Person opponent);
        public event WeaponProtoEventHandler Stunt;


        public class WeaponProtoEventArgs : EventArgs {
            public Person opponent;
            public Person user;
            public WeaponProtoEventArgs(Person opponent) {
               this.opponent = opponent;
           }
       }

        protected virtual void OnStunt(WeaponProtoEventArgs e,Person opponent)
        {
            if (Stunt != null)
            {
                Stunt(this, e,opponent);
            }
        }
        public void HeatStunt(Person opponent) 
        {
            WeaponProtoEventArgs e = new WeaponProtoEventArgs(opponent);
            OnStunt(e, opponent);
        }

        public abstract void Heat(Person opponent);
    }
}
