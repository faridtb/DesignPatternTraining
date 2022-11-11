using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example
{
    internal class MyFile : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FileType Type { get; set; }
        public FileCategory Category { get; set; }
        public string Data { get; set; }

        public MyFile()
        {

        }

        public MyFile(int id, string name, FileType type, FileCategory category, string data)
        {
            Id = id;
            Name = name;
            Type = type;
            Category = category;
            Data = data;
        }

        public override string ToString()
        {
            return ($"Id:{Id}\n" +
                $"File:{Name}\n" +
                $"Type:{Type}\n" +
                $"Category:{Category}\n" +
                $"Data:{Data}");
        }

        public object Clone()
        {
            // Normalda Shallow Copy edir yeni eyni referensa bagli olduqlarindan elaqeli entityleri deyishdirdikde klonla esas
            // klassda artiq deyishmish olurdu, biz her bir entitye clone yazaraq sonra esasda onlari cagiraraq deyirik ki, Deep Copy Edin.

            MyFile file = (MyFile)this.MemberwiseClone();
            FileCategory category = (FileCategory)file.Category.Clone();
            FileType type = (FileType)file.Type.Clone();

            file.Category = category;
            file.Type = type;

            return file;
        }
    }
}
