using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandPattern.Test
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void AddCommandPositiveTest()
        {
            int a = 10;
            int b = 3;

            Invoker invoker = new Invoker();
            ReceiverCalculator receiverCalculator = new ReceiverCalculator(a, b);
            AddCommand addCommand = new AddCommand(receiverCalculator);

            var expected = invoker.ExecuteCommand(addCommand);

            Assert.AreEqual(expected, 13);
        }

        [TestMethod]
        public void SubstractCommandPositiveTest()
        {
            int a = 10;
            int b = 3;

            Invoker invoker = new Invoker();
            ReceiverCalculator receiverCalculator = new ReceiverCalculator(a, b);
            SubstractCommand substractCommand = new SubstractCommand(receiverCalculator);

            var expected = invoker.ExecuteCommand(substractCommand);

            Assert.AreEqual(expected, 7);
        }
    }
}
