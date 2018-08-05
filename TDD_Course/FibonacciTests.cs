using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Course
{
    //Sequence of Fibonacci numbers
    //1, 1, 2, 3, 5, 8, 13, 21, 34
    //or
    //0, 1, 1, 2, 3, 5, 8, 13, 21, 34

    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
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
            else if (index <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(index - 1) + GetFibonacci(index - 2);
            }
        }
    }
}
