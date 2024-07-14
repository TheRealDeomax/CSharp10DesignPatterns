// create a program for a discount percentage depending on the country of origin using a factory method pattern

using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the country of origin: ");
            string country = Console.ReadLine();

            DiscountFactory factory = new DiscountFactory();
            IDiscount discount = factory.GetDiscount(country);
            Console.WriteLine(discount.GetDiscount());
        }
    }
}



