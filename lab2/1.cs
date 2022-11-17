using System;

namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            double b, a = 0;

            a = Convert.ToDouble(Console.ReadLine());

            b = a % 2;

            if (b > 0)
            {
                Console.WriteLine("Число не является четным");
            }
            if (b == 0)
            {
                Console.WriteLine("Число является четным");
            }

        }
    }
}