using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    class RomanNumeral
    {
        public void romanEquation(int number)
        {
            string numeraldate = romanNumeralMaker(number);
            Console.WriteLine("Roman Numeral Answer");
            Console.WriteLine(numeraldate);
        }
        public static string romanNumeralMaker(int number)
        {
            if ((number < 0) || (number > 10000))
                throw new ArgumentOutOfRangeException("Please enter a value betwheen 1 and 10,000");
            if (number < 1)
                return string.Empty;
            if (number >= 1000)
                return "M" + romanNumeralMaker(number - 1000);
            if (number >= 900)
                return "CM" + romanNumeralMaker(number - 900);
            if (number >= 500)
                return "D" + romanNumeralMaker(number - 500);
            if (number >= 400)
                return "CD" + romanNumeralMaker(number - 400);
            if (number >= 100)
                return "C" + romanNumeralMaker(number - 100);
            if (number >= 90)
                return "XC" + romanNumeralMaker(number - 90);
            if (number >= 50)
                return "L" + romanNumeralMaker(number - 50);
            if (number >= 40)
                return "XL" + romanNumeralMaker(number - 40);
            if (number >= 10)
                return "X" + romanNumeralMaker(number - 10);
            if (number >= 9)
                return "IX" + romanNumeralMaker(number - 9);
            if (number >= 5)
                return "V" + romanNumeralMaker(number - 5);
            if (number >= 4)
                return "IV" + romanNumeralMaker(number - 4);
            if (number >= 1)
                return "I" + romanNumeralMaker(number - 1);
            throw new ArgumentOutOfRangeException("Please enter a value betwheen 1 and 3999");
        }
        
    }
}
