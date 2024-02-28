using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Задан класс Building, который описывает здание. Класс содержит следующие элементы:
				адрес здания;
				длина здания;
				ширина здания;
				высота здания.
			В классе Building нужно реализовать следующие методы:

				конструктор с 4 параметрами;
				свойства get/set для доступа к полям класса;
				метод Print(), который выводит информацию о здании.
			Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

				конструктор с 5 параметрами – реализует вызов конструктора базового класса;
				свойство get/set доступа к внутреннему полю класса;
				метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
			Класс MultiBuilding сделать таким, что не может быть унаследован.*/
			Console.WriteLine("Введите адрес здания");
			string adress = Console.ReadLine();
			Console.WriteLine("Введите длину здания");
			double length = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите ширину здания");
			double width = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите высоту здания");
			double height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите этажность здания");
			int floor = Convert.ToInt32(Console.ReadLine());

			Building building = new Building(adress, length, width, height);
			Console.WriteLine(building.Print());

			MultiBuilding multiBuilding = new MultiBuilding(adress, length, width, height, floor);
			Console.WriteLine(multiBuilding.Print());
			Console.ReadLine();

		}
	}
}
