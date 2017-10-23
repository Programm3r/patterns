using NUnit.Framework;

namespace SingletonPattern.Test
{
    [TestFixture]
    public class When_getting_logger_instance
    {
        [TestCase]
        public void It_should_return_always_the_same_instance()
        {
            var firstLogger = Logger.Instance;
            var secondLogger = Logger.Instance;

            Assert.AreSame(firstLogger, secondLogger);
        }
    }
}