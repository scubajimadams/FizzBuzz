using System;
using clFizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_ValidRange()
        {
            FizzBuzz fb = new FizzBuzz("Fizz","Buzz",1,100,100,200);
            Assert.AreEqual(fb._rangeEnd-fb._rangeStart, 100);
        }

        [TestMethod]
        public void FizzBuzz_WhenRangeStartNegative_ThrowException()
        {
            FizzBuzz fb = new FizzBuzz("Fizz","Buzz",20,80, 40,20);
            if(fb._rangeStart < fb._rangeEnd)
                throw new ArgumentOutOfRangeException();
        }
    }
}
