namespace dp_decorator
{
    /// <summary>
    /// Decorator Fries
    /// </summary>
    class BelgianFries : Decorator
    {
        public BelgianFries(BurgerComponent burger)
            : base(burger)
        {
            DecName = "Belgian Fries";
            DecPrice = 2.5;
        }
    }
 
    /// <summary>
    /// Decorator Mayonnaise
    /// </summary>
    class BelgianMayonnaise : Decorator
    {
        public BelgianMayonnaise(BurgerComponent burger)
            : base(burger)
        {
            DecName = "Belgian Mayonnaise";
            DecPrice = 0.5;
        }
    }
}