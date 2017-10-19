namespace FactoryPattern
{
    public interface IFactory<TFactory>
    {
        TProduct Build<TProduct>() where TProduct : IProduct<TFactory>, new();
    }
}