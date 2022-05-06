using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UltimateApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AddTest()
        {
            int? retVal = Calculator.calculate(2, 3, Operation.Add);
            //Assert.AreEqual(5, retVal);
            Assert.AreEqual(6, retVal);
        }

        [TestMethod]
        public void SubstractTest()
        {
            int? retVal = Calculator.calculate(2, 3, Operation.Subtract);
            Assert.AreEqual(-1, retVal);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            int? retVal = Calculator.calculate(2, 3, Operation.Multiply);
            Assert.AreEqual(6, retVal);
        }

        [TestMethod]
        public void DivideTest()
        {
            int? retVal = Calculator.calculate(3, 3, Operation.Divide);
            Assert.AreEqual(1, retVal);
        }

        [TestMethod]
        public void ModuloTest()
        {
            int? retVal = Calculator.calculate(3, 3, Operation.Divide);
            Assert.AreEqual(1, retVal);
        }
    }
}
