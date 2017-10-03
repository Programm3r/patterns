using System;

namespace FactoryPattern
{
    public class Frame<TFactory> : IProduct<Car>, IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Frame.");
        }

        public void FrameSpecificOperation()
        {
            Console.WriteLine("Performing Frame-specific operation.");
        }
    }
}