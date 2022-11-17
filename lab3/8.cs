using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			double x = Convert.ToInt32(Console.ReadLine());
			int g = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= g; i++)
			{
				x += (x/100)*5;
			}
			Console.Write(x);
		}
	}
}