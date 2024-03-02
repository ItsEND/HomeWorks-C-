using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17
{
	internal class Program
	{
		/* Создать класс для моделирования счета в банке. 
		 * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
		 * Класс должен быть объявлен как обобщенный. 
		 * Универсальный параметр T должен определять тип номера счета. 
		 * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
		 * Создать  несколько экземпляров класса, параметризированного различными типам. 
		 * Заполнить его поля и вывести на экран информацию об экземпляре класса.*/
		static void Main(string[] args)
		{
			Bill<int> bill = new Bill<int>();
			bill.InputNumber();
			Console.WriteLine(bill.GetInfo());
			Bill<string> billstring = new Bill<string>();
			billstring.InputString();
			Console.WriteLine(billstring.GetInfo());
			Console.ReadLine();
		}
	}
}
