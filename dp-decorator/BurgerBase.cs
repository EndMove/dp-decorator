namespace dp_decorator
{
    /// <summary>
    /// Conctrete Small Burger
    /// </summary>
    class SmallBurger : BurgerComponent
    {
        // Base Constructor
        public SmallBurger()
        {
            BaseName = "Burger Small";
            BasePrice = 5.0;
        }
    } 
 
    /// <summary>
    /// Conctrete Medium Burger
    /// </summary>
    class MediumBurger : BurgerComponent
    {
        // Base Constructor
        public MediumBurger()
        {
            BaseName = "Burger Medium";
            BasePrice = 6.5;
        }
    }
 
    /// <summary>
    /// Conctrete Giant Burger
    /// </summary>
    class GiantBurger : BurgerComponent
    {
        // Base Constructor
        public GiantBurger()
        {
            BaseName = "Burger Giant";
            BasePrice = 8.0;
        }
    }
}