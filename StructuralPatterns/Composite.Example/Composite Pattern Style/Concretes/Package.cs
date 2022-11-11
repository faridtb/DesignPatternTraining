using Composite.Example.Composite_Pattern_Style.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example.Composite_Pattern_Style.Concretes
{
    internal class Package : IPriceable
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Package(string name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public double GetPrice()
        {
            return PriceCalculator.GetTotalProductPrice(this.Products);
        }
    }
}
