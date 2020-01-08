using System;

namespace NPCMaker
{
    public abstract class Person
    {
        public string name;
        public int level;
        public string job;
        public string race;
        protected int health;
        public int Health
        {
            get { return health; }
        }

        public Person()
        {
            name = "NPC";
            level = 20;
            job = "Tailor";
            race = "Orc";
            health = 100;
        }
        public Person(string n, int l, string j, string r, int h)
        {
            name = n;
            level = l;
            job = j;
            race = r;
            health = h;
        }

        public Person(string n, string j)
        {
            name = n;
            level = 30;
            job = j;
            race = "Human";
            health = 120;
        }

        public virtual void GetStats()
        {
            Console.WriteLine($"Name:   {name}");
            Console.WriteLine($"Level:  {level}");
            Console.WriteLine($"Job:    {job}");
            Console.WriteLine($"Race:   {race}");
            Console.WriteLine($"Health: {health}");
        }
    }
}