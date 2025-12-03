using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public static class OrderCalculator
    {
        // Prices must match the ones in Program.cs
        public const double BurgerPrice = 6.45;
        public const double PizzaPrice = 9.99;
        public const double SaladPrice = 4.99;
        public const double FrenchFriesPrice = 5.45;
        public const double BeefSausagePrice = 9.20;
        public const double SodaPrice = 2.25;

        // Add the selected item (by menu number) to the total and return new total
        public static double AddItem(double currentTotal, byte menuItem)
        {
            switch (menuItem)
            {
                case 1: return currentTotal + BurgerPrice;
                case 2: return currentTotal + PizzaPrice;
                case 3: return currentTotal + SaladPrice;
                case 4: return currentTotal + FrenchFriesPrice;
                case 5: return currentTotal + BeefSausagePrice;
                case 6: return currentTotal + SodaPrice;
                default:
                    // invalid item -> no change
                    return currentTotal;
            }
        }

        // Calculate tip amount; if tipPercentage < 0 returns 0
        public static double CalculateTipAmount(double total, double tipPercentage)
        {
            if (tipPercentage < 0)
                return 0.0;

            return total * (tipPercentage / 100.0);
        }

        // Return final total (total + tip amount)
        public static double CalculateFinalTotal(double total, double tipPercentage)
        {
            double tip = CalculateTipAmount(total, tipPercentage);
            return total + tip;
        }
    }
}
