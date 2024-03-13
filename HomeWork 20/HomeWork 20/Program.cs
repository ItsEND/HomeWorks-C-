using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork_20
{
	internal class Program
	{

		const int rows = 1000;
		const int cols = 5000;
		static int[,] garden = new int[rows, cols];

		static void Main(string[] args)
		{
			/* Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать. 
			 * Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом. 
			 * Первый садовник начинает работу с верхнего левого угла сада и перемещается слева направо, сделав ряд, он спускается вниз. 
			 * Второй садовник начинает работу с нижнего правого угла сада и перемещается снизу вверх, сделав ряд, он перемещается влево. 
			 * Если садовник видит, что участок сада уже выполнен другим садовником, он идет дальше. Садовники должны работать параллельно. 
			 * Создать многопоточное приложение, моделирующее работу садовников.*/
			object _lock = new object();
			object lock_ = new object();


			Thread thread1 = new Thread(GardenerOne);
			Thread thread2 = new Thread(GardenerTwo);

			thread1.Start();
			thread2.Start();

			thread1.Join();
			thread2.Join();

			Console.WriteLine("Завершенный сад:");
			for (int i = 0; i < rows; i++)
			{
				lock (_lock)
					for (int j = 0; j < cols; j++)
					{
						lock (lock_)
							Console.Write(garden[i, j] + " ");
					}
				Console.WriteLine();
			}
			Console.ReadKey();
		}

		static void GardenerOne()
		{
			for (int i = 0; i < rows; i++)
			{

				for (int j = 0; j < cols; j++)
				{
					if (garden[i, j] == 0)
					{
						garden[i, j] = 1;
						Console.WriteLine($"Садовник 1 завершил участок ({i}, {j})");
					}
				}
			}
		}

		static void GardenerTwo()
		{
			for (int i = rows - 1; i >= 0; i--)
			{
				for (int j = cols - 1; j >= 0; j--)
				{
					if (garden[i, j] == 0)
					{
						garden[i, j] = 2;
						Console.WriteLine($"Садовник 2 завершил участок ({i}, {j})");
					}
				}
			}
		}
	}
}
