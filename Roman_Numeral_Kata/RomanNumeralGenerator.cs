namespace Roman_Numeral_Kata
{
    public class RomanNumeralGenerator
    {

        private readonly Dictionary<int, string> arabicToRomanDictionary =
            new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50 , "L"},
            { 40 , "XL"},
            { 10, "X"},
            { 9, "IX"},
            { 5, "V"},
            { 1, "I"}
        };

        public string FromArabic(int iArabicNumber)
        {
            var romanValue = GetRomanValueFor(iArabicNumber);

            if (romanValue.Equals(default(KeyValuePair<int, string>))) return string.Empty;

            return $"{romanValue.Value}{FromArabic(iArabicNumber -= romanValue.Key)}";
        }

        private KeyValuePair<int, string> GetRomanValueFor(int arabicNumber)
        {
            return arabicToRomanDictionary.OrderByDescending(x => x.Key)
                .FirstOrDefault(x => x.Key <= arabicNumber);
        }
    }
}