using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Дано целое число в диапазоне 100–999. 
			Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
			Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке. 
			 */
			int number = Convert.ToInt32(Console.ReadLine());
			int fi = number / 100;
			int se = (number % 100) / 10;
			int th = number % 10;
			int xe = number % 100;
			string x = "";
			string y = "";
			string z = "";
			string f = "";
			if (number <= 999 && number >= 100)
			{
				if (xe < 10 || xe > 19)
				{


					switch (fi)
					{
						case 1:
							x = "Сто";
							break;
						case 2:
							x = "Двести";
							break;
						case 3:
							x = "Триста";
							break;
						case 4:
							x = "Четыресто";
							break;
						case 5:
							x = "Пятьсот";
							break;
						case 6:
							x = "Шестьсот";
							break;
						case 7:
							x = "Семьсот";
							break;
						case 8:
							x = "Воесьмьсот";
							break;
						case 9:
							x = "Девятьсот";
							break;

					}

					switch (se)
					{
						case 1:
							y = "десять";
							break;
						case 2:
							y = "двадцать";
							break;
						case 3:
							y = "тридцать";
							break;
						case 4:
							y = "сорок";
							break;
						case 5:
							y = "пятьдесят";
							break;
						case 6:
							y = "шестьдесят";
							break;
						case 7:
							y = "семьдесят";
							break;
						case 8:
							y = "восемьдесят";
							break;
						case 9:
							y = "девяносто";
							break;
					}
					switch (th)
					{
						case 1:
							z = "один";
							break;
						case 2:
							z = "два";
							break;
						case 3:
							z = "три";
							break;
						case 4:
							z = "четрые";
							break;
						case 5:
							z = "пять";
							break;
						case 6:
							z = "шесть";
							break;
						case 7:
							z = "семь";
							break;
						case 8:
							z = "восемь";
							break;
						case 9:
							z = "девять";
							break;
					}
				}
				else
				{
					switch (xe)
					{
						case 11:
							f = "одинадцать";
							break;
						case 12:
							f = "двенадцать";
							break;
						case 13:
							f = "тринадцать";
							break;
						case 14:
							f = "четырнадцать";
							break;
						case 15:
							f = "пятнадцать";
							break;
						case 16:
							f = "шестнадцать";
							break;
						case 17:
							f = "семнадцать";
							break;
						case 18:
							f = "восемнадцать";
							break;
						case 19:
							f = "девятнадцать";
							break;
					}
				}
				if (xe < 10 || xe > 19)
				{
					switch (fi)
					{
						case 1:
							x = "Сто";
							break;
						case 2:
							x = "Двести";
							break;
						case 3:
							x = "Триста";
							break;
						case 4:
							x = "Четыресто";
							break;
						case 5:
							x = "Пятьсот";
							break;
						case 6:
							x = "Шестьсот";
							break;
						case 7:
							x = "Семьсот";
							break;
						case 8:
							x = "Воесьмьсот";
							break;
						case 9:
							x = "Девятьсот";
							break;

					}
					Console.WriteLine("{0} {1} {2}", x, y, z);
				}
				else
				{
					switch (fi)
					{
						case 1:
							x = "Сто";
							break;
						case 2:
							x = "Двести";
							break;
						case 3:
							x = "Триста";
							break;
						case 4:
							x = "Четыресто";
							break;
						case 5:
							x = "Пятьсот";
							break;
						case 6:
							x = "Шестьсот";
							break;
						case 7:
							x = "Семьсот";
							break;
						case 8:
							x = "Воесьмьсот";
							break;
						case 9:
							x = "Девятьсот";
							break;

					}
					Console.WriteLine("{0} {1}", x, f);
				}
			}
			else
			{
				Console.WriteLine("Неверный диапозон");
			}
			Console.ReadKey();
		}
	}
}
