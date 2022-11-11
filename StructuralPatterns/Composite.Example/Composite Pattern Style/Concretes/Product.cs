using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example.Composite_Pattern_Style.Concretes
{
    internal class Product : IPriceable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double GetPrice()
        {
            return this.Price;
        }
    }
}
