using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.
			 */
			Console.WriteLine("Введите длину окружности");
			double L = Convert.ToDouble(Console.ReadLine());
			double R = L / (2 * Math.PI);
			double S = Math.PI * Math.Pow(R, 2);
			Console.WriteLine("Радиус R = {0} Площадь S = {1}", R, S);
			Console.ReadKey();
		}
	}
}
