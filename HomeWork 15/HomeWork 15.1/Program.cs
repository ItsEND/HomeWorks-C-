using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace HomeWork_15._1
{
	internal class Program
	{
		public static object JsonSerializerOptions { get; private set; }

		static void Main(string[] args)
		{
			/*
			Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.

			Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса
			«Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
			Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
			Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».
			*/
			const int n = 5;
			Product[] products = new Product[n];
			for (int i = 0; i < n; i++)
			{


				Console.WriteLine("Введите Код товара");
				int idProduct = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите название торвара");
				string nameProduct = Console.ReadLine();
				Console.WriteLine("Введите цену товара");
				double costProduct = Convert.ToDouble(Console.ReadLine());

				products[i] = new Product() { IdProduct = idProduct, NameProduct = nameProduct, CostProduct = costProduct };
			}
			JsonSerializerOptions options = new JsonSerializerOptions()
			{
				Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
				WriteIndented = true
			};
			string jsonString = JsonSerializer.Serialize(products,options);

			using (StreamWriter sw = new StreamWriter("../../../Products.json"))
			{
				sw.WriteLine(jsonString);
			}

		}
	}
}
