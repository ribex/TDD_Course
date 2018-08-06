using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDD_Course
{
    //If divisible by 3      -> return "Fizz"
    //If divisible by 5      -> return "Buzz"
    //If divisible by 3 & 5  -> return "FizzBuzz"
    //Else                   -> return ""

    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase("Fizz", 3)]
        [TestCase("Buzz", 5)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("", 1)]
        [TestCase("Fizz", 6)]
        [TestCase("Buzz", 10)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("FizzBuzz", 45)]
        [TestCase("", 0)]
        public void TestFizzBuzz(string output, int number)
        {
            Assert.AreEqual(output, FizzBuzz(number));
        }

        private string FizzBuzz(int number)
        {
            if (number == 0)
            {
                return "";
            }

            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return "";
        }
    }
}
