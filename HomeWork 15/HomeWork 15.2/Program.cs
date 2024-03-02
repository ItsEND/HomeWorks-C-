using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace HomeWork_15._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Необходимо разработать программу для получения информации о товаре из json-файла.
			Десериализовать файл «Products.json» из задачи 1.
			Определить название самого дорогого товара.*/
			string jsonString = String.Empty;
			using (StreamReader sr = new StreamReader("../../../Products.json"))
			{
				jsonString = sr.ReadToEnd();
			}
			Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
			Product maxProduct = products[0];
			foreach (Product a in products)
			{
				if (a.CostProduct > maxProduct.CostProduct)
				{
					maxProduct= a;
				}
			}
            Console.WriteLine($"Самый дорогой товар имеет ID: {maxProduct.IdProduct}\nНаззвание товара: {maxProduct.NameProduct}\nЦена товара: {maxProduct.CostProduct}");
			Console.ReadLine();
        }
	}
}
