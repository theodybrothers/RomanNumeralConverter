using RomanNumerals1.ConverterStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals1
{
	public class RomanNumeralConverter
	{
		private List<IConverter> _converterStrategies;

		public RomanNumeralConverter()
		{
			_converterStrategies = new List<IConverter>
			{
				new ThousandsConverterStrategy(),
				new HundredsConverterStrategy(),
				new TensConverterStrategy(),
				new OnesConverterStrategy()
			};
		}

		public string ConvertToRomanNumerals(int number)
		{
			if (number <= 0 || number > 3000)
				return "Invalid value";

			string result = string.Empty;

			_converterStrategies.ForEach(x => result += x.Convert(number));

			return result;
		}
	}
}
