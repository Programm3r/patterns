using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        private readonly Dictionary<ShapeType, Lazy<IShape>> _cachedShapes;

        // if only needed once, consider using static members
        // if it not is required that every instance requires their own dictionary,
        // move this code to the static constructor
        public ShapeFactory()
        {
            _cachedShapes = new Dictionary<ShapeType, Lazy<IShape>>
            {
                [ShapeType.Circle] = new Lazy<IShape>(() =>  new Circle()),
                [ShapeType.Triangle] = new Lazy<IShape>(() => new Triangle()),
                [ShapeType.Rectangle] = new Lazy<IShape>(() => new Rectangle())
            };
        }

        public int TotalShapesCreated { get; private set; }

        public IShape RetrieveShape(ShapeType shapeType)
        {
            // instead of trying to find the entry and then again retrieve it, try to return it
            if (! _cachedShapes.TryGetValue(shapeType, out Lazy<IShape> shapeConstructor))
            {
                // if the shape was not found throw an exception
                throw new UnrecognizedShapeException();
            }

            // if Lazy hasn't been called, this will be the first time, so add one
            if(!shapeConstructor.IsValueCreated)
            {
                TotalShapesCreated++;
            }

            IShape outputShape = shapeConstructor.Value;
            return outputShape;
        }
    }
}