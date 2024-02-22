using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Программно создайте текстовый файл и запишите в него 10 случайных чисел.
			//Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
			string path = "D:/numbers.txt";
			Random rand = new Random();
			int sum = 0;
			using (StreamWriter sw = new StreamWriter(path, false))
			{
				for (int i = 0; i < 10; i++)
				{
					sw.WriteLine(rand.Next(-10, 10));
				}
			}
			using (StreamReader sr = new StreamReader(path))
			{
				for (int i = 0; i < 10; i++)
				{
					int a = Convert.ToInt32(sr.ReadLine());
					sum += a;
				}
			}
			Console.WriteLine(sum);
			Console.ReadLine();
		}
	}
}
