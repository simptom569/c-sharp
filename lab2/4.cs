using System;

namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            double a, b, c, D;


            Console.Write("Первый аргумент: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Второй аргумент: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Третий аргумент: ");
            c = Convert.ToDouble(Console.ReadLine());


            D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
            {
                Console.WriteLine("\nПервый корень: " + (-b + Math.Sqrt(D)) / 2 * a + "\nВторой Корень: " + (b + Math.Sqrt(D)) / 2 * a);
            }
            else if (D == 0)
            {
                Console.WriteLine("\nЕдинственный корень: " + (-b + Math.Sqrt(D)) / 2 * a);
            }
            else if (D < 0)
            {
                Console.WriteLine("\nКорней нет!");
            }
        }
    }
}