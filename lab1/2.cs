using System;

namespace LearnRSUE
{
    class Program
    {

        static void Main()
        {
            int a, b, c;

            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("a = " + a + " b = " + b);

        }
    }
}