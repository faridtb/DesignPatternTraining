using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example.Dtos
{
    internal class PhoneCreateDto
    {
        public string Model { get; set; }
        public int Memory { get; set; }
        public int Count { get; set; }
    }
}
