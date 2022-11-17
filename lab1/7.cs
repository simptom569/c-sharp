using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			double b, c;
			Console.Write("Введите сторону треугольника: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите периметр: ");
			double perimetr = Convert.ToDouble(Console.ReadLine());
			b = c = (perimetr - a)/2;
			Console.Write(b);
		}
	}
}