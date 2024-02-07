using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
			Найти координаты его четвертой вершины. 
			Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, параллельными координатным осям, вывести соответствующее сообщение.
			 */
			Console.WriteLine("Введите координаты трех вершин прямоугольника:");
			Console.Write("Вершина A (x1 y1): ");
			int x1 = Convert.ToInt32(Console.ReadLine());
			int y1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Вершина B (x2 y2): ");
			int x2 = Convert.ToInt32(Console.ReadLine());
			int y2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Вершина C (x3 y3): ");
			int x3 = Convert.ToInt32(Console.ReadLine());
			int y3 = Convert.ToInt32(Console.ReadLine());

			int x4, y4;

			if (x1 == x2)
			{
				x4 = x3;
			}
			else if (x1 == x3)
			{
				x4 = x2;
			}
			else
			{
				x4 = x1;
			}

			if (y1 == y2)
			{
				y4 = y3;
			}
			else if (y1 == y3)
			{
				y4 = y2;
			}
			else
			{
				y4 = y1;
			}

			if ((x1 == x2 && y2 == y3) || (x2 == x3 && y3 == y1) || (x3 == x1 && y1 == y2))
			{
				Console.WriteLine("Нельзя построить прямоугольник со сторонами, параллельными координатным осям.");
			}
			else
			{
				Console.WriteLine($"Координаты четвертой вершины: ({x4}, {y4})");
			}

			Console.ReadKey();
		}
	}
}
