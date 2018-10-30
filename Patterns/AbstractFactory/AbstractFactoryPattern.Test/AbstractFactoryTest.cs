using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactoryPattern.Test
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void NokiaFactoryPositiveTest()
        {
            IPhoneFactory nokiaFactory = new NokiaFactory();
            
            PhoneClient phoneClient = new PhoneClient(nokiaFactory, "SmartPhone");
            var phoneName = phoneClient.GetPhoneName();
            var cordedPhoneName = phoneClient.GetCordedPhoneName();

            PhoneClient phoneClient2 = new PhoneClient(nokiaFactory, "BasicPhone");
            var phoneName2 = phoneClient2.GetPhoneName();
            var cordedPhoneName2 = phoneClient2.GetCordedPhoneName();

            Assert.AreEqual("SmartPhone", phoneName);
            Assert.AreEqual("HomePhone", cordedPhoneName);
            Assert.AreEqual("BasicPhone", phoneName2);
            Assert.AreEqual("Payphone", cordedPhoneName2);
        }

        [TestMethod]
        public void SamsungFactoryPositiveTest()
        {
            IPhoneFactory samsungFactory = new SamsungFactory();

            PhoneClient phoneClient = new PhoneClient(samsungFactory, "SmartPhone");
            var phoneName = phoneClient.GetPhoneName();
            var cordedPhoneName = phoneClient.GetCordedPhoneName();

            PhoneClient phoneClient2 = new PhoneClient(samsungFactory, "BasicPhone");
            var phoneName2 = phoneClient2.GetPhoneName();
            var cordedPhoneName2 = phoneClient2.GetCordedPhoneName();

            Assert.AreEqual("SmartPhone", phoneName);
            Assert.AreEqual("HomePhone", cordedPhoneName);
            Assert.AreEqual("BasicPhone", phoneName2);
            Assert.AreEqual("Payphone", cordedPhoneName2);
        }
    }
}
