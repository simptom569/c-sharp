using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			double y;
			double x = Convert.ToInt32(Console.ReadLine());
			if (x > 0)
			{
				y = -(Math.Sin(2*x+1));
			}
			if (x == 0)
			{
				y = 0;
			}
			if (x < 0)
			{
				y = 3*Math.Cos(Math.Abs(x)+1);
			}
			Console.Write(y);
		}
	}
}