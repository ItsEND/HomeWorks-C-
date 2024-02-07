using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). 
			Стороны прямоугольника параллельны осям координат. 
			Найти периметр и площадь данного прямоугольника.
			 */
			Console.WriteLine("Введите координаты x1,y1,x2,y2");
			int x1 = Convert.ToInt32(Console.ReadLine());
			int y1 = Convert.ToInt32(Console.ReadLine());
			int x2 = Convert.ToInt32(Console.ReadLine());
			int y2 = Convert.ToInt32(Console.ReadLine());
			int P = 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
			int S = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
			Console.WriteLine("Периметр равен {0}, площадь равна {1}", P, S);
			Console.ReadKey();
		}
	}
}
