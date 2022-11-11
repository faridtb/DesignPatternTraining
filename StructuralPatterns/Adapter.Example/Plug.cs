using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example
{
    public class Plug
    {
        public void Electrify(IHouseholdDevice devices)
        {
            int voltage = devices.PlugIn();
            Console.WriteLine($"Plug send:{voltage} volt electricty");
        }
    }
}
