using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			int a;
			a = Convert.ToInt32(Console.ReadLine());
			if ((a % 2 == 1) && (a % 10 == 7))
			{
				Console.Write("Yes");
			}
			else
			{
				Console.Write("No");
			}
		}
	}
}