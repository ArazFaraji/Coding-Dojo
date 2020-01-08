using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> thangs = new List<object>();
            thangs.Add(7);
            thangs.Add(28);
            thangs.Add(-1);
            thangs.Add(true);
            thangs.Add("chair");

            int sum = 0;

            foreach (object thang in thangs)
            {
                if (thang is int)
                {
                    Console.WriteLine(thang);
                }
                if (thang is string)
                {
                    Console.WriteLine(thang);
                }
                if (thang is bool)
                {
                    Console.WriteLine(thang);
                }
                if (thang is int)
                {
                    sum += (int) thang;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
