using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibTest
{


    /// <summary>
    ///This is a test class for IntegerExtensionsTest and is intended
    ///to contain all IntegerExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IntegerExtensionsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetDivisors
        ///</summary>
        [TestMethod()]
        public void GetDivisorsTestLong()
        {
            long number = 28;
            long[] expected = { 1, 2, 4, 7, 14, 28 };
            long[] actual = IntegerExtensions.GetDivisors(number).ToArray();

            ArrayCompare(expected, actual);
        }
        /// <summary>
        ///A test for GetDivisors
        ///</summary>
        [TestMethod()]
        public void GetReverseDivisorsTestLong()
        {
            long number = 28;
            long[] expected = { 28, 14, 7, 4, 2, 1 };
            long[] actual = IntegerExtensions.GetReverseDivisors(number).ToArray();

            ArrayCompare(expected, actual);

        }
        /// <summary>
        ///A test for GetDivisors
        ///</summary>
        [TestMethod()]
        public void GetReverseDivisorsTestWith1()
        {
            long number = 1;
            long[] expected = { 1 };
            long[] actual = IntegerExtensions.GetReverseDivisors(number).ToArray();

            ArrayCompare(expected, actual);
        }

        /// <summary>
        ///A test for GetDivisors
        ///</summary>
        [TestMethod()]
        public void GetDivisorsTestInt()
        {
            int number = 28;
            int[] expected = { 1, 2, 4, 7, 14, 28 };
            int[] actual = IntegerExtensions.GetDivisors(number).ToArray();

            ArrayCompare(expected, actual);
        }

        /// <summary>
        ///A test for GetDivisors
        ///</summary>
        [TestMethod()]
        public void GetDivisorsTestShort()
        {
            short number = 28;
            short[] expected = { 1, 2, 4, 7, 14, 28 };
            short[] actual = IntegerExtensions.GetDivisors(number).ToArray();

            ArrayCompare(expected, actual);
        }

        [TestMethod()]
        public void IsEvenTestLong()
        {
            Assert.IsTrue(42L.IsEven());
        }
        [TestMethod()]
        public void IsNotEvenTestLong()
        {
            Assert.IsFalse(41L.IsEven());
        }

        [TestMethod()]
        public void IsEvenTestInt()
        {
            Assert.IsTrue(42.IsEven());
        }
        [TestMethod()]
        public void IsNotEvenTestInt()
        {
            Assert.IsFalse(41.IsEven());
        }

        [TestMethod()]
        public void IsOddTestLong()
        {
            Assert.IsTrue(41L.IsOdd());
        }
        [TestMethod()]
        public void IsNotOddTestLong()
        {
            Assert.IsFalse(42L.IsOdd());
        }

        [TestMethod()]
        public void IsOddTestInt()
        {
            Assert.IsTrue(41.IsOdd());
        }
        [TestMethod()]
        public void IsNotOddTestInt()
        {
            Assert.IsFalse(42.IsOdd());
        }


        /// <summary>
        ///A test for GetPrimesFactor
        ///</summary>
        [TestMethod()]
        public void GetPrimesFactorTest1()
        {
            var testRange = new Dictionary<long, long[]>();

            testRange.Add(2, new long[] { 2});
            testRange.Add(3, new long[] { 3});
            testRange.Add(4, new long[] { 2, 2});
            testRange.Add(5, new long[] { 5});
            testRange.Add(6, new long[] { 2, 3});
            testRange.Add(7, new long[] { 7});
            testRange.Add(8, new long[] { 2, 2, 2});

            foreach (var x in testRange.Keys)
            {
                var expected  = testRange[x];
                var actual = x.GetPrimesFactor().ToArray();
                ArrayCompare(expected, actual);

            }
        }


        private static void ArrayCompare(Array expected, Array actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected.GetValue(i), actual.GetValue(i));
            }
        }

    }
}
