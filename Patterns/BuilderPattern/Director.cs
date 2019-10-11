namespace BuilderPattern
{
    /// <summary>
    ///     This is the waiter (director) that posts the order to the cooker (builder)
    /// </summary>
    public class Director
    {
        /// <summary>
        ///     Ask cookers (builders) to execute tasks
        /// </summary>
        /// <param name="builder">The cooker</param>
        public void BuildMenu(IMenuBuilder builder) 
        {
            builder.BuildMainDish();
            builder.BuildDrink();
            builder.BuildDessert();            
        }
    }
}
