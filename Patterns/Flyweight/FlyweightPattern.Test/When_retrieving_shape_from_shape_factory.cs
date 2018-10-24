using NUnit.Framework;

namespace FlyweightPattern.Test
{
    [TestFixture]
    public class When_retrieving_shape_from_shape_factory
    {
        [TestCase(ShapeType.Triangle)]
        [TestCase(ShapeType.Circle)]
        [TestCase(ShapeType.Rectangle)]
        public void It_should_retrieve_the_same_object_for_one_shape_type(ShapeType shapeType)
        {
            // arrange
            var shapeFactory = new ShapeFactory();

            // act
            var firstShape = shapeFactory.RetrieveShape(shapeType);
            var secondShape = shapeFactory.RetrieveShape(shapeType);

            // assert
            Assert.That(firstShape, Is.EqualTo(secondShape));
            Assert.That(shapeFactory.TotalShapesCreated, Is.EqualTo(1));
        }

        [TestCase]
        public void It_should_create_only_one_object_per_shape()
        {
            // arrange
            var shapeFactory = new ShapeFactory();

            // act
            var firstCircle = shapeFactory.RetrieveShape(ShapeType.Circle);
            var secondCircle = shapeFactory.RetrieveShape(ShapeType.Circle);
            var thirdCircle = shapeFactory.RetrieveShape(ShapeType.Circle);

            var firstTriangle = shapeFactory.RetrieveShape(ShapeType.Triangle);
            var secondTriangle = shapeFactory.RetrieveShape(ShapeType.Triangle);
            var thirdTriangle = shapeFactory.RetrieveShape(ShapeType.Triangle);

            var firstRecatngle = shapeFactory.RetrieveShape(ShapeType.Rectangle);
            var secondRecatngle = shapeFactory.RetrieveShape(ShapeType.Rectangle);
            var thirdRecatngle = shapeFactory.RetrieveShape(ShapeType.Rectangle);

            // assert
            Assert.That(shapeFactory.TotalShapesCreated, Is.EqualTo(3));
        }

        [TestCase]
        public void It_should_throw_exception_for_invalid_shape()
        {
            Assert.That(() => new ShapeFactory().RetrieveShape((ShapeType) 20), Throws.InstanceOf<UnrecognizedShapeException>());
        }
    }
}