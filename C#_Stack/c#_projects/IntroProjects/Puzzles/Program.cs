using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static void RandomArray()
        {
            Random rando = new Random();
            
            List<int> randomList = new List<int>();
            for(int i = 1; i <= 10; i++)
            {
                randomList.Add(rando.Next(5,26));
            }
            int max = randomList[0];
            int min = randomList[0];
            int sum = 0;

            
            Console.Write(String.Join(", ", randomList));
            for(int i = 0; i < randomList.Count; i++)
            {
                if (randomList[i] < min)
                {
                    min = randomList[i];
                }
                if (randomList[i] > max)
                {
                    max = randomList[i];
                }
                sum += randomList[i];
            }
            Console.WriteLine("***************************");
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rando = new Random();
            int toss = rando.Next(2);
            Console.WriteLine(toss);
            if(toss == 0)
            {
                Console.WriteLine("Heads");
                string heads = "Heads";
                return heads;
            }
            else
            {
                Console.WriteLine("Tails");
                string tails = "Tails";
                return tails;
            }
            
        }

        public static double TossMultipleCoins(int num)
        {
            int headCount = 0;
            for(int i = 1; i <= num; i++)
            {
                string x = TossCoin();
                if(x == "Heads")
                {
                    headCount += 1;
                }
            }
            Console.WriteLine("***************");
            Console.WriteLine(headCount);
            double ratio = (double)headCount / (double)num;
            Console.WriteLine(ratio);
            return ratio;

        }

        public static void Names()
        {
            List<string> namez = new List<string>();
            namez.Add("Todd");
            namez.Add("Tiffany");
            namez.Add("Charlie");
            namez.Add("Geneva");
            namez.Add("Sydney");

            List<string> randomList = new List<string>();

            Random r = new Random();
            int randomIndex = 0;
            while (namez.Count > 0)
            {
                randomIndex = r.Next(0, namez.Count); 
                randomList.Add(namez[randomIndex]);
                namez.RemoveAt(randomIndex);
            }
            foreach (string name in randomList)
            {
                Console.WriteLine(name);
            }
            List<string> shortNames = new List<string>();
            foreach (string name in randomList)
            {
                if (name.Length >= 5)
                {
                    shortNames.Add(name);
                }
            }
            Console.WriteLine(String.Join(", ",shortNames));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(5);
            Names();
        }
    }
}
