using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12
{
	internal sealed class MultiBuilding : Building
	{
		int floor;
		int Floor
		{
			get
			{
				return floor;
			}
			set
			{
				floor = value;
			}
		}
		public MultiBuilding(string adress, double length, double width, double height, int floor)
			: base(adress, length, width, height)
		{
			Floor = floor;
		}
		public new string Print()
		{
			string result = base.Print();
			result += $"\nЭтажей {Floor}";
			return result;
		}
	}
}
