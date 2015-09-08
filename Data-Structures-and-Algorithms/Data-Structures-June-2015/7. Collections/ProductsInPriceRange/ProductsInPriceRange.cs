using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

class ProductsInPriceRange
{
    static void Main()
    {
        var products = new OrderedMultiDictionary<decimal, Product>(true);
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string productEntry = Console.ReadLine();
            var productTokens = productEntry.Trim().Split(' ');
            var productName = productTokens[0];
            decimal productPrice = decimal.Parse(productTokens[1]);
            var product = new Product(productName, productPrice);
            products.Add(product.Price ,product);
        }

        string targetPrice = Console.ReadLine();
        var priceTokens = targetPrice.Trim().Split(' ');
        decimal startPrice = decimal.Parse(priceTokens[0]);
        decimal endPrice = decimal.Parse(priceTokens[1]);

        var productsInRange = products.Range(startPrice, true, endPrice, true);

        foreach (var p in productsInRange)
        {
            foreach (var product in p.Value)
            {
                Console.WriteLine("{0} {1}", product.Price, product.Name);
            }
        }
    }
}