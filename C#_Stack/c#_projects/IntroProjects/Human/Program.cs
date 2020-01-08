using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human h1 = new Human("Araz");
            Console.WriteLine(h1.Name);

            Human h2 = new Human("John");

            // Console.WriteLine(h2.Attack(h1));
            // Console.WriteLine(h1.health);

            Wizard w1 = new Wizard("Ava", 25, 25);
            w1.Attack(h1);
            Console.WriteLine(h1.health);
            Console.WriteLine(w1.Health);
        }
    }
}
