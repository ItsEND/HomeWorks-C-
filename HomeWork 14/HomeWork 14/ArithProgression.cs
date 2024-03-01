using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_14
{
	internal class ArithProgression:ISeries
	{
		int Step;
		int startValue;
		int currentValue;
		public int GetNext()
		{
			currentValue += Step;
			return currentValue;
		}

		public void Reset()
		{
			currentValue = startValue;
		}

		public void SetStart(int x)
		{
			
			startValue = x;
			currentValue = startValue;
		}
		public void SetStep(int s)
		{

			Step = s;
		}
	}
}
