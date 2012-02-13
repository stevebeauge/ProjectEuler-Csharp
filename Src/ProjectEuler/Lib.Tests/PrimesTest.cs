using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib.Tests
{
    
    
    /// <summary>
    ///This is a test class for PrimesTest and is intended
    ///to contain all PrimesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PrimesTest
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




        [TestMethod()]
        public void GetPrimesTest()
        {
            var primes = Primes.GetPrimes();
            var enumerator = primes.GetEnumerator();

            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual(enumerator.Current, 2UL);
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual(enumerator.Current, 3UL);

            do
            {
                Assert.IsTrue(enumerator.MoveNext());

            } while (enumerator.Current < 997); // Last prime below 1000

            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual(enumerator.Current, 1009UL);
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual(enumerator.Current, 1013UL);
        }

        [TestMethod()]
        public void _1IsNotPrimeTest()
        {
            Assert.IsFalse(Primes.IsPrime(1));
        }
        [TestMethod()]
        public void _2IsPrimeTest()
        {
            Assert.IsTrue(Primes.IsPrime(2));
        }
        [TestMethod()]
        public void _3IsPrimeTest()
        {
            Assert.IsTrue(Primes.IsPrime(3));
        }
        [TestMethod()]
        public void _42IsNotPrimeTest()
        {
            Assert.IsFalse(Primes.IsPrime(42));
        }
        [TestMethod()]
        public void _2001IsNotPrimeTest()
        {
            Assert.IsFalse(Primes.IsPrime(2001));
        }
    }
}
