using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindLargestNumber;

namespace FindLargestNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LargestNumberTest()
        {
            LargestNumber ln = new LargestNumber(new int[] { 20, 1, 4, 19, 21, 30 });

            int expected = 30;
            int acutal = ln.FindLargestNumber();

            Assert.AreEqual(expected, acutal);
        }

        [TestMethod]
        public void NotLargestNumberTest()
        {
            LargestNumber ln = new LargestNumber(new int[] { 20, 1, 4, 19, 21, 30 });

            int expected = 21;
            int acutal = ln.FindLargestNumber();

            Assert.AreNotEqual(expected, acutal);
        }

        [TestMethod]
        public void ArrayWithOneNumber()
        {
            LargestNumber ln = new LargestNumber(new int[] { 20 });

            int expected = 20;
            int acutal = ln.FindLargestNumber();

            Assert.AreEqual(expected, acutal);
        }

        [TestMethod]
        public void ArrayWith6Numbers()
        {
            LargestNumber ln = new LargestNumber(new int[] { 20, 1, 4, 19, 21, 30 });

            int expected = 30;
            int acutal = ln.FindLargestNumber();

            Assert.AreEqual(expected, acutal);
        }
    }
}
