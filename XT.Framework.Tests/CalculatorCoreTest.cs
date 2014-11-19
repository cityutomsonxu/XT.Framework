using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XT.Calculator.Framework;

namespace XT.Framework.Tests
{
    [TestClass]
    public class CalculatorCoreTest
    {
        [TestMethod]
        public void Test_CalculatorCore_Add()
        {
            CalculatorCore cal = new CalculatorCore();
            int result = cal.add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
