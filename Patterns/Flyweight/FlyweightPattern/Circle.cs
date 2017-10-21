namespace FlyweightPattern
{
    public class Circle : IShape
    {
        private const string CircleShape = "Circle shape";

        public Circle()
        {
            ShapeType = ShapeType.Circle;
        }

        public ShapeType ShapeType { get; }

        public string GetShape()
        {
            return CircleShape;
        }
    }
}