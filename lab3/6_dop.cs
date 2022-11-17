using System;
 
namespace LearnRSUE
{
    class Program
    {
        static void Main()
        {
            int one, two;
 
            Console.Write("От какого числа(диапазон): ");
            one = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("До какого числа(диапазон): ");
            two = Convert.ToInt32(Console.ReadLine());
 
 
            for (int i = one; i <= two; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i != 1 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                else if (i == 2 || i == 3 || i == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}