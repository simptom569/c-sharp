using System;

public class chikli
{
	public static void Main(string[] args)
	{
		int a, b;
		a = 0;
		b = 0;
		for (int i=2; i<=100; i=i+2)
		{
			a++;
			b = b + i;
			Console.WriteLine(i);
		}
		Console.WriteLine(a);
		Console.WriteLine(b);
	}
}