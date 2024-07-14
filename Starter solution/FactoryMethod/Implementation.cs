namespace FactoryMethod
{
   // create an abstraction class for country discount European countries 5% discount and 10% discount for non-European countries

    public interface IDiscount
    {
        string GetDiscount();
    }

    // create a class for European countries discount
    public class EuropeanDiscount : IDiscount
    {
        public string GetDiscount()
        {
            return "5% discount";
        }
    }

    // create a class for non-European countries discount
    public class NonEuropeanDiscount : IDiscount
    {
        public string GetDiscount()
        {
            return "10% discount";
        }
    }

    // create a factory class for discount
    public class DiscountFactory
    {
        public IDiscount GetDiscount(string country)
        {
            if (country == "EU")
            {
                return new EuropeanDiscount();
            }
            else
            {
                return new NonEuropeanDiscount();
            }
        }
    }

}
