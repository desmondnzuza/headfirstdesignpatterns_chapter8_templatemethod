using System;

namespace CaffeineBeverage.Beverages
{
    internal abstract class CaffeineBeverage
    {
        internal void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        internal abstract void Brew();
        
        internal abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
