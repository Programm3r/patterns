using System;

namespace AbstractFactoryPattern
{
    public class NokiaFactory : IPhoneFactory
    {
        public IPhone GetPhone(string phoneType)
        {
            switch (phoneType)
            {
                case "SmartPhone":
                    return new SmartPhone();
                case "BasicPhone":
                    return new BasicPhone();
                default:
                    throw new Exception("There isn't any" + phoneType + "type");
            }
        }

        public ICordedPhone GetCordedPhone(string phoneType)
        {
            switch (phoneType)
            {
                case "SmartPhone":
                    return new HomePhone();
                case "BasicPhone":
                    return new Payphone();
                default:
                    throw new Exception("There isn't any" + phoneType + "type");
            }
        }
    }
}
