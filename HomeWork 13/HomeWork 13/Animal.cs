using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13
{
	abstract class Animal
	{
		public abstract string Name { get; set; }
		public Animal(string name)
		{
			Name = name;
		}
		public abstract void Say();
		public void ShowInfo()
		{
			Console.Write("Меня зовут {0} и я очень люблю говорить ",Name);
			Say();
        }
	}
}
