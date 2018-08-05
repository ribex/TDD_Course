using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Course
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1, 2)]
        public void TestFibonacci(int expected, int index)
        {
            Assert.AreEqual(expected, GetFibonacci(index));
        }

        private int GetFibonacci(int index)
        {
            if (index == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
