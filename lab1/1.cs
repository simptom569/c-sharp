using System;

namespace LearnRSUE
{
    class Program
    {

        static void Main()
        {
            double Pi = 3.14;

            Console.Write("Введите радиус: ");
            double R = Convert.ToDouble(Console.ReadLine());


            double L = 2 * Pi * R;
            double S = Pi * R * R;
            double V = 4 / 3 * Pi * R * R * R;

            Console.WriteLine("Длина окружности равна " + L);
            Console.WriteLine("Площадь окружности равна " + S);
            Console.WriteLine("Обьем шара равен " + V);
        }
    }
}