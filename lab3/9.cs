using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			for (int i = 1; i <= 10; i++)
			{
				for (int g = 1; g <= 10; g++)
				{
					Console.WriteLine($"{i} * {g} = {i*g}");
				}
			}
		}
	}
}