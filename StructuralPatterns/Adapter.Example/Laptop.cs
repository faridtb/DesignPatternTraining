using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example
{
    public class Laptop : ILowVoltageDevice
    {
        private int voltage;

        public Laptop()
        {
            voltage = 15;
        }
        public int Charge()
        {
            Console.WriteLine("Laptop start working");
            return voltage;
        }

    }
}
