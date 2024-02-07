using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			На числовой оси расположены три точки: A, B, C.
			Определить, какая из двух последних точек (B или C) расположена ближе к A, и вывести эту точку и ее расстояние от точки A.
			Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А, совпадать с А или между собой - выдать соответствующее сообщение.
			*/
			Console.WriteLine("Введите координаты x и y для точки А");
			double x1 = Convert.ToDouble(Console.ReadLine());
			double y1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите координаты x и y для точки B");
			double x2 = Convert.ToDouble(Console.ReadLine());
			double y2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите координаты x и y для точки C");
			double x3 = Convert.ToDouble(Console.ReadLine());
			double y3 = Convert.ToDouble(Console.ReadLine());

			double distAB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			double distAC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
			if (distAB < distAC)
			{
				Console.WriteLine("Точка B ближе к A");
			}
			else if (distAB > distAC)
			{
				Console.WriteLine("Точка С ближе к А");
			}
			else
			{
				Console.WriteLine("Точки В и С находятся на равном отдолении от точка А");
			}
			Console.ReadKey();
		}
	}
}
