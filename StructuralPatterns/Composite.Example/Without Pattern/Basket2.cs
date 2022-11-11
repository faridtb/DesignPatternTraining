using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example
{
    public class Basket2
    {
        public string Name { get; set; }
        public List<Product2> Products { get; set; }
        public List<Package2> Packages { get; set; }

        public Basket2(string name)
        {
            Name = name;
            Products = new List<Product2>();
            Packages = new List<Package2>();
        }


        public double GetTotalPrice()
        {
            double total = Products.Select(p => p.Price).Sum()
                + Packages.Select(p => p.GetTotalPrice()).Sum();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.CursorLeft = 29;
            Console.WriteLine($"Yekun mebleg:{total}");
            Console.ResetColor();

            return total;

        }

        public void GetDetailedPrice()
        {
            double total = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sebetde olan paketler:");
            Console.ResetColor();
            foreach (var item in Packages)
            {
                item.GetTotalPrice();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sebetde olan mehsullar");
            Console.ResetColor();
            foreach (var item in Products)
            {
                Console.WriteLine($"{item.Name} mehsulun qiymeti: {item.Price}");
            }
            GetTotalPrice();
        }
    }
}
