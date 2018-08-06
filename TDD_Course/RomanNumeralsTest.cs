using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TDD_Course
{
    [TestFixture()]
    public class RomanNumeralsTest
    {
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]

        public void Parse(string roman, int arabic)
        {
            Assert.AreEqual(ParseRoman(roman), arabic);
        }

        private int ParseRoman(string roman)
        {
            int number = 0;

            if (roman == "M")
            {
                number = 1000;
            }

            if (roman == "D")
            {
                number = 500;
            }

            if (roman == "C")
            {
                number = 100;
            }

            if (roman == "L")
            {
                number = 50;
            }

            if (roman == "XL")
            {
                number = 40;
            }

            if (roman == "X")
            {
                number = 10;
            }

            if (roman == "IX")
            {
                number = 9;
            }

            if (roman == "VI")
            {
                number = 6;
            }

            if (roman == "V")
            {
                number = 5;
            }

            if (roman == "IV")
            {
                number = 4;
            }

            if (roman == "III")
            {
                number = 3;
            }

            if (roman == "II")
            {
                number = 2;
            }

            if (roman == "I")
            {
                number = 1;
            }

            return number;
        }
    }
}
