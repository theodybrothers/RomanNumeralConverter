using NUnit.Framework;
using RomanNumerals1.ConverterStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals1.Tests
{
	[TestFixture]
	public class RomanNumeralConverterUnitTests
	{
		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(3, "III")]
		[TestCase(4, "IV")]
		[TestCase(5, "V")]
		[TestCase(6, "VI")]
		[TestCase(7, "VII")]
		[TestCase(8, "VIII")]
		[TestCase(9, "IX")]
		[TestCase(24, "XXIV")]	
		[TestCase(40, "XL")]
		[TestCase(45, "XLV")]
		[TestCase(459, "CDLIX")]
		[TestCase(666, "DCLXVI")]
		[TestCase(999, "CMXCIX")]
		[TestCase(1100, "MC")]
		[TestCase(1234, "MCCXXXIV")]
		[TestCase(2444, "MMCDXLIV")]	
		[TestCase(3000, "MMM")]		
		public void CanSuccessfullyConvertValidValuesToRomanNumerals(int input, string output)
		{
			//Arrange
			var converter = new RomanNumeralConverter();

			//Act
			var result = converter.ConvertToRomanNumerals(input);

			//Assert			
			Assert.IsTrue(result == output);
		}

		[TestCase(0, "Invalid value")]
		[TestCase(3001, "Invalid value")]
		[TestCase(-1, "Invalid value")]
		public void CanHandleInvalidValues(int input, string output)
		{
			//Arrange
			var converter = new RomanNumeralConverter();

			//Act
			var result = converter.ConvertToRomanNumerals(input);

			//Assert			
			Assert.IsTrue(result == output);
		}

		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(3, "III")]
		[TestCase(4, "IV")]
		[TestCase(5, "V")]
		[TestCase(6, "VI")]
		[TestCase(7, "VII")]
		[TestCase(8, "VIII")]
		[TestCase(9, "IX")]
		public void CanConvertOnesSuccessfully(int input, string output)
		{
			//Arrange
			var converter = new OnesConverterStrategy();

			//Act
			var result = converter.Convert(input);

			//Assert			
			Assert.IsTrue(result == output);
		}

		[TestCase(10, "X")]
		[TestCase(20, "XX")]
		[TestCase(30, "XXX")]
		[TestCase(40, "XL")]
		[TestCase(50, "L")]
		[TestCase(60, "LX")]
		[TestCase(70, "LXX")]
		[TestCase(80, "LXXX")]
		[TestCase(90, "XC")]
		public void CanConvertTensSuccessfully(int input, string output)
		{
			//Arrange
			var converter = new TensConverterStrategy();

			//Act
			var result = converter.Convert(input);

			//Assert			
			Assert.IsTrue(result == output);
		}

		[TestCase(100, "C")]
		[TestCase(200, "CC")]
		[TestCase(300, "CCC")]
		[TestCase(400, "CD")]
		[TestCase(500, "D")]
		[TestCase(600, "DC")]
		[TestCase(700, "DCC")]
		[TestCase(800, "DCCC")]
		[TestCase(900, "CM")]
		public void CanConvertHundredsSuccessfully(int input, string output)
		{
			//Arrange
			var converter = new HundredsConverterStrategy();

			//Act
			var result = converter.Convert(input);

			//Assert			
			Assert.IsTrue(result == output);
		}

		[TestCase(1000, "M")]        
		[TestCase(2000, "MM")]
		[TestCase(3000, "MMM")]		
		public void CanConvertThousandsSuccessfully(int input, string output)
		{
			//Arrange
			var converter = new ThousandsConverterStrategy();

			//Act
			var result = converter.Convert(input);

			//Assert			
			Assert.IsTrue(result == output);
		}
	}
}
