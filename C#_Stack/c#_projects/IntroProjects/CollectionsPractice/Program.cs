using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbaz = {0,1,2,3,4,5,6,7,8,9};
            foreach (int numba in numbaz)
            {
                Console.WriteLine(numba);
            }

            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            bool[] thangs = {true, false, true, false, true, false, true, false, true, false};
            foreach(bool thang in thangs)
            {
                Console.WriteLine(thang);
            }

            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Neopolitan");
            flavors.Add("Coffee");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
            foreach(string flavor in flavors)
            {
                Console.WriteLine(flavor);
            }

            Random randomnum = new Random();
            Dictionary<string,string> users = new Dictionary<string,string>();
            users.Add(names[0], flavors[randomnum.Next(4)]);
            users.Add(names[1], flavors[randomnum.Next(4)]);
            users.Add(names[2], flavors[randomnum.Next(4)]);
            users.Add(names[3], flavors[randomnum.Next(4)]);
            Console.WriteLine(users);
            foreach(KeyValuePair<string,string> user in users)
            {
                Console.WriteLine(user.Key + " - " + user.Value);
            }
        }
    }
}
