namespace dp_decorator
{
    public abstract class Decorator : BurgerComponent
    {
        // Variables
        private readonly BurgerComponent _baseComponent;
        
        // Shared Variables
        protected string DecName = "Undefined Decorator";
        protected double DecPrice = 0.0;
 
        /// <summary>
        /// Decorator Constructor
        /// </summary>
        /// <param name="burger">Commonent to add to the default burger</param>
        protected Decorator(BurgerComponent burger)
            => _baseComponent = burger;

        #region BurgerComponent's overriding members
        public override string GetName()
            => $"{_baseComponent.GetName()}, {DecName}";

        public override double GetPrice()
            => _baseComponent.GetPrice() + DecPrice;
        #endregion
    }
}