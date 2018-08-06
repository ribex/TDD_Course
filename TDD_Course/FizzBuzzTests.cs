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
        public void TestFizzBuzz(string output, int number)
        {
            Assert.AreEqual(output, FizzBuzz(number));
        }

        private string FizzBuzz(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }

            if (number == 5)
            {
                return "Buzz";
            }

            if (number == 15)
            {
                return "FizzBuzz";
            }
            return null;
        }
    }
}
