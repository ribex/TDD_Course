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
        [Test]
        public void TestFizzBuzz()
        {
            Assert.AreEqual("Fizz", FizzBuzz(3));
        }

        private string FizzBuzz(int number)
        {
            return null;
        }
    }
}
