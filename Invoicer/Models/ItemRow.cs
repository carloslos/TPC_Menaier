using System;
using System.Collections.Generic;

namespace Invoicer.Models
{
    public class ItemRow
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

        public static ItemRow Make(string name, string brand, decimal amount, decimal price, decimal total)
        {
            return new ItemRow()
            {
                Name = name,
                Brand = brand,
                Amount = amount,
                Price = price,
                Total = total,
            };
        }
    }
}