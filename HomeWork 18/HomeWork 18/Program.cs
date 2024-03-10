using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork_18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  частотой  работы  процессора,  
			 * объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, 
			 * стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. 
			 * Создать список, содержащий 6-10 записей с различным набором значений характеристик.

			Определить:

				- все компьютеры с указанным процессором. Название процессора запросить у пользователя;

				- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;

				- вывести весь список, отсортированный по увеличению стоимости;

				- вывести весь список, сгруппированный по типу процессора;

				- найти самый дорогой и самый бюджетный компьютер;

				- есть ли хотя бы один компьютер в количестве не менее 30 штук?*/
			List<Computer> listComputer = new List<Computer>()
			{
				new Computer() {Id = 1, Mark = "Toshiba", TypeOfProcessor = "Intel Core i5", Tact = 3.6, VRAM = 16, VHDD = 1000, GpuRam = 6, Cost = 80000,  Quantity = 35 },
				new Computer() {Id = 2, Mark = "Surface", TypeOfProcessor = "Intel Core i7", Tact = 4.0, VRAM = 32, VHDD = 2000, GpuRam = 8, Cost = 120000, Quantity = 10 },
				new Computer() {Id = 3, Mark = "Apple",	  TypeOfProcessor = "Apple M1",      Tact = 3.2, VRAM = 16, VHDD = 512,  GpuRam = 8, Cost = 150000, Quantity = 8 },
				new Computer() {Id = 4, Mark = "HyperPC", TypeOfProcessor = "AMD Ryzen 9",	 Tact = 4.2, VRAM = 32, VHDD = 2000, GpuRam = 8, Cost = 110000, Quantity = 6 },
				new Computer() {Id = 5, Mark = "Amateur", TypeOfProcessor = "AMD Ryzen 7",	 Tact = 3.8, VRAM = 32, VHDD = 1000, GpuRam = 8, Cost = 90000,  Quantity = 34 },
				new Computer() {Id = 6, Mark = "Toshiba", TypeOfProcessor = "Intel Core i3", Tact = 3.4, VRAM = 8,  VHDD = 500,  GpuRam = 4, Cost = 60000,  Quantity = 0 },
				new Computer() {Id = 7, Mark = "HP",	  TypeOfProcessor = "Intel Core i5", Tact = 3.6, VRAM = 16, VHDD = 1000, GpuRam = 6, Cost = 85000,  Quantity = 3 },
				new Computer() {Id = 8, Mark = "MSI",	  TypeOfProcessor = "Intel Core i7", Tact = 4.0, VRAM = 32, VHDD = 2000, GpuRam = 8, Cost = 130000, Quantity = 9 }
			};

			int managment;
            Console.WriteLine($"Здравствуйте вы попали в магазин компьютеров, асортимент у нас не большой, но наш консультант поможет подобрать Вам лучший компьютер\n" +
				$"Пока к вам подходит консультант вы можете рассмотреть витрину\n" +
				$"На витрине вы видете компьютеры таких марок, как:");
			Thread.Sleep(3000);

			GetAllc(listComputer);
			Thread.Sleep(1500);
			Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n*К вам подходит робот консультант*\n");
			Thread.Sleep(2000);
			Console.ResetColor();
            Console.WriteLine("\nЗдравствуйте, я ваш консультат пожалуйста выберите действие, которое вы хоите совершить, Вот их список:\n");
			Thread.Sleep(1000);
            do
			{
				
				Console.WriteLine("Выберете действие которое хотите совершить\n" +
					"\n1 - Вывести все компьютеры с указанным Вами процессором.\n" +
					"\n2 - Вывести все компьютеры с объемом ОЗУ не ниже, чем указано Вами.\n" +
					"\n3 - Вывести весь список, отсортированный по увеличению стоимости.\n" +
					"\n4 - Вывести весь список, сгруппированный по типу процессора.\n" +
					"\n5 - Найти самый дорогой и самый бюджетный компьютер.\n" +
					"\n6 - Узнать есть ли хотя бы один компьютер в количестве не менее 30 штук?.\n" +
					"\n0 - Выйти\n");

				managment = Convert.ToInt32(Console.ReadLine());

				switch (managment)
				{
					case 0:
						Console.WriteLine("Уже уходите?\nЧтож прощайте!");
						break;
					case 1:
						GetProcessor(listComputer);
						break;
					case 2:
						GetVRAM(listComputer);
						break;
					case 3:
						GetCost(listComputer);
						break;
					case 4:
						GetGroupByProccessor(listComputer);
						break;
					case 5:
						GetPoisk(listComputer);
						break;
					case 6:
						GetComputer(listComputer);
						break;
				}
			} while (managment != 0);

           Thread.Sleep(3000);
		}
		//Все компьютеры с указанным процессором. Название процессора запросить у пользователя;
		public static void GetProcessor(List<Computer> listComputer)   
		{
		
			Console.WriteLine("Введите тип процессора");
			string userTypeOfProcessor = Console.ReadLine();
			List<Computer> computers = listComputer
				.Where(d=> d.TypeOfProcessor == userTypeOfProcessor).ToList();
			foreach (Computer c in computers)
			{
				Console.WriteLine($"\nНомер компьютреа: {c.Id}\nМарка: {c.Mark}\nТип процессора: {c.TypeOfProcessor}\nТактовая частота: {c.Tact}" +
					$"\nОбъем ОЗУ: {c.VRAM}\nОбъем жесткого диска: {c.VHDD}\nОбъем памяти видеокарты: {c.GpuRam}\nСтоимость: {c.Cost}\nКоличество: {c.Quantity}");
				Thread.Sleep(1000);
			}

		}
		//все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;
		public static void GetVRAM(List<Computer> listComputer)
		{
			Console.WriteLine("Введите объем ОЗУ");
			double userVRAM = Convert.ToDouble(Console.ReadLine());
			List<Computer> computers = listComputer
				.Where(d=>d.VRAM>=userVRAM)
				.ToList();
			foreach (Computer c in computers)
			{
				Console.WriteLine($"\nНомер компьютреа: {c.Id}\nМарка: {c.Mark}\nТип процессора: {c.TypeOfProcessor}\nТактовая частота: {c.Tact}" +
					$"\nОбъем ОЗУ: {c.VRAM}\nОбъем жесткого диска: {c.VHDD}\nОбъем памяти видеокарты: {c.GpuRam}\nСтоимость: {c.Cost}\nКоличество: {c.Quantity}");
				Thread.Sleep(1000);
			}
		}
		// вывести весь список, отсортированный по увеличению стоимости;
		public static void GetCost(List<Computer> listComputer) 
		{
			List<Computer> computers = listComputer
				.OrderBy(d => d.Cost)
				.ToList();
			foreach (Computer c in computers)
			{
				Console.WriteLine($"\nНомер компьютреа: {c.Id}\nМарка: {c.Mark}\nТип процессора: {c.TypeOfProcessor}\nТактовая частота: {c.Tact}" +
					$"\nОбъем ОЗУ: {c.VRAM}\nОбъем жесткого диска: {c.VHDD}\nОбъем памяти видеокарты: {c.GpuRam}\nСтоимость: {c.Cost}\nКоличество: {c.Quantity}");
				Thread.Sleep(1000);
			}
		}
		//вывести весь список, сгруппированный по типу процессора;
		public static void GetGroupByProccessor(List<Computer> listComputer)
		{
			var computers = listComputer
				.GroupBy(d => d.TypeOfProcessor).ToList();
			foreach (var g in computers)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\nПроцессор: {g.Key}" );
				Console.ResetColor();
				foreach (var c in g)
				{
                    Console.WriteLine($"\nНомер компьютреа: {c.Id}\nМарка: {c.Mark}\nТип процессора: {c.TypeOfProcessor}\nТактовая частота: {c.Tact}" +
						$"\nОбъем ОЗУ: {c.VRAM}\nОбъем жесткого диска: {c.VHDD}\nОбъем памяти видеокарты: {c.GpuRam}\nСтоимость: {c.Cost}\nКоличество: {c.Quantity}");
                }
				Thread.Sleep(1000);
			}
			
		}
		//найти самый дорогой и самый бюджетный компьютер;
		public static void GetPoisk(List<Computer> listComputer)
		{
			var MAXcomputer = listComputer
				.OrderBy(d=>d.Cost)
				.Last();

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"Самый дорогой компьютер:\nНомер компьютреа: {MAXcomputer.Id}\nМарка: {MAXcomputer.Mark}\nТип процессора: {MAXcomputer.TypeOfProcessor}" +
					$"\nТактовая частота: {MAXcomputer.Tact}\nОбъем ОЗУ: {MAXcomputer.VRAM}\nОбъем жесткого диска: {MAXcomputer.VHDD}" +
					$"\nОбъем памяти видеокарты: {MAXcomputer.GpuRam}\nСтоимость: {MAXcomputer.Cost}\nКоличество: {MAXcomputer.Quantity}");
				Console.ResetColor ();
			Thread.Sleep(1000);

			var MINcomputer = listComputer
				.OrderBy(d => d.Cost)
				.First();
			Console.ForegroundColor = ConsoleColor.Blue;

				Console.WriteLine($"\nСамый дешевый компьютер:\nНомер компьютреа: {MINcomputer.Id}\nМарка: {MINcomputer.Mark}\nТип процессора: {MINcomputer.TypeOfProcessor}" +
					$"\nТактовая частота: {MINcomputer.Tact} \nОбъем ОЗУ:  {MINcomputer.VRAM}\nОбъем жесткого диска: {MINcomputer.VHDD}" +
					$"\nОбъем памяти видеокарты: {MINcomputer.GpuRam}\nСтоимость: {MINcomputer.Cost}\nКоличество: {MINcomputer.Quantity}");
			Console.ResetColor ();

		}
		//есть ли хотя бы один компьютер в количестве не менее 30 штук?
		public static void GetComputer(List<Computer> listComputer)
		{
			int computers = listComputer
				.Count(d => d.Quantity > 30);
			if (computers > 0)
			{
				var computer = listComputer
					.Where(d => d.Quantity > 30).ToList();
				Console.WriteLine("Да есть, их колчество {0} вот они: ",computers);
				foreach (Computer c in computer)
				{
					Console.WriteLine($"\nНомер компьютреа: {c.Id}\nМарка: {c.Mark}\nТип процессора: {c.TypeOfProcessor}\nТактовая частота: {c.Tact}" +
					$"\nОбъем ОЗУ: {c.VRAM}\nОбъем жесткого диска: {c.VHDD}\nОбъем памяти видеокарты: {c.GpuRam}\nСтоимость: {c.Cost}\nКоличество: {c.Quantity}");
				}
			}
			else Console.WriteLine("Нет компьютеров в количестве больше 30");

        }
		public static void GetAllc(List<Computer> listComputer)
		{
			foreach (Computer c in listComputer)
			{
				Console.WriteLine($"\nНомер компьютреа: {c.Id}\nМарка: {c.Mark}\nПроцессор: {c.TypeOfProcessor}");
				Thread.Sleep(1000);
			}
		}
	}
}
