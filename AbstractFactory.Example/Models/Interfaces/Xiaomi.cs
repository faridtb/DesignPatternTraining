using AbstractFactory.Example.Models.Concretes;

namespace AbstractFactory.Example.Models.Interfaces
{
    internal class Xiaomi : IPhone
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Count { get; set; }
        public int Memory { get; set; }

        public Xiaomi(string model, int count, int memory)
        {
            Model = model;
            Brand = typeof(Xiaomi).Name;
            Count = count;
            Memory = memory;
        }

        public string GetBrand()
        {
            return Brand;
        }

        public int GetCount()
        {
            return Count;
        }

        public int GetMemory()
        {
            return Memory;
        }

        public string GetModel()
        {
            return Model;
        }


        public override string ToString()
        {
            return $"Phone: {Brand} {Model} \n" +
                $"Count:{Count}\n" +
                $"Memory:{Memory}";
        }



    }
}
