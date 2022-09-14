using NUnit.Framework;
using Roman_Numeral_Kata;

namespace Roman_Numeral_Tests
{
    public class Roman_Numeral_Generator_Should
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(5, "V")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(1999, "MCMXCIX")]
        [TestCase(2008, "MMVIII")]
        public void Generate_Roman_Numeral_For_Given_Value(int arabicValue, string romanNumeral)
        {
            RomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            Assert.That(romanNumeralGenerator.FromArabic(arabicValue), Is.EqualTo(romanNumeral));
        }
    }
}