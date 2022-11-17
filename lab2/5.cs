using System;

namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            int day;

            Console.Write("Введие номер дня недели: ");
            day = Convert.ToInt16(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("\nПонедельник");
                    break;
                case 2:
                    Console.WriteLine("\nВторник");
                    break;
                case 3:
                    Console.WriteLine("\nСреда");
                    break;
                case 4:
                    Console.WriteLine("\nЧетверг");
                    break;
                case 5:
                    Console.WriteLine("\nПятница");
                    break;
                case 6:
                    Console.WriteLine("\nСуббота");
                    break;
                case 7:
                    Console.WriteLine("\nВоскресенье");
                    break;
            }

            if (day > 7)
            {
                Console.WriteLine("\nТакого дня недели не существует");
            }
        }
    }
}