using System;

namespace FactoryPattern
{
    public class Car : IFactory<Car>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<Car>, new()
        {
            Console.WriteLine("Creating Car: " + typeof(TProduct));
            return new TProduct();
        }
    }
}