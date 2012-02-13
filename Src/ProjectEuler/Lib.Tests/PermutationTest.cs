using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Lib.Tests
{
    
    
    /// <summary>
    ///This is a test class for PermutationTest and is intended
    ///to contain all PermutationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PermutationTest
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
        public void PermutationsTest()
        {
            var source = "abc";

            var actual = Permutation.Enumerate(source.ToCharArray());

            var @enum = actual.GetEnumerator();

            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current), "abc");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current), "acb");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current), "bac");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current), "bca");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current), "cba");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current), "cab");
            Assert.IsFalse(@enum.MoveNext());

        }
    }
}
