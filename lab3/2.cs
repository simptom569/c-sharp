using System;

public class Chisla
{
	public static void Main(string[] args)
	{
		int c;
		Console.Write("Введите a:");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Введите b:");
		int b = Convert.ToInt32(Console.ReadLine());
		for (int i=a; i<=b; i++)
		{
			c = i % 10;
			if (c == 5)
			{
				Console.WriteLine(i);
			}
		}
	}
}