using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6._2
{
	internal class Program
	{
		/*
		Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
		*/
		static void GetParamSphere(double a, out double S, out double V)
		{
			S = 6 * a * a;
			V = Math.Pow(a, 3);
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Введите длину ребра куба");
			double a = Convert.ToDouble(Console.ReadLine());
			double S;
			double V;
			GetParamSphere(a, out S, out V);
			Console.WriteLine("Площадь полной поверхности куба равна {0:.00}, а объем равен {1:.00}",S,V);
			Console.ReadLine();
		}
	}
}
