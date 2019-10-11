namespace BuilderPattern
{
    /// <summary>
    ///     This is the fast food cooker,
    ///     he/she only knows how to cook fast food
    /// </summary>
    public class FastFoodMenuBuilder: IMenuBuilder
    {
        private Menu _menu = new Menu();

        public void BuildDessert()
        {
            _menu.AddItem("Ice cream");
        }

        public void BuildDrink()
        {
            _menu.AddItem("Coke");
        }

        public void BuildMainDish()
        {
            _menu.AddItem("Cheeseburger");
        }

        public Menu GetMenu()
        {
            return _menu;
        }
    }
}
