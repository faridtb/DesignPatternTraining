using Composite.Example.Composite_Pattern_Style.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example.Composite_Pattern_Style.Utils
{
    internal class PriceCalculator
    {
        public static double GetTotalProductPrice(List<Product> products)
        {
            return products.Select(p => p.GetPrice()).Sum();
        }

        public static double GetTotalPackagePrice(List<Package> packages)
        {
            return packages.Select(p => p.GetPrice()).Sum();
        }
    }
}
