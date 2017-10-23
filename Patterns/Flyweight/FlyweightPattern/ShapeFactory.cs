using System.Collections.Generic;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        private readonly Dictionary<ShapeType, IShape> _cachedShapes;

        public ShapeFactory()
        {
            _cachedShapes = new Dictionary<ShapeType, IShape>();
        }

        public int TotalShapesCreated { get; private set; }

        public IShape RetrieveShape(ShapeType shapeType)
        {
            IShape outputShape;

            if (_cachedShapes.ContainsKey(shapeType))
            {
                outputShape = _cachedShapes[shapeType];
            }
            else
            {
                switch (shapeType)
                {
                    case ShapeType.Circle:
                        outputShape = new Circle();
                        break;
                    case ShapeType.Triangle:
                        outputShape = new Triangle();
                        break;
                    case ShapeType.Recatngle:
                        outputShape = new Rectangle();
                        break;
                    default:
                        throw new UnrecognizedShapeException();
                }
                TotalShapesCreated++;
                _cachedShapes.Add(shapeType, outputShape);
            }

            return outputShape;
        }
    }
}