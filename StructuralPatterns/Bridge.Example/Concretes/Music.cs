using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Concretes
{
    public class Music
    {
        public string Name { get; set; }
        public string Volume { get; set; }

        public Music(string name, string volume)
        {
            Name = name;
            Volume = volume;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
