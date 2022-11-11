using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example
{
    internal class FileType : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FileType()
        {

        }

        public override string ToString()
        {
            return Name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
