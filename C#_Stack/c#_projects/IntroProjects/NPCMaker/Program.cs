using System;
using System.Collections.Generic;

namespace NPCMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //p1.GetStats();

            //Person p2 = new Person("Gutripper", 15, "Bard", "Gnome", 20);
            //p2.GetStats();

            //Person p3 = new Person("Jerry", "Blacksmith");
            //Console.WriteLine(p3.Health);
            // p3.level = 100;
            // p3.GetStats();
            // Console.WriteLine("***************************");

            Elf e1 = new Elf();
            e1.GetStats();
            Console.WriteLine("***************************");

            Elf e2 = new Elf("Buddy", 4, "Santa's janitor", 15, 2);
            e2.GetStats();
            Console.WriteLine("***************************");

            Orc o1 = new Orc();
            o1.GetStats();
        }
    }
}
