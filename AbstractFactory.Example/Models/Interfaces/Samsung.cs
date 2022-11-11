using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Example.Models.Concretes;

namespace AbstractFactory.Example.Models.Interfaces
{
    internal class Samsung : IPhone
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Count { get; set; }
        public int Memory { get; set; }

        public Samsung(string model, int count, int memory)
        {
            Model = model;
            Brand = typeof(Samsung).Name;
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
