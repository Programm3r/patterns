namespace FactoryPattern
{
    public interface IProduct<TFactory>
    {
        void Operate();
    }
}