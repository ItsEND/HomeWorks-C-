using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. 
			Определить сумму максимального и минимального элементов массива.
			 */
			int n = 15;
			int[] array = new int[n];

			Random random = new Random();
			for (int i = 0; i < n; i++)
			{
				array[i] = random.Next(0, 50);
				Console.Write("{0} ", array[i]);
			}
			int max = array[0];
			int min = array[0]; //Если поставить его до цикла с рандомом он будет равен 0, что не всегда правильно
			foreach (int a in array)
			{

				if (a > max)
				{
					max = a;
				}
				if (a <= min)
				{
					min = a;
				}
			}
			Console.WriteLine();
			Console.WriteLine("Минимум {0}, Maксимум {1} их сумма равна {2}", min, max, min + max);
			Console.ReadLine();
		}
	}
}
