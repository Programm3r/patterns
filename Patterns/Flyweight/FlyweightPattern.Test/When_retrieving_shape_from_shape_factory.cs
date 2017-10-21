using NUnit.Framework;

namespace FlyweightPattern.Test
{
    [TestFixture]
    public class When_retrieving_shape_from_shape_factory
    {
        [SetUp]
        public void SetUp()
        {
            _shapeFactory = new ShapeFactory();
        }

        private ShapeFactory _shapeFactory;

        [TestCase(ShapeType.Triangle)]
        [TestCase(ShapeType.Circle)]
        [TestCase(ShapeType.Recatngle)]
        public void It_should_retrieve_the_same_object_for_one_shape_type(ShapeType shapeType)
        {
            var firstShape = _shapeFactory.RetrieveShape(shapeType);
            var secondShape = _shapeFactory.RetrieveShape(shapeType);

            Assert.AreSame(firstShape, secondShape);
        }

        [TestCase]
        public void It_should_create_only_one_object_per_shape()
        {
            var firstCircle = _shapeFactory.RetrieveShape(ShapeType.Circle);
            var secondCircle = _shapeFactory.RetrieveShape(ShapeType.Circle);
            var thirdCircle = _shapeFactory.RetrieveShape(ShapeType.Circle);

            var firstTriangle = _shapeFactory.RetrieveShape(ShapeType.Triangle);
            var secondTriangle = _shapeFactory.RetrieveShape(ShapeType.Triangle);
            var thirdTriangle = _shapeFactory.RetrieveShape(ShapeType.Triangle);

            var firstRecatngle = _shapeFactory.RetrieveShape(ShapeType.Recatngle);
            var secondRecatngle = _shapeFactory.RetrieveShape(ShapeType.Recatngle);
            var thirdRecatngle = _shapeFactory.RetrieveShape(ShapeType.Recatngle);

            Assert.AreEqual(3, _shapeFactory.TotalShapesCreated);
        }

        [TestCase]
        public void It_should_throw_exception_for_invalid_shape()
        {
            Assert.Catch<UnrecognizedShapeException>(() => { _shapeFactory.RetrieveShape((ShapeType) 20); });
        }
    }
}