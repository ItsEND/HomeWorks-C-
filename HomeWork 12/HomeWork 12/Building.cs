using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12
{
	internal class Building
	{
		string adress;
		double length;
		double width;
		double height;

		string Adress
		{
			get
			{
				return adress;
			}
			set
			{
				adress = value;
			}
		}
		double Length
		{
			get
			{
				return length;
			}
			set
			{
				if (length < 0)
				{
					length = 0;
				}
				else if (length > 1000)
				{
					length = 1000;
				}
				else
				{
					length = value;
				}
			}
		}
		double Width
		{
			get
			{
				return width;
			}
			set
			{
				if (width < 0)
				{
					width = 0;
				}
				else if (width > 1000)
				{
					width = 1000;
				}
				else
				{
					width = value;
				}
			}
		}
		double Height
		{
			get
			{
				return height;
			}
			set
			{
				if (height < 0)
				{
					height = 0;
				}
				else if (height > 1000)
				{
					height = 1000;
				}
				else
				{
					height = value;
				}
			}
		}
		public Building(string adress, double length, double width, double height)
		{
			Adress = adress;
			Length = length;
			Width = width;
			Height = height;
		}
		public string Print()
		{
			return $"Адресс здания:{Adress}\nДлина здания: {Length}\nШирина здания:{Width}\nВысота здания: {Height}";
		}


	}
}
