using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
			Последовательность потенциально не ограничена, окончанием последовательности служит число 0. (do-while)
			 */
			Console.WriteLine("");
			int N = 0;
			int p = 0;
			int o = 0;
			do
			{
				N = Convert.ToInt32(Console.ReadLine());
				if (N > 0)
				{
					p++;
				}
				else if (N < 0)
				{
					o++;
				}
			}
			while (N != 0);

			if (p > o)
			{
				Console.WriteLine("Положительных чисел больше их аж {0}! А вот отрицательных меньше их всего {1}(", p, o);
			}
			else if (o > p)
			{
				Console.WriteLine("Отрицательных чисел больше их аж {1}! А вот положительных меньше их всего {0}(", p, o);
			}
			else if (p == o)
			{
				Console.WriteLine("Вы интересный человек, вы ввели одинаковое количество положительных и отрицательных чисел");
			}
			Console.ReadKey();
		}
	}
}
