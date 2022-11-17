using System;
 
namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            bool Quesh = true, Quesh2 = true;
            double a, trys = 0, Ttrys = 0, Btrys = 0;
            string b;
 
 
            while (Quesh)
            {
                Random r = new Random();                      // Создаем 2 случайных числа
                int rnd1 = r.Next(1, 9), rnd2 = r.Next(1, 9); //
 
                Console.Write("\n" + rnd1 + " * " + rnd2 + " = ");
                a = Convert.ToInt32(Console.ReadLine());
 
                Quesh2 = true; // Включаем второй цикл (нужно после того как пользователь вписал "д")
 
                while (Quesh2)
                {
                    if (a != rnd1 * rnd2)
                    {
                        trys++;  // Для счетчика попыток
                        Btrys++; //
 
                        Console.WriteLine("Неверно!");
                        Console.Write("\nПродолжить? д/н: ");
                        b = Console.ReadLine();
 
                        if (b == "д")
                        {
                            Quesh2 = false; // отключаем второй цикл что бы начать игру заново
                            Quesh = true;
                        }
                        else
                        {
                            Quesh2 = false;
                            Quesh = false;
 
                            Console.WriteLine("\nВсего попыток - " + trys);
                            Console.WriteLine("Верных ответов - " + Ttrys + " (" + Math.Round(100 * Ttrys / trys, 2) + "%)");
                            Console.WriteLine("Неверных ответов - " + Btrys + " (" + Math.Round(100 * Btrys / trys, 2) + "%)");
 
                        }
                    }
 
                    else if (a == rnd1 * rnd2)
                    {
                        trys++;
                        Ttrys++;
 
                        Console.WriteLine("Верно!");
                        Console.Write("\nПродолжить? д/н: ");
                        b = Console.ReadLine();
 
                        if (b == "д")
                        {
                            Quesh2 = false; // отключаем второй цикл что бы начать игру заново
                            Quesh = true;
                        }
                        else
                        {
                            Quesh2 = false;
                            Quesh = false;
 
                            Console.WriteLine("\nВсего попыток - " + trys);
                            Console.WriteLine("Верных ответов - " + Ttrys + " (" + Math.Round(100 * Ttrys / trys, 2) + "%)");
                            Console.WriteLine("Неверных ответов - " + Btrys + " (" + Math.Round(100 * Btrys / trys, 2) + "%)");
                        }
                    }
                }
            }
        }
    }
}