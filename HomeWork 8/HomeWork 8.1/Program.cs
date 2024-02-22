using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Смоделируйте работу простого калькулятора. 
			Программа должна запрашивать 2 числа, а затем – код операции 
			(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ. 
			Используйте обработку исключений для защиты от ввода некорректных данных.
			 */
			try
			{

				Console.Write("Введите первое число: ");
				double firstNumber = Convert.ToDouble(Console.ReadLine());

				Console.Write("Введите второе число: ");
				double secondNumber = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите номер операции где \n \t 1 - сложение \n \t 2 – вычитание \n \t 3 – произведение \n \t 4 – частное");
				int operation = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ваш выбор {0}", operation);
				switch (operation)
				{
					case 1:
						Addition(firstNumber, secondNumber);
						break;
					case 2:
						Subtraction(firstNumber, secondNumber);
						break;
					case 3:
						Multiplication(firstNumber, secondNumber);
						break;
					//Непонятно почему ошибка в свичах не фиксируется классом Exception??
					case 4:
						if (secondNumber == 0)
							throw new DivideByZeroException("Деление на нуль");
						Division(firstNumber, secondNumber);
						break;
					default:
						throw new ArgumentException("Неверный выбор операции");

				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка: " + ex.Message);

			}
			Console.ReadKey();
		}
		static void Addition(double firstNumber, double secondNumber)
		{
			double result = firstNumber + secondNumber;
			Console.WriteLine(result);
		}
		static void Subtraction(double firstNumber, double secondNumber)
		{
			double result = firstNumber - secondNumber;
			Console.WriteLine(result);
		}
		static void Multiplication(double firstNumber, double secondNumber)
		{
			double result = firstNumber * secondNumber;
			Console.WriteLine(result);
		}
		static void Division(double firstNumber, double secondNumber)
		{
			double result = firstNumber / secondNumber;
			Console.WriteLine(result);
		}
	}
}
