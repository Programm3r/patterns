namespace FlyweightPattern
{
    public class Triangle : IShape
    {
        private const string TriangleShape = "Triangle shape";

        public Triangle()
        {
            ShapeType = ShapeType.Triangle;
        }

        public ShapeType ShapeType { get; }

        public string GetShape()
        {
            return TriangleShape;
        }
    }
}