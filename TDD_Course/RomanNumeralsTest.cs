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
        [Test]
        public void Parse()
        {
            Assert.AreEqual(ParseRoman("I"), 1);
        }

        private int ParseRoman(string s)
        {
            return -1000;
        }
    }
}
