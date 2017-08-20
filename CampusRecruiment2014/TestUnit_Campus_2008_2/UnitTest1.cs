using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestUnit_Campus_2008_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "...##--.#.";
            string expect = "NGG";
            Assert.AreNotSame(input, expect);
            Assert.AreEqual(input, expect);
        }
    }
}
