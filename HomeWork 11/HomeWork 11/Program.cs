using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Разработать статический класс для работы с окружностью.
			//Класс должен содержать 3 метода:
			//метод, определяющий длину окружности по заданному радиусу;
			//метод, определяющий площадь круга по заданному радиусу;
			//метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
			Console.WriteLine("Введите радиус круга r");
			double r = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите координаты x и y");
			int x=Convert.ToInt32(Console.ReadLine());
			int y=Convert.ToInt32(Console.ReadLine());

			double length = Circle.GetLength(r);
			double square = Circle.GetSquare(r);
			string Afflication = Circle.GetAffilation(x, y, r);
			Console.WriteLine("Длина равна: {0:.000}\nПлоащадь равна: {1:.000}\n{2}",length, square, Afflication);
			Console.ReadKey();



		}
	}
}
