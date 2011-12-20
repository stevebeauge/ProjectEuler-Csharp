using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibTest
{


    /// <summary>
    ///This is a test class for NumbersTest and is intended
    ///to contain all NumbersTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NumbersTest
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
        ///A test for GetTriangleNumbers
        ///</summary>
        [TestMethod()]
        public void GetTriangleNumbersTest()
        {
            int[] expected = { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };
            int[] actual = Numbers.GetTriangleNumbersInt32().Take(10).ToArray();

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }
        /// <summary>
        ///A test for GetTriangleNumbers
        ///</summary>
        [TestMethod()]
        public void GetTriangleNumbersTestLong()
        {
            long[] expected = { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };
            long[] actual = Numbers.GetTriangleNumbersInt64().Take(10).ToArray();

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}