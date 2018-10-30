namespace AbstractFactoryPattern
{
    public interface IPhoneFactory
    {
        IPhone GetPhone(string phoneType);
        ICordedPhone GetCordedPhone(string phoneType);
    }
}