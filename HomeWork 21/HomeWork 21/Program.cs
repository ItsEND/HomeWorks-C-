using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace HomeWork_21
{
	internal class Program
	{
		static int[] RandomInts()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] ints = new int[n];
			Random rnd = new Random();
			for (int i = 0; i < ints.Length; i++)
			{
				ints[i] = rnd.Next(0, 50);
				Console.Write($"{ints[i]} ");
			}
			Console.WriteLine();
			return ints;
		}

		static int ResultMax(int[] ints)
		{
			int max = ints[0];
			foreach (int i in ints)
			{
				if (i > max)
				{
					max = i;
				}
			}
			return max;
		}

		static int ResultSum(int[] ints)
		{
			int sum = 0;
			foreach (int a in ints)
			{
				sum += a;
			}
			return sum;
		}

		static async Task Main(string[] args)
		{
			Console.WriteLine("Введите длину списка: ");
			int[] randomIntegers = RandomInts();

			Task<int> sumTask = Task.Run(() => ResultMax(randomIntegers));
			Task<int> maxTask = Task.Run(() => ResultSum(randomIntegers));

			await Task.WhenAll(maxTask, sumTask);

			Console.WriteLine($"Макс: {maxTask.Result}");
			Console.WriteLine($"Сумма: {sumTask.Result}");

			Console.ReadLine();


			
				/* Сформировать массив случайных целых чисел (размер  задается пользователем). 
				 * Вычислить сумму чисел массива и максимальное число в массиве.  
				 * Реализовать  решение  задачи  с  использованием  механизма  задач продолжения.
				*/
		}

	}
}

