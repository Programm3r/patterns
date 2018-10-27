using NUnit.Framework;

namespace FactoryPattern.Test
{
    [TestFixture]
    public class When_creating_object_through_factory
    {
        [Test]
        public void It_should_create_correct_instance_of_honda()
        {
            // Given
            var carFactory = new Factory<Car>();

            // When
            IProduct<Car> carProduct = carFactory.Create<Honda>();

            // Then
            Assert.IsInstanceOf<Honda>(carProduct);
        }

        [Test]
        public void It_should_create_correct_instance_of_toyota()
        {
            // Given
            var carFactory = new Factory<Car>();

            // When
            IProduct<Car> carProduct = carFactory.Create<Toyota>();

            // Then
            Assert.IsInstanceOf<Toyota>(carProduct);
        }
    }
}