using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Выберите любую папку на своем компьютере, имеющую вложенные директории. 
			Выведите на консоль ее содержимое и содержимое всех подкаталогов.
			*/
			string path = "D:/NewFile";
			string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
			foreach (string file in files)
			{
				Console.WriteLine(file);
			}
			Console.ReadLine();
		}
	}
}
