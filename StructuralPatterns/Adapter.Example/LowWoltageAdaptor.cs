using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example
{
    internal class LowWoltageAdaptor : IHouseholdDevice
    {
        private Laptop laptop;

        public LowWoltageAdaptor(Laptop laptop)
        {
            this.laptop = laptop;
        }

        public int PlugIn()
        {
            Console.WriteLine("Adaptor connected to plug");
            return laptop.Charge();
        }
    }
}
