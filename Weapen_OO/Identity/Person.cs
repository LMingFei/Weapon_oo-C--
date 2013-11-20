using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapen_OO.Arm;
using Weapen_OO.Defense;
using Weapen_OO.Identity;
namespace Weapen_OO
{
    public class PersonList
    {
        public static Person[] PersonArrayList = new Person[5];
        public Person[] GetPersonArrayList(string name)
        {
            PersonArrayList[0] = new Human(name);
            PersonArrayList[1] = new Warrior(name);
            PersonArrayList[2] = new Assassin(name);
            PersonArrayList[3] = new Knight(name);
            PersonArrayList[4] = new Human(name);
            return PersonArrayList;
        }
    }





    public class Person
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

        public int BuffCount;




        public virtual Weapon get_weapon() { return new Empty_Weapon(); }

        public virtual Shield get_shield() { return new Empty_Defence(); }

        public delegate void WeaponProtoEventHandler(Object sender, WeaponProtoEventArgs e,Person opponent);
        private List<WeaponProtoEventHandler> CurrentWeaproto=new List<WeaponProtoEventHandler>();
        private event WeaponProtoEventHandler stunt;
        public event WeaponProtoEventHandler Stunt
        {
            add
            {
                ClearEvent();
                stunt += value;
                CurrentWeaproto.Add(value);
            }

            remove
            {
                stunt -= value;
            }
        }

        private void ClearEvent()
        {
            if (CurrentWeaproto != null)
            {
                for (int i = 0; i < this.CurrentWeaproto.Count; i++)
                {
                    stunt -= this.CurrentWeaproto[i];
                }
            }
        }


        public class WeaponProtoEventArgs : EventArgs {
            public Person opponent;
            public WeaponProtoEventArgs(Person opponent) {
               this.opponent = opponent;
           }
       }

        protected virtual void OnStunt(WeaponProtoEventArgs e,Person opponent)
        {
            if (stunt != null)
            {
                stunt(this,e,opponent);
            }
        }

        public void HeatStunt(Person opponent) 
        {
            WeaponProtoEventArgs e = new WeaponProtoEventArgs(opponent);
            OnStunt(e, opponent);
        }
        public virtual void Heat(Person opponent)
        {
            opponent.Life -= this.Attack - opponent.Defence;
        }

        protected Random rm = new Random();
    }






}
