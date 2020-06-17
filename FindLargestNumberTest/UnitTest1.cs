using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindLargestNumber;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;

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
            int actual = ln.FindLargestNumber();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotLargestNumberTest()
        {
            LargestNumber ln = new LargestNumber(new int[] { 20, 1, 4, 19, 21, 30 });

            int expected = 21;
            int actual = ln.FindLargestNumber();

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayWithOneNumber()
        {
            LargestNumber ln = new LargestNumber(new int[] { 20 });

            int expected = 20;
            int actual = ln.FindLargestNumber();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayWith6Numbers()
        {
            LargestNumber ln = new LargestNumber(new int[] { 20, 1, 4, 19, 21, 30 });

            int expected = 30;
            int actual = ln.FindLargestNumber();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayWith0Numbers()
        {
            LargestNumber ln = new LargestNumber(new int[] {});

            int expected = 0;
            int actual = ln.FindLargestNumber();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfMemoryException))]
        public void OutOfMemory()
        {
            List<int> mylist = new List<int>();
            while (true)
            {
                mylist.Add(100);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(TargetParameterCountException))]
        public void TargetParameter(int numbers)
        {
            Console.WriteLine(numbers);
            numbers++;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StackOver()
        {
            LargestNumber ga = new LargestNumber(new int[] { 20, 1, 4, 19, 21, 30 });
            int expected = 0;
            int actual = ga.GetAge(int.MinValue);
            Assert.AreEqual(expected, actual);
            try
            {
                StackOver();
            }
            catch (StackOverflowException e)
            {
                Debug.WriteLine(e);
            }
            
        }



    }
}
