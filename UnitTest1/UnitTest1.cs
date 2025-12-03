using NUnit.Framework;
using task_5;   

namespace UnitTest1
{
    [TestFixture]
    public class OrderCalculatorTests
    {
        const double TOL = 1e-6;  

        [Test]
        public void AddItem_AddsBurger_PriceAdded()
        {
            double total = 0.0;

            total = OrderCalculator.AddItem(total, 1); // Burger

            Assert.AreEqual(OrderCalculator.BurgerPrice, total, TOL);
        }

        [Test]
        public void AddItem_AddsMultipleItems_CorrectTotal()
        {
            double total = 0.0;

            total = OrderCalculator.AddItem(total, 1); // Burger
            total = OrderCalculator.AddItem(total, 6); // Soda

            double expected = OrderCalculator.BurgerPrice + OrderCalculator.SodaPrice;

            Assert.AreEqual(expected, total, TOL);
        }

        [Test]
        public void AddItem_InvalidItem_NoChange()
        {
            double total = 10.0;

            total = OrderCalculator.AddItem(total, 99); // invalid menu item

            Assert.AreEqual(10.0, total, TOL);
        }

        [Test]
        public void CalculateTip_PositivePercentage_CorrectTip()
        {
            double total = 20.0;

            double tip = OrderCalculator.CalculateTipAmount(total, 15); // 15%

            Assert.AreEqual(3.0, tip, TOL);
        }

        [Test]
        public void CalculateTip_NegativePercentage_ReturnsZero()
        {
            double total = 20.0;

            double tip = OrderCalculator.CalculateTipAmount(total, -10); // invalid

            Assert.AreEqual(0.0, tip, TOL);
        }

        [Test]
        public void CalculateFinalTotal_IncludesTip()
        {
            double total = 10.0;

            double finalTotal = OrderCalculator.CalculateFinalTotal(total, 10); // 10% → +1

            Assert.AreEqual(11.0, finalTotal, TOL);
        }
    }
}