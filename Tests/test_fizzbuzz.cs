using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace Tests
{
    /// <summary>
    /// Summary description for test_fizzbuzz
    /// </summary>
    [TestClass]
    public class test_fizzbuzz
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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            int s = 0;
            int e = 100;
            Object[] fizzy = Fizz.fizzbuzzfunc(s, e);
            for (int i = 0; i<fizzy.Length-1;i++)
            {
                if(i%3==0 && i%5==0)
                    Assert.AreEqual("Fizzbuzz", fizzy[i]);
                else if (i % 3 == 0)
                    Assert.AreEqual("Fizz", fizzy[i]);
                else if (i % 5 == 0)
                    Assert.AreEqual("Buzz", fizzy[i]);
                else
                    Assert.AreEqual(i, fizzy[i]);
            }
        }
    }
}
