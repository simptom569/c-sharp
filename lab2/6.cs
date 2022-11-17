using System;

namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            Random Random = new Random();
            int a = Random.Next(1, 9), b = Random.Next(1, 9), c, d;

            c = a * b;

            Console.Write(a + "*" + b + "=");
            d = Convert.ToInt32(Console.ReadLine());
            
            if (d == c)
            {
                Console.WriteLine("\nПравильно!");
            }
            else if (d != c)
            {
                Console.WriteLine("\nНеправильно!");
            }

        }
    }
}