using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			Console.Write("Введите x: ");
			double x = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите y: ");
			double y = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите z: ");
			double z = Convert.ToDouble(Console.ReadLine());
			double f = (Math.Pow((y + Math.Pow((x - 1), 1.0/3.0)), 1.0/4.0))/((Math.Pow(Math.Sin(z)), 2) + Math.Tan(z));
			Console.Write(f);
		}
	}
}