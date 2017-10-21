namespace FlyweightPattern
{
    public interface IShape
    {
        ShapeType ShapeType { get; }

        string GetShape();
    }
}