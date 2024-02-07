using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
			Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
			*/
			int A = Convert.ToInt32(Console.ReadLine());
			int B = Convert.ToInt32(Console.ReadLine());
			int C = Convert.ToInt32(Console.ReadLine());
			int count = 0;
			A = Math.Abs(A);
			B = Math.Abs(B);
			C = Math.Abs(C);


			while (A - C >= 0)
			{
				A -= C;
				int extraPointB = B;
				while (extraPointB - 1 >= 0)
				{
					extraPointB -= C;
					count++;
				}
			}
			Console.WriteLine(count);
			Console.ReadKey();
		}
	}
}
