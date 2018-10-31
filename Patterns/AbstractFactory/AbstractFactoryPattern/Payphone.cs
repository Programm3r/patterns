using System;

namespace AbstractFactoryPattern
{
    public class Payphone : ICordedPhone
    {
        public string Name()
        {
            return "Payphone";
        }
    }
}
