using System;
using System.Linq;

namespace zadacha
{
	class Program
	{
		static void Main()
		{
			int[] Arr = new int[5];
			int[] Arr1 = new int[5];
			for (int i=0; i<5; i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
				Arr1[i] = Arr[i];
			}
			Array.Sort(Arr1);
			if (Arr.SequenceEqual(Arr1))
			{
				Console.Write("Упорядочен");
			}
			else
			{
				Array.Reverse(Arr1);
				if (Arr.SequenceEqual(Arr1))
				{
					Console.Write("Упорядочен");
				}
				else
				{
					Console.Write("Неупорядочен");
				}
			}
		}
	}
}