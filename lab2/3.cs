using System;

namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            double Procent, Vklad = 0;


            Console.Write("Введите сумму вклада(тыс. руб): ");
            Vklad = Convert.ToDouble(Console.ReadLine());

            if (Vklad < 100)
            {
                Procent = 5 / 1.2;
                Console.WriteLine("\nВы будете получать: \nВ месяц: " + Math.Round(Vklad * Procent, 2) + "\nВ год: " + Vklad * 50);
            }
            else if (Vklad >= 100 && Vklad <= 200)
            {
                Procent = 7 / 1.2;
                Console.WriteLine("\nВы будете получать: \nВ месяц: " + Math.Round(Vklad * Procent, 2) + "\nВ год: " + Vklad * 70);
            }

            else if (Vklad > 200)
            {
                Procent = 10 / 1.2;
                Console.WriteLine("\nВы будете получать: \nВ месяц: " + Math.Round(Vklad * Procent, 2) + "\nВ год: " + Vklad * 100);
            }

        }
    }
}