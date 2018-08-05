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
        [Test]
        public void TestFibonacci()
        {
            Assert.AreEqual(0, GetFibonacci(0));
            Assert.AreEqual(1, GetFibonacci(1));

        }

        private int GetFibonacci(int index)
        {
            if (index == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
