using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Product
    {
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name,double price,double discountPercent)
        {
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }

        public string Name;
        public double Price;
        public double DiscountPercent;
    }
}
