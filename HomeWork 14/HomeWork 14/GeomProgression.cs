using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_14
{
	internal class GeomProgression : ISeries
	{
		int Step;
		int startValue;
		int currenValue;
		public int GetNext()
		{
			currenValue*=Step;
			return currenValue;
		}

		public void Reset()
		{
			currenValue = startValue;
		}

		public void SetStart(int x)
		{
			startValue = x;
			currenValue = startValue;
			
		}
		public void SetStep(int s)
		{
			Step = s;
		}
	}
}
