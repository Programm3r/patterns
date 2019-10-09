using System;
namespace BuilderPattern
{
    /// <summary>
    ///     This is the Italian cooker, 
    ///     he/she only knows how to cook Italian food
    /// </summary>
    public class ItalianMenuBuilder : IMenuBuilder
    {
        private Menu _menu = new Menu();

        public void BuildDessert()
        {
            _menu.AddItem("Tiramisu");
        }

        public void BuildDrink()
        {
            _menu.AddItem("Lambrusco");
        }

        public void BuildMainDish()
        {
            _menu.AddItem("Spaghetti");
        }

        public Menu GetMenu()
        {
            return _menu;
        }
    }
}
