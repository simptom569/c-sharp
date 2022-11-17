using System;

namespace Zadacha
{
	class Program
	{
		static void Main()
		{
			int a, b;
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			if ((7 % a == 0) && (7 % b == 0))
			{
				if (a / b > 1)
				{
					Console.WriteLine("Yes");
					if (a % b != 0)
					{
						Console.Write(a%b);
					}
				}
				else
				{
					Console.Write("No");
				}
			}
		}
	}
}