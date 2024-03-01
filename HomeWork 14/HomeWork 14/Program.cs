using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArithProgression arithProgression = new ArithProgression();
			GeomProgression geomProgression = new GeomProgression();
			Console.WriteLine("Введите стартовое значение");
			int x = Convert.ToInt32(Console.ReadLine());



			Console.WriteLine("Введите действие которое хотите совершить\n1 - арифметическая прогрессия\n2 - геометрическая прогрессия\n3 - обе прогрессии");
			int flag = Convert.ToInt32(Console.ReadLine());

			if (flag == 1)
			{
				arithProgression.SetStart(x);
				Console.WriteLine("Вы выбрали арифметическую прогрессию!\nВведите шаг для неё!");
				int step = Convert.ToInt32(Console.ReadLine());
				arithProgression.SetStep(step);
				Console.WriteLine("Сколько раз выполнить прогрессию?");
				int circle = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < circle; i++)
				{
					Console.WriteLine(arithProgression.GetNext());
				}
				Console.WriteLine("Прогрессия прошагала {0} раз, стартовое число равно {1}", circle, x);
			}
			else if (flag == 2)
			{
				geomProgression.SetStart(x);
				Console.WriteLine("Вы выбрали геометрическую прогрессию!\nВведите шаг для неё!");
				int step = Convert.ToInt32(Console.ReadLine());
				geomProgression.SetStep(step);
				Console.WriteLine("Сколько раз выполнить прогрессию?");
				int circle = Convert.ToInt32(Console.ReadLine());
				for (int i = 0; i < circle; i++)
				{
					Console.WriteLine(arithProgression.GetNext());
				}
				geomProgression.Reset();
				Console.WriteLine("Прогрессия прошагала {0} раз, стартовое число равно {1}", circle, x);
			}
			else
			{
				arithProgression.SetStart(x);
				geomProgression.SetStart(x);
				Console.WriteLine("Вы выбрали обе прогресси!\nВведите шаг для них");
				int step = Convert.ToInt32(Console.ReadLine());
				arithProgression.SetStep(step);
				geomProgression.SetStep(step);
				Console.WriteLine("Сколько раз выполнить прогрессию?");

				int circle = Convert.ToInt32(Console.ReadLine());
				for (int i = 0; i < circle; i++)
				{
					Console.WriteLine("Арфметический шаг {0}\nГеометрический шаг {1}", arithProgression.GetNext(), geomProgression.GetNext());
				}

				geomProgression.Reset();
				arithProgression.Reset();
				Console.WriteLine("Прогрессия прошагала {0} раз, стартовое число равно {1}", circle, x);

			}



			Console.ReadKey();
		}
	}
}
