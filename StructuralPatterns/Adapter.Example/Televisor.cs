using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example
{
    public class Televisor : IHouseholdDevice
    {
        private int voltage;

        public Televisor()
        {
            voltage = 220;
        }
        public int PlugIn()
        {
            Console.WriteLine("Televisor start working");
            return voltage;
        }
    }
}
