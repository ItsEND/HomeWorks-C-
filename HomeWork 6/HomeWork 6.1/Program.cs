using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6._1
{
	internal class Program
	{
		/*
		Два треугольника заданы длинами своих сторон. 
		Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
		Для решения задачи можно использовать формулу Герона 
		 */
		static double GetS(double x, double y, double z)
		{
			double p = (x + y + z) / 2;
			return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Введите стороны первого триугольника");
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			double c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите стороны второго триугольника");
			double a2 = Convert.ToDouble(Console.ReadLine());
			double b2 = Convert.ToDouble(Console.ReadLine());
			double c2 = Convert.ToDouble(Console.ReadLine());
			double firstS = GetS(a, b, c);
			double secondS = GetS(a2, b2, c2);
			if (firstS > secondS)
			{
				Console.WriteLine("Первый и он равен {0:.00}", firstS);
			}
			else if (firstS < secondS) { Console.WriteLine("Второй и он равен {0:.00}", secondS); }
			else { Console.WriteLine("Ранвны {0:.00}", secondS); }
			Console.ReadKey();
		}
	}
}
