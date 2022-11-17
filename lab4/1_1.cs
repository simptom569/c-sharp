using System;
using System.Linq;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			int sum=0, chet=0, nechet=0, nul=0, sumchet=0, kolchet=0, sumkrat=0, kolkrat=0;
			long pro=1;
			int[] Arr = new int[10];
			Random rnd = new Random();
			for (int i=0; i<10; i++)
			{
				Arr[i] = rnd.Next(0, 100);
				sum += Arr[i];
				pro *= Arr[i];

				if (Arr[i] == 0)
				{
					nul++;
				}
				else if (Arr[i] % 2 == 0)
				{
					chet++;
				}
				else
				{
					nechet++;
					if (Arr[i] % 5 == 0)
					{
						sumchet += Arr[i];
						kolchet++;
					}
				}
				if ((Arr[i] % 3 == 0) && (Arr[i] % 10 == 9))
				{
					sumkrat += Arr[i];
					kolkrat++;
				}
			}
			Console.WriteLine(Arr.Max());//Максимальное
			Console.WriteLine(Arr.Min());//Минимально
			Console.WriteLine(Array.IndexOf(Arr, Arr.Max()));//позиция максимального
			Console.WriteLine(Array.IndexOf(Arr, Arr.Min()));//позиция минимального
			Console.WriteLine(Arr.Length);//количество
			Console.WriteLine(sum);//сумма
			Console.WriteLine(pro);//произведение
			Console.WriteLine(chet);//четных
			Console.WriteLine(nechet);//нечетных
			Console.WriteLine(nul);//нулевых
			Console.WriteLine(sumchet);//сумма нечетных кратных 5
			Console.WriteLine(kolchet);//количество нечетных кратных 5
			Console.WriteLine(sumkrat);//сумма кратных 3 и оканчивающихся на 9
			Console.WriteLine(kolkrat);//количество кратных 3 и оканчивающихся на 9
		}
	}
}