using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9._1
{
	internal class Transform
	{
		int gradus;
		int min;
		int sec;
		public int Gradus
		{
			get
			{
				return gradus;
			}
			set
			{
				gradus = value % 24;
			}
		}
		public int Min
		{
			get
			{
				return min;
			}
			set
			{
				Gradus += value / 60;
				min = value % 60;
			}
		}
		public int Sec
		{
			get
			{
				return sec;
			}
			set
			{
				Min += value / 60;
				sec = value % 60;
			}
		}
		public Transform(int gradus,int min,int sec)
		{
			this.gradus = gradus;
			this.min = min;
			this.sec = sec;
		}

		public double ToRadians()
		{
			return (sec / 3600 + min / 60 + gradus) * (Math.PI / 180);
		}
	}
}
