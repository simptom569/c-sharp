using System;

public class Hello
{
	public static void Main(string[] args)
	{
		int a = Convert.ToInt32(Console.ReadLine());
		int b = 0;
		int c = 0;
		for (int i=1; i<=a; i++)
		{
			b = Convert.ToInt32(Console.ReadLine());
			if (b%5 == 0)
			{
				if (c<b)
				{
					c = b;
				}
			}
		}
		Console.WriteLine(c);
	}
}