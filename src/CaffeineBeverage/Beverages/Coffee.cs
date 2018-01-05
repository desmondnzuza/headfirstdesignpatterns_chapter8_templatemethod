using System;

namespace CaffeineBeverage.Beverages
{
    internal class Coffee : CaffeineBeverage
    {
        internal override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
