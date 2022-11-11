using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private static Person Buddy { get; set; }


        private Person()
        {

        }

        public static Person GetPerson()
        {
            // Her defesinde sorgu getdikde eger bu tipde bir
            // obyekt yaradilmayibsa ilk defe sorguda yaranacaq ve bundan sonra artiq yaradilmayacaq
            if (Buddy == null)
            {
                Person buddy = new()
                {
                    Id = 1,
                    Name = "Farid",
                    Surname = "Baliyev"
                };
                return buddy;
            }
            return Buddy;
        }


    }
}
