using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Ввести с клавиатуры предложение. 
			Предложение представляет собой слова, разделенные пробелом. 
			Знаки препинания не используются. 
			Найти самое длинное слово в строке.
			 */
			string str =Console.ReadLine();
			string[] strArray= str.Split();
			string max = strArray[0];
			foreach(string a in strArray)
			{
				if (max.Length < a.Length)
				{
					max = a;
				}				
			}
			Console.WriteLine(max);
			Console.ReadLine();
		}
	}
}
