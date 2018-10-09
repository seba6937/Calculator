using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary;

namespace SmartMenuTest
{
    [TestClass]
    public class TestVersion1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SmartMenu smart = new SmartMenu();
            Assert.AreEqual(true, smart.LoadMenu(@"D:\datamatiker\Calculator\SmartMenuLibrary\SmartMenuLibrary\MenuSpec.txt"));
        }
    }
}
