using SuppliesPriceLister.Models.Views;
using SuppliesPriceLister.Utilites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using SuppliesPriceLister.Handler;

namespace SuppliesPriceLister
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceListerHandler priceListerHandler = new PriceListerHandler();

            var combinedSupplies = priceListerHandler.combinepricedata();

            foreach (var supply in combinedSupplies)
            {
                Console.WriteLine(supply.Id + ", " + supply.Name + ", " + supply.Price);
            }

            Console.ReadLine();
        }
    }
}
