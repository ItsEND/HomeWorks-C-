using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Запросить у пользователя целочисленное значение N. 
			Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры. 
			Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
			Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.
			 */
			Console.WriteLine("Введите размерность матрицы");
			int n = Convert.ToInt32(Console.ReadLine());
			int[,] array = new int[n, n];
			bool flag = false;
			int SumStrings = 0;
			int SumColums = 0;
			int diagSum1 = 0;
			int diagSum2 = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.WriteLine("Введите {0}-ую строчку матрицы", i + 1);
					array[i, j] = Convert.ToInt32(Console.ReadLine());
				}

			}
			for (int i = 0; i < n; i++)
			{
				SumStrings += array[0, i];
				SumColums += array[i, 0];
			}
			for (int i = 0; i < n; i++)
			{
				diagSum1 += array[i, i];
				diagSum2 += array[i, n - 1 - i];
			}
			if (diagSum1 == diagSum2 && diagSum1 == SumStrings && diagSum1 == SumColums)
			{
				flag = true;
			}
			if (flag == true)
			{
				Console.WriteLine("Является магическим квадратом");
			}
			else
			{
				Console.WriteLine("Не является магическим квадратом");
			}
			Console.WriteLine("Сумма строк равна {0}, Сумма столбцов равна {1},  Сумма главной диагонали равна {2}, Сумма побочной диагонали равна  {3}", SumStrings, SumColums, diagSum1, diagSum2);
			Console.ReadLine();
		}
	}
}
