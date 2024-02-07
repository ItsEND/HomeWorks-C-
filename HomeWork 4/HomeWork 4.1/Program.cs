using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Сформировать одномерный массив из 7 элементов.
			 
			  Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.*/

			int[] array = new int[7];
			int s = 0;

			for (int i = 0; i < 7; i++)
			{
				Console.WriteLine("Введите {0}-ое значение", i + 1);
				array[i] = Convert.ToInt32(Console.ReadLine()); ;
				s += array[i];
			}
			Console.WriteLine();
			Console.WriteLine("Среднее арифмитическое равно {0}", s / 7);
			Console.ReadKey();
		}
	}
}
