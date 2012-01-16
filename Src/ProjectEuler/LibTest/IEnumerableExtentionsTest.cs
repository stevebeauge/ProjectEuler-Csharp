using Lib.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibTest
{
    
    
    /// <summary>
    ///This is a test class for IEnumerableExtentionsTest and is intended
    ///to contain all IEnumerableExtentionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IEnumerableExtentionsTest
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
        [DeploymentItem("Lib.dll")]
        public void GetPermutationsTest()
        {
            var source = "abc";

            var actual = source.GetPermutations();

            var @enum = actual.GetEnumerator();

            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "abc");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "acb");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "bac");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "bca");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "cab");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "cba");
            Assert.IsFalse(@enum.MoveNext());


        }


        [TestMethod()]
        public void GetRotationsTest()
        {
            var source = "abc";

            var actual = source.GetRotations();

            var @enum = actual.GetEnumerator();

            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "abc");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "bca");
            Assert.IsTrue(@enum.MoveNext());
            Assert.AreEqual(new string(@enum.Current.ToArray()), "cab");
            Assert.IsFalse(@enum.MoveNext());
        }
    }
}
