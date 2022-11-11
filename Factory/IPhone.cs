using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal interface IPhone
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Count { get; set; }
        public int Memory { get; set; }


        string GetModel();
        string GetBrand();
        int GetCount();
        int GetMemory();


    }
}
