using System;

namespace Human
{
    class Ninja : Human
    {
        public Ninja(string n, int s, int i, int h) : base(n, s, i , 175 , h)
        {
            Name = n;
            Strength = s;
            Intelligence = i;
            Health = h;

        }

        public override int Attack(Human target)
        {
            int damage = 5 * Dexterity;
            target.Health -= damage;
            Console.WriteLine("Dex attack");
            Random rando = new Random();
            if(rando(1,101) <= 20)
            {
                target.health -= 10;
            }
            return target.Health;
        }
    }
}