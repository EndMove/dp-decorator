namespace dp_decorator
{
    /// <summary>
    /// Declares the common "interface/abstract class" for decorators and decorated objects (conctrete).
    /// </summary>
    public abstract class BurgerComponent
    {
        // Shared Variables
        protected string BaseName;
        protected double BasePrice;

        public virtual string GetName()
            => BaseName;

        public virtual double GetPrice()
            => BasePrice;
    }
}