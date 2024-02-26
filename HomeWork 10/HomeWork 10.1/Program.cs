using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Разработать структуру для решения линейного уравнения 0=kx+b.
			//Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
			//Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры.
			//Осуществить использование экземпляра в программе.
			Console.WriteLine("Введите k");
			double k = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите b");
			double b = Convert.ToDouble(Console.ReadLine());

			Line line = new Line(k, b);

			Console.WriteLine(line.Root());
			Console.ReadKey();


		}
	}
}
