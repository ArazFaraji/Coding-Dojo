using System;

namespace NPCMaker
{
    public class Elf : Person, IUseMagic
    {
        public int mana {get;set;}
        public Elf() : base("NPE", 32, "Santa's Helper", "Elf", 80)
        {
            mana = 50;
        }

        public Elf(string n, int l, string j, int h, int m) : base (n, l, j, "Elf", h)
        {
            name = n;
            level = l;
            job = j;
            health = h;
            mana = m;
        }

        public void useMana()
        {
            Console.WriteLine($"{name} used mana");
        }

        public override void GetStats()
        {
            base.GetStats();
            Console.WriteLine($"Mana:   {mana}");
        }
    }
}