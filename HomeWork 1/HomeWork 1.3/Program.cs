using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). 
			Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости. 
			Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона:  где  p— полупериметр.
			 */
			Console.WriteLine("Введите координаты треугольника x1,y1,x2,y2,x3,y3");
			double x1 = Convert.ToInt32(Console.ReadLine());
			double y1 = Convert.ToInt32(Console.ReadLine());
			double x2 = Convert.ToInt32(Console.ReadLine());
			double y2 = Convert.ToInt32(Console.ReadLine());
			double x3 = Convert.ToInt32(Console.ReadLine());
			double y3 = Convert.ToInt32(Console.ReadLine());
			double a = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
			double b = Math.Sqrt((Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)));
			double c = Math.Sqrt((Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2)));
			double P = a + b + c;
			double p = (a + b + c) / 2;
			double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			Console.WriteLine("Периметр P равен {0}, площадь S равна {1}, полупериметр равен {2}", P, S, p);
			Console.ReadKey();
		}
	}
}
