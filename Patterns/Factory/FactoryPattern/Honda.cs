using System;

namespace FactoryPattern
{
    public class Honda : IProduct<Car>
    {
        public void Operate()
        {
            Console.WriteLine("Driving Honda.");
        }

        public void HondaSpecificOperation()
        {
            Console.WriteLine("Performing Honda-specific operation.");
        }
    }
}