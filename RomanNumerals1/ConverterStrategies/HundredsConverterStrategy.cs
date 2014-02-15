using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals1.ConverterStrategies
{
	public class HundredsConverterStrategy : IConverter
	{
		public string Convert(int number)
		{
			int hundredsToConvert = CalculateNumberOfHundredsToConvert(number);

			string conversion = string.Empty;
			int i = 1;

			while (i <= hundredsToConvert)
			{
				if (i == 4)
					conversion = "CD";
				else if (i == 5)
					conversion = "D";
				else if (i == 9)
					conversion = "CM";
				else
					conversion += "C";
				i++;				
			}

			return conversion;
		}

		private int CalculateNumberOfHundredsToConvert(int number)
		{			
			int numberOfHundreds = (number % 1000) / 100;

			return numberOfHundreds;
		}
	}
}
