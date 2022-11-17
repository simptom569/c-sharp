using System;

namespace zadacha
{
	class Program
	{

		static void Main()
		{
			Console.Write("Введите первый катет: ");
			double cat1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите второй катет: ");
			double cat2 = Convert.ToDouble(Console.ReadLine());
			double permietr = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2)) + cat1 + cat2;
			double ploshad = 0.5 * cat1 * cat2;
			Console.WriteLine($"Периметр: {permietr}");
			Console.Write($"Площадь: {ploshad}");
		}
	}
}