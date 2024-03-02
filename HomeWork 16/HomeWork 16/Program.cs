using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Создать класс для моделирования счета в банке. 
			 * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
			 * Класс должен быть объявлен как обобщенный. 
			 * Универсальный параметр T должен определять тип номера счета. 
			 * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
			 * Создать  несколько экземпляров класса, параметризированного различными типам. 
			 * Заполнить его поля и вывести на экран информацию об экземпляре класса.*/

			Bill<int> billNumber = new Bill<int>();
			billNumber.InputNumber();
			Console.WriteLine(billNumber.GetInfo());
			Bill<string> billString = new Bill<string>();
			billString.InputString();
			Console.WriteLine(billString.GetInfo());
			Console.ReadKey();

		}
	}
}
