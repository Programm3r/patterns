using System;

namespace FactoryPattern
{
    public class Engine<TFactory> : IProduct<TFactory>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Engine.");
        }

        public void EngineSpecificOperation()
        {
            Console.WriteLine("Performing Engine-specific operation.");
        }
    }
}