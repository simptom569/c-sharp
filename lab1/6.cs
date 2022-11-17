using System;

namespace zadacha
{
	class Program
	{
		static void main()
		{
			Console.Write("Введите первую сторону: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите вторую сторону: ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите периметр: ");
			double perimetr = Convert.ToDouble(Console.ReadLine());
			double c = perimetr - a - b;
			Console.Write(c);
		}
	}
}