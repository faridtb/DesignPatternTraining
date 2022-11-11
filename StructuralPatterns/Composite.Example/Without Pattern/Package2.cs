namespace Composite.Example
{
    public class Package2
    {
        public string Name { get; set; }
        public List<Product2> Products { get; set; }

        public Package2(string name)
        {
            Name = name;
            Products = new List<Product2>();
        }


        public double GetTotalPrice() 
        { 
            double total = Products.Select(x => x.Price).Sum();
            Console.WriteLine($"{Name} paketinin toplam meblegi: {total}");
            return total;
        }

    }

}