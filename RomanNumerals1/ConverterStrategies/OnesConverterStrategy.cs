using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals1.ConverterStrategies
{
	public class OnesConverterStrategy : IConverter
	{
		public string Convert(int number)
		{
			int onesToConvert = CalculateNumberOfOnesToConvert(number);

			string conversion = string.Empty;

			int i = 1;

			while (i <= onesToConvert)
			{
				if (i == 4)
					conversion = "IV";
				else if (i == 5)
					conversion = "V";
				else if (i == 9)
					conversion = "IX";
				else
					conversion += "I";
				i++;
			}

			return conversion;
		}

		private int CalculateNumberOfOnesToConvert(int number)
		{
			int numberOfOnes = number % 10;

			return numberOfOnes;
		}
	}
}
