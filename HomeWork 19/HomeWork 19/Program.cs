using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19
{
	internal class Program
	{
		delegate double MyDelegate(double R);
		static void Main(string[] args)
		{
			/*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
			- метод получает входным параметром переменную типа double;
			- метод возвращает значение типа double, которое является результатом вычисления. 
			Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
			- длину окружности по формуле D = 2 * π* R;
			- площадь круга по формуле S = π* R²;
			- объем шара. Формула V = 4/3 * π * R³.
			Методы должны быть объявлены как статические.*/
			Console.WriteLine("Введите радиус R");
			double R = Convert.ToDouble(Console.ReadLine());

			MyDelegate myLength = new MyDelegate(GetLength);
			double D = myLength.Invoke(R);
			MyDelegate myS = new MyDelegate(GetS);
			double S = myS.Invoke(R);
			MyDelegate myV = new MyDelegate(GetV);

			Console.WriteLine("Длина равна: {0:.00}\nПлощадь круга равна: {1:.00}\nОбъем равен: {2:.00}", D, S, myV.Invoke(R));
			Console.ReadKey();

		}

		static double GetLength(double R)
		{
			return 2 * Math.PI * R;

		}
		static double GetS(double R)
		{
			return Math.PI * R;
		}
		static double GetV(double R)
		{
			return (4 / 3) * (Math.PI * Math.Pow(R, 3));
		}
	}
}
