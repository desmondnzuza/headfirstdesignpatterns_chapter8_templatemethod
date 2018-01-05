using System;
using CaffeineBeverage.Beverages;

namespace CaffeineBeverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee();
            var tea = new Tea();

            Console.WriteLine("Preparing Coffee's Recipe...");
            coffee.PrepareRecipe();

            Console.WriteLine("\nPreparing Tea's Recipe...");
            tea.PrepareRecipe();

            Console.ReadLine();
        }
    }
}
