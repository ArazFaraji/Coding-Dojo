using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int Health;

        public int health 
        {
            get { return Health; }
        }
        public Human(string n)
        {
            Name = n;
            Strength = 1;
            Intelligence = 1;
            Dexterity = 1;
            Health = 20;


        }
        public Human(string n, int s, int i, int d, int h)
        {
            Name = n;
            Strength = s;
            Intelligence = i;
            Dexterity = d;
            Health = h;
        }

        public virtual int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.Health -= damage;
            return target.Health;

        }

        // protected virtual int magicAttack(Human target)
        // {
        //     int damage = 5 * Intelligence;
        //     target.Health -= damage;
        //     return target.Health;
        // }
    } 
}
    