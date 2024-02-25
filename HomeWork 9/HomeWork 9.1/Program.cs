using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Transform transform;


			//Угол задан с помощью целочисленных значений
			//gradus - градусов, min - угловых минут, sec - угловых секунд.
			//Реализовать класс, в котором указанные значения представлены в виде свойств.
			//Для свойств предусмотреть проверку корректности данных.
			//Класс должен содержать конструктор для установки начальных значений,
			//а также метод ToRadians для перевода угла в радианы.
			//Создать объект на основе разработанного класса.
			//Осуществить использование объекта в программе.
			try
			{
				
					Console.WriteLine("Введите градусы");
					int gradus = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Введите минуты");
					int min = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Введите секунды");
					int sec = Convert.ToInt32(Console.ReadLine());

					transform = new Transform(gradus, min, sec);
			
				

				double ToRadians = transform.ToRadians();

				Console.WriteLine("Радианы равны {0:.00000}", ToRadians);
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadLine();


		}
	}
}
