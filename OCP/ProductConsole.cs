using System;
using System.Collections.Generic;

namespace BreakingOpenClosedPrinciple
{
    class ProductConsole
    {
        public static void Main()
        {
            var product1 = new StandardProduct(4.52m);
            var product2 = new FeaturedProduct(3.99m);
            var product3 = new SpecialProduct(22.55m);

            var products = new List<Product>();

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            foreach (Product product in products)
            {
                product.Render();
            }


            Console.WriteLine("FINISHED......press any key");
            Console.ReadKey();

        }
    }

    internal class FeaturedProduct : Product
    {
        private readonly decimal _price;

        public FeaturedProduct(decimal price)
        {
            _price = price;
        }

        public override void  Render()
        {
            Console.WriteLine("******* WOO HOOO *******");
            Console.WriteLine("******* FEATURED PRODUCT HERE **********");
            Console.WriteLine("******* I COST £{0} **********", _price);

        }
    }

    public class StandardProduct : Product
    {
        private readonly decimal _price;

        public StandardProduct(decimal price)
        {
            _price = price;
        }

        public override void Render()
        {
            Console.WriteLine("Hi, I am a standard product that costs £{0}", _price);
        }
    }

    public class SpecialProduct : Product
    {
        private readonly decimal _price;

        public SpecialProduct(decimal price)
        {
            _price = price;
        }

        public override void Render()
        {
            Console.WriteLine("Hi, I am a standard product that costs £{0}", _price);
        }
    }
}
