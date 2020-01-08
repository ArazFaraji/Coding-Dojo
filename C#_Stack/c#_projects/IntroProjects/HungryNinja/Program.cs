using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ninja Araz = new Ninja();

            Buffet lotsOfFood = new Buffet();

            while (!Araz.IsFull())
            {
               Araz.Eat(lotsOfFood.Serve()); 
            }
            


        }
    }
}
