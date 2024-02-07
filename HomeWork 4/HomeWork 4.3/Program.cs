using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. 
			Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
			*/
			int n = 10;
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

			for (int i = 0; i < 5; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (array[i] > array[j])
					{
						int t = array[i];
						array[i] = array[j];
						array[j] = t;
					}
				}

			}

			for (int i = 0; i > 5; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (array[i] > array[j])
					{
						int t = array[i];
						array[i] = array[j];
						array[j] = t;
					}
				}

			}

			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				Console.Write("{0,3} ", array[i]);
			}
			Console.ReadKey();
		}
	}
}
