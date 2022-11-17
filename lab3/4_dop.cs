using System;
 
namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            bool Quesh = true, Quesh2 = true;
            int a, trys = 1;
            string b;
 
 
            while (Quesh)
            {
                Random r = new Random();  // Создаем рандомное число от 0 до 100
                int rnd = r.Next(0, 100); //
 
                Console.Write("\nУгадай число: ");
                a = Convert.ToInt32(Console.ReadLine());
 
                Quesh2 = true; // Включаем второй цикл (нужно после того как пользователь вписал "д")
                trys = 1; // Обнуляем попытки
 
                while (Quesh2)
                {
                    if (a > rnd)
                    {
                        Console.Write("Перелет!: ");
                        a = Convert.ToInt32(Console.ReadLine());
 
                        trys++;
                    }
                    else if (a < rnd)
                    {
                        Console.Write("Недолет!: ");
                        a = Convert.ToInt32(Console.ReadLine());
 
                        trys++;
                    }
                    else if (a == rnd)
                    {
                        Console.Write("\nМолодец! В точку!\nПопыток: " + trys + "\nНачать заново? д/н: ");
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
                        }
                    }
                }
            }
        }
    }
}