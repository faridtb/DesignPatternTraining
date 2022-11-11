using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example.Composite_Pattern_Style.Concretes
{
    internal class Basket
    {
        public string Name { get; set; }
        public List<IPriceable> Priceables { get; set; }

        public Basket(string name)
        {
            Name = name;
            Priceables = new List<IPriceable>();
        } 

        public double GetTotalResult()
        {
            return Priceables.Select(x => x.GetPrice()).Sum();
        }
    }
}
