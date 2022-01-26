using System;

// Decorator design pettern example by EndMove.

namespace dp_decorator
{
    public static class Program
    {
        // Entry point
        private static void Main()
        {
            // Simple Burger
            SmallBurger smallBurger = new SmallBurger();
            ShowOrderInfos(smallBurger, 1);

            MediumBurger mediumBurger = new MediumBurger();
            ShowOrderInfos(mediumBurger, 2);

            GiantBurger giantBurger = new GiantBurger();
            ShowOrderInfos(giantBurger, 3);

            // Personalised burger
            BelgianFries sBurgerFries = new BelgianFries(smallBurger);
            BelgianMayonnaise sBurgerFriesMayo = new BelgianMayonnaise(sBurgerFries);
            ShowOrderInfos(sBurgerFriesMayo, 4);
        }

        /// <summary>
        /// Dislay Burger Details
        /// </summary>
        /// <param name="burger">BurgerComponents implementation</param>
        /// <param name="number">Order number</param>
        private static void ShowOrderInfos(BurgerComponent burger, int number)
        {
            Console.WriteLine($"Order informations: N°{number} -> {burger.GetName()}, Price: {burger.GetPrice()}$");
        }
    }
}
