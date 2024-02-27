using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
	static class Circle
	{
		static public double GetLength(double r)
		{
			return 2 * Math.PI * r;
		}
		static public double GetSquare(double r)
		{
			return Math.PI * Math.Pow(r, 2);
		}
		static public string GetAffilation(int x, int y, double r)
		{
			double hypoenuse = Math.Sqrt(x * x + y * y);
			if (hypoenuse <= r)
			{
				return "Принадленит";

			}
			else
			{
				return "Не принадлежит";
			}
		}
	}
}
