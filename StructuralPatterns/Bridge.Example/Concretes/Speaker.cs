using Bridge.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Concretes
{
    public class Speaker : ISpeaker
    {
        public void VolumeSound(string sound)
        {
            Console.WriteLine($"Səs gücləndirici səviyyəsi :{sound}");
        }
    }
}
