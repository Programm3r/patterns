namespace BuilderPattern
{
    /// <summary>
    ///     Represent all possible actions that a cooker (builder)
    ///     should be able to do in our restaurant
    /// </summary>
    public interface IMenuBuilder
    {
        void BuildMainDish();
        void BuildDrink();
        void BuildDessert();
        Menu GetMenu();
    }
}
