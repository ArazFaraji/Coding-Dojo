using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // for (int i = 1; i < 256; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 3 == 0 || i % 5 == 0)
            //     {
            //         if(i % 3 == 0 && i % 5 == 0)
            //         {
            //             continue;
            //         }
            //         else 
            //         {
            //             Console.WriteLine(i);
            //         }
            //     }
            // }

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
        }
    }
}
