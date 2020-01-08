using System;

namespace Human
{
    class Wizard : Human
    {
        public Wizard(string n, int s, int d) : base(n, s, 25, d, 100)
        {
            Name = n;
            Strength = s;
            Dexterity = d;
        }

        public override int Attack(Human target)
        {
            int damage = 5 * Intelligence;
            target.Health -= damage;
            Console.WriteLine("h1 intelligence attack h2");
            Health += damage;
            return target.Health;
        }

        // public override int magicAttack(Human target)
        // {
        //     base.magicAttack();
        // }
    }
}
