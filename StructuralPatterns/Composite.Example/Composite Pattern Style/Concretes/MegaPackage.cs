using Composite.Example.Composite_Pattern_Style.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example.Composite_Pattern_Style.Concretes
{
    internal class MegaPackage : IPriceable
    {
        public string Name { get; set; }
        public List<Package> Packages { get; set; }
        public List<Product> Products { get; set; }

        public MegaPackage(string name)
        {
            Name = name;
            Packages = new List<Package>();
            Products = new List<Product>();
        }
         
        public double GetPrice()
        {
            PriceCalculator calculator;
            double totalProductPrice = PriceCalculator.GetTotalProductPrice(this.Products); 
            double totalPackagePrice = PriceCalculator.GetTotalPackagePrice(this.Packages); 
            
            return totalProductPrice + totalPackagePrice;
        }
    }
}
