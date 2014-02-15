using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals1.ConverterStrategies
{
	public class ThousandsConverterStrategy : IConverter
	{
		public string Convert(int number)
		{						
			int thousandsToConvert = CalculateNumberOfThousandsToConvert(number);

			string conversion = string.Empty;
			int i = 1;

			while (i <= thousandsToConvert)
			{
				conversion += "M";
				i++;
			}			
			
			return conversion;
		}

		private int CalculateNumberOfThousandsToConvert(int number)
		{
			int numberOfThousands = number / 1000;

			return numberOfThousands;
		}
	}
}
