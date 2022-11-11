using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example
{
    public class Refrigerator : IHouseholdDevice
    {
        private int voltage;

        public Refrigerator()
        {
            voltage = 220;
        }
        public int PlugIn()
        {
            Console.WriteLine("Refrierator start working");
            return voltage;
        }
    }
}
