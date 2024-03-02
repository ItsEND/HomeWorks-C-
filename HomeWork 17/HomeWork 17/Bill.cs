using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17
{
	internal class Bill<T>
	{
		private T Number { get; set; }
		private decimal Balance { get; set; }
		private string Name { get; set; }
	


		public string GetInfo()
		{
			return $"Номер: {Number}\nБаланс: {Balance}\nИмя: {Name}\n";
		}
		public void InputNumber()
		{

			Console.WriteLine($"Введите числовой номер");
			Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
			Console.WriteLine("Введите имя");
			Name = Console.ReadLine();
			Console.WriteLine("Введите баланс");
			Balance = Convert.ToDecimal(Console.ReadLine());

		}
		public void InputString()
		{
			Console.WriteLine($"Введите строковой номер");
			Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
			Console.WriteLine("Введите имя");
			Name = Console.ReadLine();
			Console.WriteLine("Введите баланс");
			Balance = Convert.ToDecimal(Console.ReadLine());
		}
	}
}
