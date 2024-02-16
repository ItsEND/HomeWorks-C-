using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Дана строка S.
			Из строки требуется удалить текст, заключенный в фигурные скобки. 
			В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
			Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
					
			*/
			Console.WriteLine("Введите строку:");
			string str = Console.ReadLine();
			char opBracket = '{';
			char clBracket = '}';

			int o = str.IndexOf(opBracket);
			int c = str.LastIndexOf(clBracket);
			string newStr = str.Substring(o);
			string firstHalf = str.Substring(0, o+1);
			string secondHalf = str.Substring(0, c+1);
			int o2 = newStr.IndexOf(opBracket);
			int c2 = newStr.IndexOf(clBracket);
			string str2 = "";
			if (o != -1 && c != -1)
			{
				if (o2 != -1 && c2 != -1)
				{
					newStr = str.Substring(o);
					newStr = str.Remove(o, 0);
					o2 = newStr.IndexOf(opBracket);
					c2 = newStr.IndexOf(clBracket);
					newStr = newStr.Remove(o2, 1);
					newStr = newStr.Remove(c2, 1);
					str2 =firstHalf+newStr;
				}
				str = str.Remove(o, c - o + 1);
			}
			
            Console.WriteLine(newStr);
			


            Console.ReadLine();
		}
	}
}
