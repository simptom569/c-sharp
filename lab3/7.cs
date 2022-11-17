using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			int s = 0, k = 0;
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			for (int i = a; i <= b; i++)
			{
				if (i % 8 == 0)
				{
					Console.WriteLine(i);
					s += i;
					k++;
				}
			}
			Console.WriteLine(s);
			Console.Write(k);
		}
	}
}