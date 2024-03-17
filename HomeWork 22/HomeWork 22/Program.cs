using System;
using System.Threading.Tasks;

namespace HomeWork_22
{
	internal class Program
	{
		//Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
		
		static int Factorial(int num)
		{
			int result = 1;
			for (int i = 1; i <= num; i++)
			{
				result *= i;
			}
			Console.WriteLine($"Факториал числа {num}: {result}");
			return result;
		}

		static async Task<int> FactorialAsync(int num)
		{
			return await Task.Run(() => Factorial(num));
		}

		static async Task Main(string[] args)
		{
			Console.WriteLine("Введите число:");
			int num = Convert.ToInt32(Console.ReadLine());

			int factorial = await FactorialAsync(num);

			Console.WriteLine($"Факториал числа {num} подсчитан асинхронно: {factorial}");
			Console.ReadKey();
			while (true)
			{
                await Console.Out.WriteLineAsync("Огромное спасибо за курс, он был невероятно полезен (благодаря нему я нашел работу)");
            }
			Console.Write("Благодарю");
		}
	}
}
