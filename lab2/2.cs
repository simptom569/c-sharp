using System;

namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            int a, b;

            a = Convert.ToInt32(Console.ReadLine());            
            b = a % 10;
            if ((10 <= a) && (a <= 99) && (b == 3))
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }
}