using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryPattern.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var carFactory = new Factory<Car>();

            IProduct<Car> carProduct = carFactory.Create<Toyota>();
            carProduct.Operate();
        }
    }
}
