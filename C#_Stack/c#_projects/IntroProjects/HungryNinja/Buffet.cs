using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Tacos", 100, true, false),
                new Food("Burrito", 500, true, false),
                new Food("Chocolate Lave Cake", 827, false, true),
                new Food("Paper", 0, false, false),
                new Food("Couch Cushion", 1, false, false),
                new Food("Tic Tac", 2, false, true),
                new Food("Humans", 468, false, false)


            };
        }
        public Food Serve()
        {
            Random rando = new Random();
            Console.WriteLine("We are in serve");
            return Menu[rando.Next(7)];
        }
    }
}
