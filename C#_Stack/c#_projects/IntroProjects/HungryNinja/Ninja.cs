using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;


        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull()
        {
            if (calorieIntake > 1200)
            {
                return true;
            }
            return false;
        }

        public void Eat(Food item)
        {
            if (!IsFull())
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine(item.Name);
                if(item.IsSpicy == true)
                {
                    Console.WriteLine("This is spicy");
                }
                if(item.IsSweet == true)
                {
                    Console.WriteLine("This is sweet");
                }
            }
            else{
                Console.WriteLine("You are full!");
            }
        }
    }
}