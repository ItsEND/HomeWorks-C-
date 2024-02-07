using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
			Определить количество   нечетных положительных элементов, стоящих на четных местах.
			 */
			int n = 20;
			int c = 0;
			int[] array = new int[n];

			Random random = new Random();

			for (int z = 0; z < n; z++)
			{
				Console.Write("{0,3} ", z);
			}
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				array[i] = random.Next(-50, 50);
				Console.Write("{0,3} ", array[i]);
			}
			for (int i = 0; i < n; i++)
			{
				if ((array[i] % 2 != 0) && (i % 2 == 0) && (array[i] > 0))
				{
					c++;
				}
			}
			Console.WriteLine();
			Console.WriteLine(c);
			Console.ReadKey();
		}
	}
}
