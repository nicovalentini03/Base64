using System;
using LibraryBase64;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBase64
{
    [TestClass]
    public class ToBase64Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            string risposta = Base64.EsBase64();
            Assert.AreEqual("Q2lhbw==", risposta);
        }
    }
}
