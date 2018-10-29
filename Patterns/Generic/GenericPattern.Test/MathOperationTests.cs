using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericPattern.Test
{
    [TestClass]
    public class MathOperationTests
    {
        [TestMethod]
        public void It_should_sum_the_numbers()
        {
            Operation<double> plusOperation = new Operation<double>(2, 3);
            var actual = plusOperation.Plus();

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void It_should_sum_when_the_numbers_are_negative()
        {
            Operation<double> plusOperation = new Operation<double>(-3, -7);
            var actual = plusOperation.Plus();

            Assert.AreEqual(-10, actual);
        }

        [TestMethod]
        public void It_should_substract_the_numbers()
        {
            Operation<double> minusOperation = new Operation<double>(8, 2);
            var actual = minusOperation.Minus();

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void It_should_substract_when_the_numbers_are_negative()
        {
            Operation<double> minusOperation = new Operation<double>(-3, -7);
            var actual = minusOperation.Minus();

            Assert.AreEqual(4, actual);
        }
    }
}
