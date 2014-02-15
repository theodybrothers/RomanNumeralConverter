using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals1.ConverterStrategies
{
	public class TensConverterStrategy : IConverter
	{
		public string Convert(int number)
		{			
			int tensToConvert = CalculateNumberOfTensToConvert(number);

			string conversion = string.Empty;

			int i = 1;

			while (i <= tensToConvert)
			{
				if (i == 4)
					conversion = "XL";
				else if (i == 5)
					conversion = "L";
				else if (i == 9)
					conversion = "XC";
				else
					conversion += "X";
				i++;
			}

			return conversion;
		}

		private int CalculateNumberOfTensToConvert(int number)
		{
			int numberOfTens = (number % 100) / 10;

			return numberOfTens;
		}
	}
}
