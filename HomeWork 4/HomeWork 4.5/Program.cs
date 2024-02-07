using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
             Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:

				1 0 1 0 1

				0 1 0 1 0

				1 0 1 0 1

				0 1 0 1 0

				1 0 1 0 1
             */
			Console.WriteLine("Введите значение");
			int n = Convert.ToInt32(Console.ReadLine());
			int[,] array = new int[n, n];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					array[i, j] = ((i + j) % 2 == 0) ? 1 : 0;
					Console.Write("{0} ", array[i, j]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
