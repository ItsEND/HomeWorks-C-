using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* 
			Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
			Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»,
			например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год». 
			Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
			 */
			Console.WriteLine("Введите число в диапозоне 20-69");
			int number = Convert.ToInt32(Console.ReadLine());
			int l = number % 10;
			int f = number / 10;
			string fi = "";
			string li = "";
			if (number <= 69 && number >= 20)
			{
				if (l == 1)
				{
					li = "один";
				}
				else if (l == 2)
				{
					li = "два";
				}
				else if (l == 3)
				{
					li = "три";
				}
				else if (l == 4)
				{
					li = "четыре";
				}
				else if (l == 5)
				{
					li = "пять";
				}
				else if (l == 6)
				{
					li = "шесть";
				}
				else if (l == 7)
				{
					li = "семь";
				}
				else if (l == 8)
				{
					li = "восемь";
				}
				else if (l == 9)
				{
					li = "девять";
				}
				if (f == 2)
				{
					fi = "двадцать";
				}
				else if (f == 3)
				{
					fi = "тридцать";
				}
				else if (f == 4)
				{
					fi = "сорок";
				}
				else if (f == 5)
				{
					fi = "пятьдесят";
				}
				else if (f == 6)
				{
					fi = "шестьдесят";
				}
				switch (l)
				{
					case 0:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
						Console.WriteLine("Вам {0} {1} лет", fi, li);
						break;
					case 1:
						Console.WriteLine("Вам {0} {1} год", fi, li);
						break;
					default:
						Console.WriteLine("Вам {0} {1} года", fi, li);
						break;
				}

			}
			else
			{
				Console.WriteLine("Вы ввели неверное число");
			}
			Console.ReadKey();
		}
	}
}
