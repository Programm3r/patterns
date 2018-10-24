namespace FlyweightPattern
{
    public class Rectangle : IShape
    {
        private const string RectangleShape = "Rectangle shape";

        public Rectangle()
        {
            ShapeType = ShapeType.Rectangle;
        }

        public ShapeType ShapeType { get; }

        public string GetShape()
        {
            return RectangleShape;
        }
    }
}