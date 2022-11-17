using System;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			int y, g;
			double x = Convert.ToInt32(Console.ReadLine());
			int i = Convert.ToInt32(Console.ReadLine());
			if (x < 1500)
			{
				x -= (x/100)*1;
				y = 1;
			}
			if (x < 3000)
			{
				x -= (x/100)*3;
				y = 3;
			}
			if (x > 5000)
			{
				x -= (x/100)*5;
				y = 5;
			}
			else
			{
				y = 0;
			}
			switch (i)
			{
				case 0:
					g = 0;
				case 1:
					g = 150;
					x -= g;
				case 2:
					g = 200;
					x -= g;
				case 3:
					g = 250;
					x -= g;
				case 4:
					g = 300;
					x -= g;
				case 5:
					g = 350;
					x -= g;
			}
			Console.WriteLine(y);
			Console.WriteLine(g)
			Console.Write(x);
		}
	}
}