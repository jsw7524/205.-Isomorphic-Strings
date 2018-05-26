using System;
using _205.Isomorphic_Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic("egg","add");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic("foo", "bar");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic("paper", "title");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic("aa", "ab");
            Assert.IsFalse(result);
        }
    }
}
