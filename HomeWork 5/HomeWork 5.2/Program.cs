using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Ввести с клавиатуры предложение. 
			Предложение представляет собой слова, разделенные пробелом. 
			Знаки препинания не используются. 
			Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
			 */
			string str =Console.ReadLine();
			str=str.ToLower();
			str = str.Replace(" ", "");
			string str2 = "";
			foreach (char s in str)
			{
				str2 = s+ str2;
			}
			
			if (str == str2)
			{
				Console.WriteLine("Является");
			}
			else
			{
                Console.WriteLine("Не является");
            }

            Console.WriteLine("{0}\n{1}",str2,str);
            Console.ReadLine();
		}
	}
}
