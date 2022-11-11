using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example
{
    internal class Agent
    {
        public static void AddHouse(House house)
        {
            Console.WriteLine($"Ev elave edildi - Detallar:\n" +
                $"{house} ");
        }
    }
}
