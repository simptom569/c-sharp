using System;
 
namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            int a = 0;
 
 
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
 
            if (a % 2 != 0 && a % 3 != 0 && a != 1 && a % 5 != 0)
            {
                Console.WriteLine("Простое");
            }
            else if (a == 2 || a == 3 || a == 5)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
        }
    }
}