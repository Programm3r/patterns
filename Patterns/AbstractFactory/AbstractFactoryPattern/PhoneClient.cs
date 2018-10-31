namespace AbstractFactoryPattern
{
    public class PhoneClient
    {
        private readonly IPhone _phone;
        private readonly ICordedPhone _cordedPhone;

        public PhoneClient(IPhoneFactory phoneFactory, string phoneType)
        {
            _phone = phoneFactory.GetPhone(phoneType);
            _cordedPhone = phoneFactory.GetCordedPhone(phoneType);
        }

        public string GetPhoneName()
        {
            return _phone.Name();
        }

        public string GetCordedPhoneName()
        {
            return _cordedPhone.Name();
        }
    }
}
