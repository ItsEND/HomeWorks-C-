using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._1
{
	struct Line
	{
		double k;
		double b;

		public Line(double k, double b)
		{
			this.k = k;
			this.b = b;
		}

		public string Root()
		{
			if (k== 0 && b!=0)
			{
				return "Нет корней";
			}

			double x = -b/k;
			return $"Отевет - {x}";
			
		}


	}
}
