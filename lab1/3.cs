using System;

namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            int full, one, two, three, a;

            Console.Write("Введите трехзначное число: ");
            full = Convert.ToInt32(Console.ReadLine());


            a = full / 10; // Промежуточное действие


            one = full / 100; // Получаем первое число 
            two = a % 10; // Получаем второе число
            three = full % 10; // Получаем третье число


            Console.WriteLine("Сумма чисел равна: " + (one + two + three));
            Console.WriteLine("Произведение чисел равна: " + (one * two * three));
        }
    }
}