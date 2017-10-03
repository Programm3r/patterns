using System;

namespace FactoryPattern
{
    public class Toyota : IProduct<Car>
    {
        public void Operate()
        {
            Console.WriteLine("Driving Toyota.");
        }

        public void ToyotaSpecificOperation()
        {
            Console.WriteLine("Performing Toyota-specific operation.");
        }
    }
}